
using System.ComponentModel.DataAnnotations;

namespace RPCGame.Models
{
    public class GameTransaction
    {
        [Key]
        public int TransactionId{ get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }


    }
}
