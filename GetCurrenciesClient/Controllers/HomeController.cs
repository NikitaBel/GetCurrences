using GetCurrenciesClient.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static GetCurrencies.API.CurrencyApi;

namespace GetCurrenciesClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = GetCurrencyCodes().Result.Values;
            ViewBag.Currency = new SelectList(list, "CharCode", "Name"); 
            return View();
        }

        
    }
}
