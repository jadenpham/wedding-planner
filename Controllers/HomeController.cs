using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext DbContext;

        public HomeController(MyContext context)
        {
            DbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(RegWLog newUser)
        {
            UserReg submittedUser = newUser.UserReg;
            if(ModelState.IsValid)
            {
                if(DbContext.Users.Any(u => u.Email == submittedUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                };

                PasswordHasher<UserReg> Hasher = new PasswordHasher<UserReg>();
                submittedUser.Password = Hasher.HashPassword(submittedUser, submittedUser.Password);
                DbContext.Add(submittedUser);
                DbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", submittedUser.UserId);
                return RedirectToAction("Dashboard", new {id = submittedUser.UserId});
            }
            else
            {

                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(RegWLog LogForm)
        {
            UserLog loggedUser = LogForm.UserLog;
            if(ModelState.IsValid)
            {
                var userInDb = DbContext.Users.FirstOrDefault(u => u.Email == loggedUser.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("UserLog.Email", "Invalid login");
                    return View("Index");
                }
                var hasher = new PasswordHasher<UserLog>();
                var result = hasher.VerifyHashedPassword(loggedUser, userInDb.Password, loggedUser.Password);
                if (result ==0)
                {
                    ModelState.AddModelError("UserLog.Password", "Invalid Login");
                    return View("Index");
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard", new {id = userInDb.UserId});

            }
            else{
                return View("Index");
            }
        }



        [HttpGet("dashboard/{id}")]
        public IActionResult Dashboard(int id)
        {
            var userid = DbContext.Users.FirstOrDefault(u => u.UserId == id);
            // bool attending = false;
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            if(UserSess == 0 || UserSess == null || UserSess != userid.UserId)
            {
                return View("Index");
            }
            var userInfo = DbContext.Weddings
                            .Include(w => w.Guests)
                            .ToList();
            // foreach(var info in userInfo)
            // {
            //     if(info.UserId == UserSess)
            //     {
            //         attending = true;
            //     }
            // }
            ViewBag.id = UserSess;

            return View("Dashboard", userInfo);
        }

        [HttpGet("logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("new")]
        public IActionResult New() 
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            if(UserSess == 0 || UserSess == null)
            {
                return View("Index");
            }
            return View();
        } 
            

        [HttpPost("newwedding")]
        public IActionResult NewWedding(Wedding weddingForm)
        {
            if(ModelState.IsValid)
            {
                int? creatorid = HttpContext.Session.GetInt32("UserId");
                weddingForm.UserId = (int)creatorid; //creator is a userreg class so it has the userid
                DbContext.Weddings.Add(weddingForm);
                DbContext.SaveChanges();
                return RedirectToAction("Dashboard", new {id = creatorid});
            }
            else{
                return View("New");
            }
        }

        [HttpGet("wedding/{id}")]
        public IActionResult WeddingInfo(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            if(UserSess == 0 || UserSess == null)
            {
                return View("Index");
            }
            Wedding weddingInfo = DbContext.Weddings
                                .Include(w => w.Guests)
                                .ThenInclude(w => w.Guest)
                                .FirstOrDefault(w => w.WeddingId == id);
            ViewBag.id = UserSess;
            return View(weddingInfo);
        }

        [HttpGet("rsvp/{id}")]
        public IActionResult RSVP(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            Response query = DbContext.Responses
                            .Include(r => r.Guest)
                            .FirstOrDefault(r => r.WeddingId == id);
            if(query == null || query.UserId != UserSess)
            {
                Response rsvp = new Response();
                rsvp.WeddingId = id;
                rsvp.UserId = (int)UserSess;
                DbContext.Responses.Add(rsvp);
                DbContext.SaveChanges();
                return RedirectToAction("Dashboard", new {id = UserSess});
            }
            return RedirectToAction("Dashboard", new {id = UserSess});
        }

        [HttpGet("unrsvp/{id}")]
        public IActionResult UnRSVP(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            var query = DbContext.Responses.FirstOrDefault(w => w.UserId == UserSess && w.WeddingId == id);
            DbContext.Responses.Remove(query);
            DbContext.SaveChanges();
            return RedirectToAction("Dashboard", new {id = UserSess});
        }
        

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            Wedding toBeDeleted = DbContext.Weddings.SingleOrDefault(w => w.WeddingId == id);
            DbContext.Weddings.Remove(toBeDeleted);
            DbContext.SaveChanges();
            return RedirectToAction("Dashboard", new {id = UserSess});
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
