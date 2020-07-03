using System;
using System.Linq;
using AmazingChessAPI.Data;
using AmazingChessAPI.Interfaces;
using AmazingChessAPI.Models;
using AmazingChessAPI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazingChessAPI.Controllers
{
    public class UserController : BaseController
    {
        public UserController(ApplicationDbContext db,
            IExceptionManager exceptionManager) : base(db, exceptionManager)
        {
        }

        [HttpPost]
        public ActionResult CreateAccount([FromBody] User model)
        {
            try
            {
                _db.Users.Add(model);
                _db.SaveChanges();
                _db.UserScores.Add(new UserScore
                                   {
                                       UserId = model.Id
                                   });
                _db.SaveChanges();

                return new OkObjectResult(true);
            }
            catch (Exception e)
            {
                if (_exceptionManager.IsDuplicateEntityCode(e))
                {
                    return new BadRequestObjectResult(Messages.DuplicateCode);
                }
                else
                {
                    return new OkObjectResult(false);
                }
            }
        }

        [HttpPost]
        public ActionResult Login([FromBody] User model)
        {
            if (model == null)
            {
                return new BadRequestResult();
            }
            
            var isExisted = _db.Users.Any(x => (x.UserName == model.UserName
                                                || x.UserName.ToLower() == model.Email)
                                               && x.Password == model.Password);

            return new OkObjectResult(isExisted);
        }

        [HttpPost]
        public ActionResult CheckDuplicate([FromBody] User model)
        {
            var isExisted = _db.Users.Any(x => x.UserName == model.UserName
                                               || x.Email.ToLower() == model.Email);
            
            return new OkObjectResult(isExisted);
        }
    }
}