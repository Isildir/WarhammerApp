using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarhammerProfessionApp.Dtos;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models;
using WarhammerProfessionApp.Entities.Models.Enums;

namespace WarhammerProfessionApp.Utility
{
    internal class ProfessionCostManager
    {
        public async Task<ProfessionPathWrapperDto> GetProfessionsPaths(
            int startProfessionId,
            int targetProfessionId,
            byte mappingLevels,
            bool includeStartingProfession,
            bool includeEndingProfession,
            byte race)
        {
            var result = new ProfessionPathWrapperDto();

            if (!FindProfessionPath(startProfessionId, targetProfessionId, race, mappingLevels, out IList<Queue<int>> paths))
                return result;

            var selectedIds = paths.SelectMany(a => a).Distinct().ToList();

            var entities = context.Set<Profession>()
                .Include(a => a.Abilities).ThenInclude(b => b.Abilities).ThenInclude(c => c.Ability)
                .Include(a => a.Skills).ThenInclude(b => b.Skills).ThenInclude(c => c.Skill)
                .Include(a => a.Equipment).ThenInclude(b => b.Items).ThenInclude(c => c.Item)
                .Include(a => a.Statistics).ThenInclude(b => b.Statistic)
                .Include(a => a.OutputProfessions).ThenInclude(b => b.OutputProfession)
                .Include(a => a.EntranceProfessions).ThenInclude(b => b.EntranceProfession)
                .Where(a => selectedIds.Contains(a.Id)).ToList();

            var values = paths.Select(a => a.Select(b => entities.FirstOrDefault(c => c.Id == b))).ToList();

            var startingProfession = !includeStartingProfession ? entities.FirstOrDefault(a => a.Id == startProfessionId) : null;

            var initialStatistics = GetStartingStatistics(startingProfession);

            GetStartingAbilities(startingProfession, out List<int> initialAbilitiesIds, out List<string> initialAbilitiesNames);
            GetStartingSkills(startingProfession, out List<int> initialSkillsIds, out List<string> initialSkillsNames);

            result.InitialValues = new ProfessionPathInitialDto
            {
                Name = entities.FirstOrDefault(a => a.Id == startProfessionId).Name,
                AbilitiesToLearn = new List<string>(initialAbilitiesNames),
                SkillsToLearn = new List<string>(initialSkillsNames),
                Statistics = ConvertStatisticsForUser(initialStatistics)
            };

            var records = new BlockingCollection<ProfessionPathDto>();

            CalculateProfessionResults(records, values, initialAbilitiesIds, initialSkillsIds, initialAbilitiesNames, initialSkillsNames,
                    initialStatistics, includeEndingProfession, targetProfessionId, startProfessionId);

            result.Paths = records.OrderBy(a => a.Summary.MinimalExperienceCost).ToList();

            return result;
        }

        internal ProfessionCostManager(ProfessionsContext context)
        {
            this.context = context;
        }

        private readonly ProfessionsContext context;

