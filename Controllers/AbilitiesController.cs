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
    public class AbilitiesController : ControllerBase
    {
        private readonly ProfessionsContext context;

        public AbilitiesController(ProfessionsContext context)
        {
            this.context = context;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbility(int id)
        {
            var ability = await context.Set<Ability>().FindAsync(id);

            if (ability == null)
                return NotFound();

            context.Set<Ability>().Remove(ability);

            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet, AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AbilityDto>>> GetAbilities()
        {
            var entities = await context.Set<Ability>().ToListAsync();

            return Ok(entities.Select(a => new AbilityDto { Id = a.Id, Name = a.Name, Description = a.Description }));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AbilityDto>> GetAbility(int id)
        {
            var ability = await context.Set<Ability>().FindAsync(id);

            if (ability == null)
                return NotFound();

            return new AbilityDto { Id = ability.Id, Name = ability.Name, Description = ability.Description };
        }

        [HttpPost]
        public async Task<ActionResult<Ability>> PostAbility(AbilityDto ability)
        {
            if (ability == null)
                return BadRequest();

            var entity = new Ability { Name = ability.Name };

            context.Set<Ability>().Add(entity);

            await context.SaveChangesAsync();

            return CreatedAtAction("GetAbility", new { id = ability.Id }, ability);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAbility(int id, AbilityDto ability)
        {
            if (id != ability.Id)
                return BadRequest();

            var entity = await context.Set<Ability>().FindAsync(id);

            if (entity == null)
                return NotFound();

            entity.Name = ability.Name;

            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}