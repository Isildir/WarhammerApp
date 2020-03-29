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
    public class ItemsController : ControllerBase
    {
        public ItemsController(ProfessionsContext context)
        {
            this.context = context;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var ability = await context.Set<Ability>().FindAsync(id);

            if (ability == null)
                return NotFound();

            context.Set<Ability>().Remove(ability);

            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDto>> GetItem(int id)
        {
            var item = await context.Set<Item>().FindAsync(id);

            if (item == null)
                return NotFound();

            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                ItemType = item.ItemType.ToString(),
                MoneyType = item.MoneyType.ToString(),
                Price = item.Price,
                Rarity = item.Rarity.ToString(),
                Weigth = item.Weigth
            };
        }

        [HttpGet, AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetItems()
        {
            var entities = await context.Set<Item>().ToListAsync();

            return Ok(entities.Select(a => new ItemDto
            {
                Id = a.Id,
                Name = a.Name,
                Description = a.Description,
                ItemType = a.ItemType.ToString(),
                MoneyType = a.MoneyType.ToString(),
                Price = a.Price,
                Rarity = a.Rarity.ToString(),
                Weigth = a.Weigth
            }));
        }

        [HttpPost]
        public async Task<ActionResult<Item>> PostItem(ItemDto item)
        {
            if (item == null)
                return BadRequest();

            var entity = new Ability { Name = item.Name };

            context.Set<Ability>().Add(entity);

            await context.SaveChangesAsync();

            return CreatedAtAction("GetAbility", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, ItemDto item)
        {
            if (id != item.Id)
                return BadRequest();

            var entity = await context.Set<Ability>().FindAsync(id);

            if (entity == null)
                return NotFound();

            entity.Name = item.Name;

            await context.SaveChangesAsync();

            return NoContent();
        }

        private readonly ProfessionsContext context;
    }
}