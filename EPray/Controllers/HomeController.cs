using EPray.EntityFramework;
using EPray.Models;
using EPray.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EPray.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PrayerContext _context;
        private EmailSender _emailSender;
        public PrayerService prayerService;

        public HomeController(PrayerContext context,ILogger<HomeController> logger, EmailSender emailSender)
        {
            _context = context;
            _logger = logger;
            prayerService = new PrayerService(context);
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult GetPrayers(string id)
        {
            var prayersByReligion = prayerService.GetPrayersByReligion(Int32.Parse(id), _context);
            return View(prayersByReligion);
        }

        [HttpPost]
        public async Task<IActionResult> GetPrayers(string recieverEmail, string id)
        {
            await _emailSender.Execute(recieverEmail);
            var prayersByReligion = prayerService.GetPrayersByReligion(Int32.Parse(id), _context);
            return View(prayersByReligion);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Donations()
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
