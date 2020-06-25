using AmazingCheeAPI.Data;

namespace AmazingCheeAPI.Controllers
{
    public class UserController : BaseController
    {
        public UserController(ApplicationDbContext db) : base(db) { }
    }
}