        private ProfessionPathDto CalculateProfessionResult(
            IEnumerable<Profession> value,
            List<int> initialAbilitiesIds,
            List<int> initialSkillsIds,
            List<string> initialAbilitiesNames,
            List<string> initialSkillsNames,
            IDictionary<StatisticType, StatisticCompare> initialStatistics,
            bool includeEndingProfession,
            int targetProfessionId,
            int startProfessionId)
        {
            var abilitiesToEarn = new List<int>(initialAbilitiesIds);
            var skillsToEarn = initialSkillsIds.ToDictionary(a => a, a => (byte)1);

            var skillsToEarnNames = new List<string>(initialSkillsNames);
            var abilitiesToEarnNames = new List<string>(initialAbilitiesNames);

            var pathStatistics = initialStatistics.ToDictionary(a => a.Key, a => a.Value);

            var pathResult = new ProfessionPathDto();

            foreach (var profession in value)
            {
                foreach (var key in pathStatistics.Keys.ToList())
                    pathStatistics[key] = new StatisticCompare(pathStatistics[key].NewValue, pathStatistics[key].NewValue);

                var stepResult = new ProfessionPathStepDto { Name = profession.Name };

                var dbAbilities = profession.Abilities.SelectMany(a => a.Abilities.Where(b => !abilitiesToEarn.Contains(b.AbilityId)));

                if (includeEndingProfession || profession.Id != targetProfessionId)
                {
                    var abilitiesWrappers = profession.Abilities.Where(a => a.Abilities.Any(b => !abilitiesToEarn.Contains(b.AbilityId)));
                    var abilitiesCount = abilitiesWrappers.Select(a => new
                    {
                        requiredCount = a.Quantity,
                        notOwnedCount = a.Abilities.Where(b => !abilitiesToEarn.Contains(b.AbilityId)).Count(),
                        totalCount = a.Abilities.Count()
                    });

                    stepResult.MinimalExperienceCost += abilitiesCount.Sum(a => a.requiredCount - (a.totalCount - a.notOwnedCount));
                    stepResult.MaximumExperienceCost += abilitiesCount.Sum(a => a.totalCount - (a.totalCount - a.notOwnedCount));

                    var localAbilities = dbAbilities.Select(a => a.Ability.Name).ToList();
                    var localSkills = new List<string>();

                    abilitiesToEarnNames.AddRange(localAbilities);
                    abilitiesToEarn.AddRange(dbAbilities.Select(c => c.AbilityId));

                    foreach (var skill in profession.Skills.Where(a => a.Skills.Any(b => !skillsToEarn.Where(c => c.Value < 3).Select(c => c.Key).Contains(b.SkillId))))
                    {
                        stepResult.MinimalExperienceCost += skill.Quantity - (skill.Skills.Count - skill.Skills.Where(a => !skillsToEarn.Select(c => c.Key).Contains(a.SkillId)).Count());

                        foreach (var item in skill.Skills)
                        {
                            if (!skillsToEarn.TryGetValue(item.SkillId, out byte skillLevel) || skillLevel < 3)
                            {
                                stepResult.MaximumExperienceCost += 1;

                                if (skillLevel == 0)
                                {
                                    skillsToEarn.Add(item.SkillId, 1);
                                    localSkills.Add(item.Skill.Name);
                                }
                                else
                                {
                                    skillsToEarn[item.SkillId] += 1;
                                    localSkills.Add($"{item.Skill.Name} {skillsToEarn[item.SkillId]}");
                                }
                            }
                        }
                    }

                    skillsToEarnNames.AddRange(localSkills);

                    stepResult.AbilitiesToLearn = new List<string>(localAbilities);
                    stepResult.SkillsToLearn = new List<string>(localSkills);

                    UpdateStatistics(pathStatistics, profession);
                }

                if (profession.Id != startProfessionId)
                {
                    stepResult.MinimalExperienceCost += 1;
                    stepResult.MaximumExperienceCost += 1;
                }

                stepResult.MinimalExperienceCost *= 100;
                stepResult.MaximumExperienceCost *= 100;

                foreach (var pair in pathStatistics.Where(a => a.Value.NewValue > a.Value.OriginalValue))
                {
                    if (pair.Key == StatisticType.Attacks || pair.Key == StatisticType.Hitpoints || pair.Key == StatisticType.Magic || pair.Key == StatisticType.Speed)
                    {
                        stepResult.MinimalExperienceCost += (pair.Value.NewValue - pair.Value.OriginalValue) * 100;
                        stepResult.MaximumExperienceCost += (pair.Value.NewValue - pair.Value.OriginalValue) * 100;
                    }
                    else
                    {
                        stepResult.MinimalExperienceCost += (pair.Value.NewValue - pair.Value.OriginalValue) * 20;
                        stepResult.MaximumExperienceCost += (pair.Value.NewValue - pair.Value.OriginalValue) * 20;
                    }
                }

                stepResult.Statistics = pathStatistics;

                pathResult.Steps.Add(stepResult);
            }

            foreach (var key in pathStatistics.Keys.ToList())
                pathStatistics[key] = new StatisticCompare(initialStatistics[key].OriginalValue, pathStatistics[key].NewValue);

            pathResult.Summary = new ProfessionPathSummaryDto
            {
                Path = string.Join(" => ", value.Select(a => a.Name)),
                SkillsToLearn = new List<string>(skillsToEarnNames),
                AbilitiesToLearn = new List<string>(abilitiesToEarnNames),
                Statistics = pathStatistics,
                MinimalExperienceCost = pathResult.Steps.Sum(a => a.MinimalExperienceCost),
                MaximumExperienceCost = pathResult.Steps.Sum(a => a.MaximumExperienceCost)
            };

            return pathResult;
        }

        private void CalculateProfessionResults(
            BlockingCollection<ProfessionPathDto> results,
            IEnumerable<IEnumerable<Profession>> values,
            List<int> initialAbilitiesIds,
            List<int> initialSkillsIds,
            List<string> initialAbilitiesNames,
            List<string> initialSkillsNames,
            IDictionary<StatisticType, StatisticCompare> initialStatistics,
            bool includeEndingProfession,
            int targetProfessionId,
            int startProfessionId)
        {
            var result = new List<ProfessionPathDto>();

            foreach (var value in values)
                result.Add(CalculateProfessionResult(value, initialAbilitiesIds, initialSkillsIds, initialAbilitiesNames, initialSkillsNames,
                    initialStatistics, includeEndingProfession, targetProfessionId, startProfessionId));

            foreach (var path in result)
                results.Add(path);
        }

        private Dictionary<string, byte> ConvertStatisticsForUser(IDictionary<StatisticType, StatisticCompare> initialStatistics)
            => initialStatistics.ToDictionary(a => a.Key.ToString(), a => a.Value.NewValue > a.Value.OriginalValue ? a.Value.NewValue : a.Value.NewValue);

