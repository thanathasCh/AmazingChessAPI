using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmazingCheeAPI.Models
{
    public class GameHistory
    {
        public long Id { get; set; }
        public long Player1Id { get; set; }
        public long Player2Id { get; set; }
        public decimal Winner { get; set; } // 0 = Player 1, 1 = Player 2
        public DateTime CreatedAt { get; set; }
        public DateTime EndedAt { get; set; }
        
        [ForeignKey("Player1Id")]
        public virtual User Player1 { get; set; }
        
        [ForeignKey("Player2Id")]
        public virtual User Player2 { get; set; }
    }
}