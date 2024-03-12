using System.ComponentModel.DataAnnotations;

namespace RPCGame.Models
{
    public class User
    {
        [Key]
        public int UserId {  get; set; }
        public string UserName { get; set; }
        public decimal Balance { get; set; } 
    }
}