        private bool FindProfessionPath(int startProfessionId, int targetProfessionId, byte race, byte mappingLevels, out IList<Queue<int>> result)
        {
            var data = context.Set<Profession>().Include(a => a.OutputProfessions).Where(a => a.ProfessionRaceAllowed.HasFlag((Race)race))
                .ToDictionary(a => a.Id, a => a.OutputProfessions.Select(b => b.OutputProfessionId).ToList());

            var startRecord = context.Set<Profession>().FirstOrDefault(a => a.Id == startProfessionId);
            var endRecord = context.Set<Profession>().FirstOrDefault(a => a.Id == targetProfessionId);

            var finder = new GraphFinder(data, mappingLevels);

            try
            {
                result = finder.FindAllPaths(startRecord.Id, endRecord.Id);
            }
            catch (Exception e)
            {
                result = null;

                //Logowanie błędu
            }

            return result != null && result.Any();
        }

        private void GetStartingAbilities(Profession startingProfession, out List<int> ids, out List<string> names)
        {
            if (startingProfession == null)
            {
                ids = new List<int>();
                names = new List<string>();
            }
            else
            {
                var values = startingProfession.Abilities.SelectMany(a => a.Abilities.Select(b => new { b.AbilityId, b.Ability.Name }));

                ids = values.Select(a => a.AbilityId).ToList();
                names = values.Select(a => a.Name).ToList();
            }
        }

        private void GetStartingSkills(Profession startingProfession, out List<int> ids, out List<string> names)
        {
            if (startingProfession == null)
            {
                ids = new List<int>();
                names = new List<string>();
            }
            else
            {
                var values = startingProfession.Skills.SelectMany(a => a.Skills.Select(b => new { b.SkillId, b.Skill.Name }));

                ids = values.Select(a => a.SkillId).ToList();
                names = values.Select(a => a.Name).ToList();
            }
        }

        private IDictionary<StatisticType, StatisticCompare> GetStartingStatistics(Profession profession) => new Dictionary<StatisticType, StatisticCompare>
                {
                    { StatisticType.CloseCombat, new StatisticCompare(GetStatisticValue(profession, StatisticType.CloseCombat), GetStatisticValue(profession, StatisticType.CloseCombat))},
                    { StatisticType.Agility, new StatisticCompare(GetStatisticValue(profession, StatisticType.Agility), GetStatisticValue(profession, StatisticType.Agility)) },
                    { StatisticType.Attacks, new StatisticCompare(GetStatisticValue(profession, StatisticType.Attacks), GetStatisticValue(profession, StatisticType.Attacks))},
                    { StatisticType.Hitpoints, new StatisticCompare(GetStatisticValue(profession, StatisticType.Hitpoints), GetStatisticValue(profession, StatisticType.Hitpoints))},
                    { StatisticType.Inteligence, new StatisticCompare(GetStatisticValue(profession, StatisticType.Inteligence), GetStatisticValue(profession, StatisticType.Inteligence))},
                    { StatisticType.Magic, new StatisticCompare(GetStatisticValue(profession, StatisticType.Magic), GetStatisticValue(profession, StatisticType.Magic))},
                    { StatisticType.Polish, new StatisticCompare(GetStatisticValue(profession, StatisticType.Polish), GetStatisticValue(profession, StatisticType.Polish))},
                    { StatisticType.Resistance, new StatisticCompare(GetStatisticValue(profession, StatisticType.Resistance), GetStatisticValue(profession, StatisticType.Resistance))},
                    { StatisticType.Shooting, new StatisticCompare(GetStatisticValue(profession, StatisticType.Shooting), GetStatisticValue(profession, StatisticType.Shooting))},
                    { StatisticType.Speed, new StatisticCompare(GetStatisticValue(profession, StatisticType.Speed), GetStatisticValue(profession, StatisticType.Speed))},
                    { StatisticType.Stamina, new StatisticCompare(GetStatisticValue(profession, StatisticType.Stamina), GetStatisticValue(profession, StatisticType.Stamina))},
                    { StatisticType.Willpower, new StatisticCompare(GetStatisticValue(profession, StatisticType.Willpower), GetStatisticValue(profession, StatisticType.Willpower))}
                };

        private byte GetStatisticValue(Profession profession, StatisticType type) => profession?.Statistics?.FirstOrDefault(a => a.Statistic.Type == type)?.Value ?? 0;

        private void UpdateStatistics(IDictionary<StatisticType, StatisticCompare> values, Profession profession)
        {
            var valuesToReplace = new Dictionary<StatisticType, StatisticCompare>();

            foreach (var value in values)
                if (value.Value.NewValue < GetStatisticValue(profession, value.Key))
                    valuesToReplace.Add(value.Key, new StatisticCompare(value.Value.OriginalValue, GetStatisticValue(profession, value.Key)));

            foreach (var value in valuesToReplace)
                values[value.Key] = value.Value;
        }
    }
}