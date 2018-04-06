using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private readonly PlayerContext _context;

        public PlayerController(PlayerContext context)
        {
            _context = context;

            if (_context.PlayerItems.Count() == 0)
            {
                _context.PlayerItems.Add(new Player { Name = "Mo Salah" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Player> GetAll()
        {
            return _context.PlayerItems.ToList();
        }

        [HttpGet("{id}", Name = "GetPlayer")]
        public IActionResult GetById(int id)
        {
            var item = _context.PlayerItems.FirstOrDefault(p => p.Id == id);
            if (item == null) return NotFound();
            return new ObjectResult(item);
        }
    }
}