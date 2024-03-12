using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RPCGame.DataAPP;
using RPCGame.Models;
using System.Transactions;

namespace RPCGame.Controllers
{
    [ApiController]
    [Route("/api[controller]")]

    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: /Balance 

        [HttpGet]
        public ActionResult<decimal> GetBalance(int userId)
        {
            var user = _context.users.FirstOrDefault(u => u.UserId == userId);

            if (user == null)
            {
                return NotFound("User not found");
            }

            return Ok(user.Balance);
        }

        //GET: /GameList

       //[HttpGet]

       // public ActionResult<List<MatchHistorycs>> GetMatchHistory()
       // {
       //     var match = _context.matchesHistory.Select(m => new MatchHistorycs
       //     {  
              
       //         MatchId = m.MatchId,
       //         bid = m.bid,
       //         IsWaitingPlayer = m.IsWaitingPlayer,
       //         StartTimeMatch = m.StartTimeMatch,
       //         EndTimeMatch = m.EndTimeMatch,
       //         Player1Id = m.Player1Id,
       //         Player2Id = m.Player2Id,

       //     }).ToList();

       //     return Ok(match);
       // }


    }
}