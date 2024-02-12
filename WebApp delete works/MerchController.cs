using WebApp.Models;
using WebApp.Pages;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApp
{
    public class MerchController : Controller
    {
        private readonly ILogger<MerchController> _logger;

        public MerchController(ILogger<MerchController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Merch()
        {
            return View();
        }
    }
}
