using AmazingChessAPI.Data;
using AmazingChessAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazingChessAPI.Controllers
{
    public class GameController : BaseController
    {
        public GameController(ApplicationDbContext db) : base(db) { }

        [HttpPost]
        public ActionResult SaveGame(string gameRoomId)
        {
            // get information from firebase
            return new OkObjectResult(true);
        }
    }
}