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
        public PrayerService prayerService;

        public HomeController(PrayerContext context,ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
            prayerService = new PrayerService(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetPrayers(ReligionType religion)
        {
            var prayersByReligion = prayerService.GetPrayersByReligion(religion, _context);
            return View(prayersByReligion);
        }

        [HttpPost]
        public IActionResult GetPrayers(string recieverEmail, ReligionType religion)
        {
            EmailSender.Execute(recieverEmail);
            var prayersByReligion = prayerService.GetPrayersByReligion(religion, _context);
            return View(prayersByReligion);
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
