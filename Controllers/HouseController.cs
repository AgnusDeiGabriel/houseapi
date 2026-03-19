using Microsoft.AspNetCore.Mvc;
using HouseApi.Data;
using HouseApi.Models;

namespace HouseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HouseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HouseController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Houses.ToList());
        }

        [HttpPost]
        public IActionResult Create(House house)
        {
            _context.Houses.Add(house);
            _context.SaveChanges();

            return Ok(house);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var house = _context.Houses.Find(id);
            if (house == null)
            {
                return NotFound();
            }

            _context.Houses.Remove(house);
            _context.SaveChanges();

            return NoContent();
        }
    }
}