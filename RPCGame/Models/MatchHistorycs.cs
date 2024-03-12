using System.ComponentModel.DataAnnotations;

namespace RPCGame.Models
{
    public class MatchHistorycs
    {

        [Key]
        public int MatchId {  get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set;}  
        public bool IsWaitingPlayer { get; set; }
        public int WinnerId { get; set; }
        public double bid {  get; set; } 
        public DateTime BidTime {  get; set; } 
        public DateTime StartTimeMatch { get; set; }
        public DateTime EndTimeMatch { get; set;}
    }
}
