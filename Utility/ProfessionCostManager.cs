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
        private readonly ProfessionsContext context;

        internal ProfessionCostManager(ProfessionsContext context)
        {
            this.context = context;
        }

        private bool FindProfessionPath(int startProfessionId, int targetProfessionId, byte race, byte mappingLevels, out IList<Queue<int>> result)
        {
            var data = context.Set<Profession>().Include(a => a.OutputProfessions).Where(a => a.ProfessionRaceAllowed.HasFlag((ProfessionRaceAllowed)race))
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

        private IDictionary<string, StatisticCompare> GetStartingStatistics(Profession profession) => new Dictionary<string, StatisticCompare>
                {
                    { nameof(Profession.CloseCombat), new StatisticCompare(profession?.CloseCombat ?? 0, profession?.CloseCombat ?? 0)},
                    { nameof(Profession.Agility), new StatisticCompare(profession?.Agility ?? 0, profession?.Agility ?? 0) },
                    { nameof(Profession.Attacks), new StatisticCompare(profession?.Attacks ?? 0, profession?.Attacks ?? 0)},
                    { nameof(Profession.Hitpoints), new StatisticCompare(profession?.Hitpoints ?? 0, profession?.Hitpoints ?? 0)},
                    { nameof(Profession.Inteligence), new StatisticCompare(profession?.Inteligence ?? 0, profession?.Inteligence ?? 0)},
                    { nameof(Profession.Magic), new StatisticCompare(profession?.Magic ?? 0, profession?.Magic ?? 0)},
                    { nameof(Profession.Polish), new StatisticCompare(profession?.Polish ?? 0, profession?.Polish ?? 0)},
                    { nameof(Profession.Resistance), new StatisticCompare(profession?.Resistance ?? 0, profession?.Resistance ?? 0)},
                    { nameof(Profession.Shooting), new StatisticCompare(profession?.Shooting ?? 0, profession?.Shooting ?? 0)},
                    { nameof(Profession.Speed), new StatisticCompare(profession?.Speed ?? 0, profession?.Speed ?? 0)},
                    { nameof(Profession.Stamina), new StatisticCompare(profession?.Stamina ?? 0, profession?.Stamina ?? 0)},
                    { nameof(Profession.Willpower), new StatisticCompare(profession?.Willpower ?? 0, profession?.Willpower ?? 0)}
                };

        private void UpdateStatistics(IDictionary<string, StatisticCompare> values, Profession profession)
        {
            if (values.TryGetValue(nameof(Profession.CloseCombat), out StatisticCompare closeCombat) && closeCombat.NewValue < profession.CloseCombat)
                values[nameof(Profession.CloseCombat)] = new StatisticCompare { OriginalValue = closeCombat.OriginalValue, NewValue = profession.CloseCombat };
            if (values.TryGetValue(nameof(Profession.Agility), out StatisticCompare agility) && agility.NewValue < profession.Agility)
                values[nameof(Profession.Agility)] = new StatisticCompare { OriginalValue = agility.OriginalValue, NewValue = profession.Agility };
            if (values.TryGetValue(nameof(Profession.Attacks), out StatisticCompare attacks) && attacks.NewValue < profession.Attacks)
                values[nameof(Profession.Attacks)] = new StatisticCompare { OriginalValue = attacks.OriginalValue, NewValue = profession.Attacks };
            if (values.TryGetValue(nameof(Profession.Hitpoints), out StatisticCompare hitpoints) && hitpoints.NewValue < profession.Hitpoints)
                values[nameof(Profession.Hitpoints)] = new StatisticCompare { OriginalValue = hitpoints.OriginalValue, NewValue = profession.Hitpoints };
            if (values.TryGetValue(nameof(Profession.Inteligence), out StatisticCompare inteligence) && inteligence.NewValue < profession.Inteligence)
                values[nameof(Profession.Inteligence)] = new StatisticCompare { OriginalValue = inteligence.OriginalValue, NewValue = profession.Inteligence };
            if (values.TryGetValue(nameof(Profession.Magic), out StatisticCompare magic) && magic.NewValue < profession.Magic)
                values[nameof(Profession.Magic)] = new StatisticCompare { OriginalValue = magic.OriginalValue, NewValue = profession.Magic };
            if (values.TryGetValue(nameof(Profession.Polish), out StatisticCompare polish) && polish.NewValue < profession.Polish)
                values[nameof(Profession.Polish)] = new StatisticCompare { OriginalValue = polish.OriginalValue, NewValue = profession.Polish };
            if (values.TryGetValue(nameof(Profession.Resistance), out StatisticCompare resistance) && resistance.NewValue < profession.Resistance)
                values[nameof(Profession.Resistance)] = new StatisticCompare { OriginalValue = resistance.OriginalValue, NewValue = profession.Resistance };
            if (values.TryGetValue(nameof(Profession.Shooting), out StatisticCompare shooting) && shooting.NewValue < profession.Shooting)
                values[nameof(Profession.Shooting)] = new StatisticCompare { OriginalValue = shooting.OriginalValue, NewValue = profession.Shooting };
            if (values.TryGetValue(nameof(Profession.Speed), out StatisticCompare speed) && speed.NewValue < profession.Speed)
                values[nameof(Profession.Speed)] = new StatisticCompare { OriginalValue = speed.OriginalValue, NewValue = profession.Speed };
            if (values.TryGetValue(nameof(Profession.Stamina), out StatisticCompare stamina) && stamina.NewValue < profession.Stamina)
                values[nameof(Profession.Stamina)] = new StatisticCompare { OriginalValue = stamina.OriginalValue, NewValue = profession.Stamina };
            if (values.TryGetValue(nameof(Profession.Willpower), out StatisticCompare willpower) && willpower.NewValue < profession.Willpower)
                values[nameof(Profession.Willpower)] = new StatisticCompare { OriginalValue = willpower.OriginalValue, NewValue = profession.Willpower };
        }

        public async Task<ProfessionPathWrapperDto> GetProfessionsPaths(int startProfessionId, int targetProfessionId, byte mappingLevels,
            bool includeStartingProfession, bool includeEndingProfession, byte race)
        {
            var result = new ProfessionPathWrapperDto();

            if (!FindProfessionPath(startProfessionId, targetProfessionId, race, mappingLevels, out IList<Queue<int>> paths))
                return result;

            var selectedIds = paths.SelectMany(a => a).Distinct().ToList();

            var entities = context.Set<Profession>().Include(a => a.Abilities).ThenInclude(b => b.Abilities).ThenInclude(c => c.Ability)
                .Include(a => a.Skills).ThenInclude(b => b.Skills).ThenInclude(c => c.Skill)
                .Include(a => a.Equipment).ThenInclude(b => b.Items).ThenInclude(c => c.Item)
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
                Statistics = ConvertStatisticsToInt(initialStatistics)
            };

            var records = new BlockingCollection<ProfessionPathDto>();

            CalculateProfessionResults(records, values, initialAbilitiesIds, initialSkillsIds, initialAbilitiesNames, initialSkillsNames,
                    initialStatistics, includeEndingProfession, targetProfessionId, startProfessionId);

            result.Paths = records.OrderBy(a => a.Summary.MinimalExperienceCost).ToList();

            return result;
        }

        /*
        private IEnumerable<IEnumerable<IEnumerable<Profession>>> DivideList(List<IEnumerable<Profession>> values, int elementsPerList)
        {
            var result = new List<IEnumerable<IEnumerable<Profession>>>();

            for (int i = 0; i < values.Count; i += elementsPerList)
                result.Add(values.GetRange(i, Math.Min(elementsPerList, values.Count - i)));

            return result;
        }
        */

        private void CalculateProfessionResults(BlockingCollection<ProfessionPathDto> results, IEnumerable<IEnumerable<Profession>> values,
            List<int> initialAbilitiesIds, List<int> initialSkillsIds, List<string> initialAbilitiesNames, List<string> initialSkillsNames,
            IDictionary<string, StatisticCompare> initialStatistics, bool includeEndingProfession, int targetProfessionId, int startProfessionId)
        {
            var result = new List<ProfessionPathDto>();

            foreach (var value in values)
                result.Add(CalculateProfessionResult(value, initialAbilitiesIds, initialSkillsIds, initialAbilitiesNames, initialSkillsNames,
                    initialStatistics, includeEndingProfession, targetProfessionId, startProfessionId));

            foreach (var path in result)
                results.Add(path);
        }

        private ProfessionPathDto CalculateProfessionResult(IEnumerable<Profession> value, List<int> initialAbilitiesIds, List<int> initialSkillsIds, List<string> initialAbilitiesNames,
            List<string> initialSkillsNames, IDictionary<string, StatisticCompare> initialStatistics, bool includeEndingProfession, int targetProfessionId, int startProfessionId)
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
                    if (pair.Key.Equals(nameof(Profession.Attacks)) || pair.Key.Equals(nameof(Profession.Hitpoints)) ||
                        pair.Key.Equals(nameof(Profession.Magic)) || pair.Key.Equals(nameof(Profession.Speed)))
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

        private Dictionary<string, byte> ConvertStatisticsToInt(IDictionary<string, StatisticCompare> initialStatistics)
            => initialStatistics.ToDictionary(a => a.Key, a => a.Value.NewValue > a.Value.OriginalValue ? a.Value.NewValue : a.Value.NewValue);

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
    }
}