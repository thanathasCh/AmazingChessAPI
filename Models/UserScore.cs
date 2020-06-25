using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmazingChessAPI.Models
{
    public class UserScore
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public int Score { get; set; }
        
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        
        [NotMapped]
        public List<GameHistory> GameHistories { get; set; }
    }
}