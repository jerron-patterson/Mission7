using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Controllers
{
    public class HomeController : Controller
    {
        /*        private readonly ILogger<HomeController> _logger;

                public HomeController(ILogger<HomeController> logger)
                {
                    _logger = logger;
                }*/


        private IBookStoreRepository repo;
        public HomeController (IBookStoreRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index(int pageNum = 1)
        {
            int pgSz = 10;

            var context = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pgSz)
                .Take(pgSz);
            return View(context);
        }
    }
}
