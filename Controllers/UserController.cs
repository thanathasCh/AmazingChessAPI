using AmazingChessAPI.Data;

namespace AmazingChessAPI.Controllers
{
    public class UserController : BaseController
    {
        public UserController(ApplicationDbContext db) : base(db) { }
    }
}