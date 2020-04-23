using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models;

namespace WarhammerProfessionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class ImagesController : ControllerBase
    {
        private readonly ProfessionsContext context;

        public ImagesController(ProfessionsContext context)
        {
            this.context = context;
        }

        // DELETE: api/Images/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Image>> DeleteImage(int id)
        {
            var image = await context.Images.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }

            context.Images.Remove(image);
            await context.SaveChangesAsync();

            return image;
        }

        // GET: api/Images/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Image>> GetImage(int id)
        {
            var image = await context.Images.FindAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return image;
        }

        // GET: api/Images
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Image>>> GetImages()
        {
            return await context.Images.ToListAsync();
        }

        // POST: api/Images To protect from overposting attacks, please enable the specific
        // properties you want to bind to, for more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Image>> PostImage(Image image)
        {
            context.Images.Add(image);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetImage", new { id = image.Id }, image);
        }

        // PUT: api/Images/5 To protect from overposting attacks, please enable the specific
        // properties you want to bind to, for more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImage(int id, Image image)
        {
            if (id != image.Id)
            {
                return BadRequest();
            }

            context.Entry(image).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool ImageExists(int id)
        {
            return context.Images.Any(e => e.Id == id);
        }
    }
}