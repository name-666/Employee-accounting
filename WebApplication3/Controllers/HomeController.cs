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
        MPOContext db = new MPOContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
       
        public IActionResult Table()
        {
            MPOContext db = new MPOContext();
            return View(Tuple.Create(db.Departments.ToList(),db.Users.ToList()));
        }

        [HttpPost]
        public IActionResult Index(ModelW mod)
        {
            var d = db.Departments.Where(t=> t.Name == mod.DepartmentName).FirstOrDefault();
           
            if (db.Departments.Where(t => t.Name == mod.DepartmentName).FirstOrDefault() == null)
            {
                Department dep = new()
                {
                    CompanyId = 1,
                    Name = mod.DepartmentName,
                };
                db.Add(dep);
                db.SaveChanges();

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
                    db.Add(us);
                }
                db.SaveChanges();
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
                    db.Add(us);
                }
                db.SaveChanges();
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
