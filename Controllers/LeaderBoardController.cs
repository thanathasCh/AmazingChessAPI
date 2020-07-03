using System.Linq;
using AmazingChessAPI.Data;
using AmazingChessAPI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazingChessAPI.Controllers
{
    public class LeaderBoardController : BaseController
    {
        public LeaderBoardController(ApplicationDbContext db) : base(db) { }

        [HttpGet]
        public ActionResult FetchLeaderBoard(long userId)
        {
            var users = _db.UserScores
                           .Include(x => x.User)
                           .OrderByDescending(x => x.Score)
                           .Take(50)
                           .Select(x => new LeaderBoardViewModel()
                                        {
                                            UserId = x.UserId,
                                            UserName = x.User.UserName,
                                            FullName = x.User.FullName,
                                            Score = x.Score,
                                            IsUser = x.UserId == userId
                                        })
                           .ToList();

            if (users.All(x => x.UserId != userId))
            {
                var userScore = _db.UserScores
                                   .Include(x => x.User)
                                   .Select(x => new LeaderBoardViewModel()
                                                {
                                                    UserId = x.UserId,
                                                    UserName = x.User.UserName,
                                                    FullName = x.User.FullName,
                                                    Score = x.Score,
                                                    IsUser = true
                                                })
                                   .SingleOrDefault(x => x.UserId == userId);
                
                users.Add(userScore);
            }

            return new OkObjectResult(users);
        }
    }
}