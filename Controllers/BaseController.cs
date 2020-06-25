using AmazingCheeAPI.Data;

namespace AmazingCheeAPI.Controllers
{
    public class BaseController
    {
        protected readonly ApplicationDbContext _db;

        public BaseController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}