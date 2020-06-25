using AmazingCheeAPI.Data;

namespace AmazingCheeAPI.Controllers
{
    public class GameController : BaseController
    {
        public GameController(ApplicationDbContext db) : base(db) { }
    }
}