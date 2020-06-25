using AmazingChessAPI.Data;

namespace AmazingChessAPI.Controllers
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