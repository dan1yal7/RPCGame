using System.ComponentModel.DataAnnotations;

namespace RPCGame.Models
{
    public class Match
    {

        [Key]
        public int MatchId { get; set; }
        public double InitialBid { get; set; }
        public int Player1ID { get; set; }
        public int Player2ID { get; set; } 
        
        public bool IsWaitingPlayer { get; set; }
        public DateTime Start {  get; set; }
            
    }
}
