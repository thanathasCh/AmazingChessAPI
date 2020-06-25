using AmazingChessAPI.Data;

namespace AmazingChessAPI.Controllers
{
    public class GameController : BaseController
    {
        public GameController(ApplicationDbContext db) : base(db) { }
    }
}