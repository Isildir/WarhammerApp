using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarhammerProfessionApp.Dtos;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models;

namespace WarhammerProfessionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class SkillsController : ControllerBase
    {
        private readonly ProfessionsContext context;

        public SkillsController(ProfessionsContext context)
        {
            this.context = context;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            var ability = await context.Set<Skill>().FindAsync(id);

            if (ability == null)
                return NotFound();

            context.Set<Skill>().Remove(ability);

            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SkillDto>> GetSkill(int id)
        {
            var item = await context.Set<Skill>().FindAsync(id);

            if (item == null)
                return NotFound();

            return new SkillDto { Id = item.Id, Name = item.Name, Description = item.Description, SkillLevel = item.SkillLevel.ToString(), Trait = item.Trait.ToString() };
        }

        [HttpGet, AllowAnonymous]
        public async Task<ActionResult<IEnumerable<SkillDto>>> GetSkills()
        {
            var entities = await context.Set<Skill>().ToListAsync();

            return Ok(entities.Select(a => new SkillDto { Id = a.Id, Name = a.Name, Description = a.Description, SkillLevel = a.SkillLevel.ToString(), Trait = a.Trait.ToString() }));
        }

        [HttpPost]
        public async Task<ActionResult<SkillDto>> PostSkill(SkillDto skill)
        {
            if (skill == null)
                return BadRequest();

            var entity = new Skill { Name = skill.Name };

            context.Set<Skill>().Add(entity);

            await context.SaveChangesAsync();

            return CreatedAtAction("GetAbility", new { id = skill.Id }, skill);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkill(int id, SkillDto skill)
        {
            if (id != skill.Id)
                return BadRequest();

            var entity = await context.Set<Skill>().FindAsync(id);

            if (entity == null)
                return NotFound();

            entity.Name = skill.Name;

            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}