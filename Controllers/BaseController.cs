using AmazingChessAPI.Data;
using AmazingChessAPI.Interfaces;

namespace AmazingChessAPI.Controllers
{
    public class BaseController
    {
        protected readonly ApplicationDbContext _db;
        protected readonly IExceptionManager _exceptionManager;
        protected readonly IFirebaseProvider _firebaseProvider;

            public BaseController(ApplicationDbContext db, IExceptionManager exceptionManager = null, IFirebaseProvider firebaseProvider = null)
        {
            _db = db;
            _exceptionManager = exceptionManager;
            _firebaseProvider = firebaseProvider;
        }
    }
}