using AmazingChessAPI.Data;
using AmazingChessAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AmazingChessAPI.Controllers
{
    public class TestController : BaseController
    {
        public TestController(ApplicationDbContext db,
                              IFirebaseProvider firebaseProvider) : base(db, 
                                                                         firebaseProvider: firebaseProvider) { }

        public IActionResult Index()
        {
            return new OkObjectResult(true);
        }
    }
}