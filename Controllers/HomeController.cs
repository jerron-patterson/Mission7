using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7.Models;
using Mission7.Models.ViewModels;
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
        public IActionResult Index(string category, int pageNum = 1)
        {
            int pgSz = 10;
            var cxt = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == category || category == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pgSz)
                .Take(pgSz),
                PageInfo = new PageInfo
                {
                    TtlNumBooks = (category == null ? repo.Books.Count() : 
                    repo.Books.Where(x => x.Category == category).Count()),
                    BooksPerPg = pgSz,
                    CurrentPg = pageNum
                }
            };
            return View(cxt);
        }
    }
}
