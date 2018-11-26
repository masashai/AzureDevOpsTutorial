using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Answer.Web.Models;
using AspNetCore.Answer.Web.Data;
using AspNetCore.Answer.Web.Services;

namespace AspNetCore.Answer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHomeService _homeService;

        public HomeController(ApplicationDbContext context
            , IHomeService homeService)
        {
            _context = context;
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            if (!_context.Blogs.Any())
            {
                _context.Blogs.Add(new Blog { Name = "Hello Blog" });
                _context.SaveChanges();
            }

            var blogs = _context.Blogs.ToList();

            return View(blogs);
        }

        public IActionResult About()
        {
            ViewData["Message"] = _homeService.Greet(DateTime.Now.Hour);

            return View();
        }

        public IActionResult Contact()
        {
            throw new Exception();

            //ViewData["Message"] = "Your contact page.";

            //return View();
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
