using System;

namespace AmazingChessAPI.Models.ViewModels
{
    public class LeaderBoardViewModel
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public int Score { get; set; }
        public Boolean IsUser { get; set; }
    }
}