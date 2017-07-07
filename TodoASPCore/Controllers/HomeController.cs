using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoASPCore.Models;

namespace TodoASPCore.Controllers
{
    public class HomeController : Controller
    {
        TaskContext db;
        public HomeController (TaskContext context)
        {
            db = context;

        }
        public IActionResult Index()
        {

            return Json (db.Tasks.ToList());
        }

        
    }
}
