using EPray.EntityFramework;
using EPray.Models;
using EPray.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPray.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        public UserService UserService;
        public UserController(PrayerContext context,ILogger<UserController> logger )
        {
            _context = context;
            _logger = logger;
            UserService = new UserService(context);
        }
        private readonly PrayerContext _context;
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegistrationModel registerDetails)
        {
            
            if (ModelState.IsValid)
            {
                var user = new UserModel();
                user.Email = registerDetails.Email;
                user.Password = UserService.HashPassword(registerDetails.Password);
                _context.Users.Add(user);
                _context.SaveChanges();
                ViewBag.Message = "User Details Saved";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Register");
            }
            
        }
        public ActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signin(RegistrationModel model)
        {
            var user = UserService.GetUserIfValid(model);
            if (ModelState.IsValid && user != null)
            {

                ViewBag.Message = $"Welcome {user.Email}";
                HttpContext.Response.Cookies.Append("userId",user.Id.ToString() , new CookieOptions { Expires = DateTime.Now.AddHours(3) });
                HttpContext.Response.Cookies.Append("userName", user.Email, new CookieOptions { Expires = DateTime.Now.AddHours(3) });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Wrong credentials";
                return View("Signin");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("userId");
            HttpContext.Response.Cookies.Delete("userName");
            //FormsAuthentication.SignOut();
            //Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("Index", "Home");
        }
    }
}
