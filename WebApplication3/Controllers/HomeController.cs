using DB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private MPOContext _db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,MPOContext context)
        {
            _logger = logger;
            _db = context;
        }
      [Route("Index")]
      [HttpGet]
        public IActionResult Index()
        {

          return View();
        }
        [Route("Table")]
        [HttpGet]
        public IActionResult Table()
        {

            return View(Tuple.Create(_db.Departments.ToList(), _db.Users.ToList()));
        }
       [Route("Index")]
        [HttpPost]
        public IActionResult Index(ModelW mod)
        {
            var d = _db.Departments.FirstOrDefault(t => t.Name == mod.DepartmentName);

            if (_db.Departments.Where(t => t.Name == mod.DepartmentName).FirstOrDefault() == null)
            {
                Department dep = new()
                {
                    CompanyId = 1,
                    Name = mod.DepartmentName,
                };
                _db.Add(dep);
                _db.SaveChanges();
                for (int i = 0; i < mod.Count(); i++)
                {
                    User us = new()
                    {
                        Name = mod.Name[i],
                        Surname = mod.Surname[i],
                        Patronymic = mod.Patronymic[i],
                        WorkingMode = mod.WorkingMode[i],
                        Position = mod.Position[i],
                        DepartmentId = Convert.ToInt32(dep.Id),
                    };
                    _db.Add(us);
                }
                _db.SaveChanges();
            }
            else
            {
                for (int i = 0; i < mod.Count(); i++)
                {
                    User us = new()
                    {
                        Name = mod.Name[i],
                        Surname = mod.Surname[i],
                        Patronymic = mod.Patronymic[i],
                        WorkingMode = mod.WorkingMode[i],
                        Position = mod.Position[i],
                        DepartmentId = Convert.ToInt32(d.Id),
                    };
                    _db.Add(us);
                }
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
