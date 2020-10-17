using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class WorksController : Controller
    {
        PortfolioContext db;
        public WorksController(PortfolioContext context)
        {
            db = context;
        }

        public IActionResult Portfolio()
        {
            return View(db.Works.ToList());
        }
    }
}
