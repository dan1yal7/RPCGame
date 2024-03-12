using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using RPCGame.DataAPP;
using RPCGame.Models;

namespace RPCGame.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {   
        private ApplicationDbContext _context; 

        public TransactionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostTransaction( GameTransaction transaction)
        {  
            if (transaction == null)
            {
                return BadRequest("Invalid Transaction");
            }

            int senderId = transaction.SenderId;
            int receiverId = transaction.ReceiverId;
            decimal amount = transaction.Amount;

            var sender = _context.users.FirstOrDefault(u => u.UserId == senderId); 
             
            if(sender == null)
            {
                return NotFound("User doesn't exist");
            }

            if(sender.Balance < amount)
            {
                return BadRequest("insufficient funds on the balance sheet");
            }

            var trans = new GameTransaction
            {
                SenderId = senderId,
                ReceiverId = receiverId,
                Amount = amount,
                Timestamp = transaction.Timestamp,
            };  


            _context.gameTransactions.Add(transaction); 
            await _context.SaveChangesAsync(); 

            sender.Balance -= amount;
             
            var receiver = _context.users.FirstOrDefault( u=> u.UserId == receiverId); 
            if (receiver == null)
            {
                receiver.Balance += amount;
            }

            await _context.SaveChangesAsync();
            return Ok(transaction); 

        } 

    }
}
