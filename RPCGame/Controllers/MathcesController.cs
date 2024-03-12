using Microsoft.AspNetCore.Mvc;
using RPCGame.DataAPP;
using RPCGame.Models;

namespace RPCGame.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathcesController : Controller
    {
        private readonly ApplicationDbContext _context; 

        public MathcesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: /Matches
        [HttpPost] 

        public async Task <IActionResult> Create( Match match) 
        {  
            if (match == null )
            {
                return BadRequest("There is no a match for you ! ");
            }

            var game= new Match
            {
                Player1ID = match.Player1ID,
                Player2ID = match.Player2ID,
                Start = match.Start, 
                InitialBid = match.InitialBid,


            };
            _context.matches.Add(match);
            await _context.SaveChangesAsync();
            return Ok();

        }
    }
}
