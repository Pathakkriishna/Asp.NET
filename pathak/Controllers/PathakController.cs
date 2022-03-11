using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pathak.Models;

namespace pathak.Controllers
{
    public class PathakController : Controller
    {
        PathakEntities db = new PathakEntities();
        // GET: Pathak
        public ActionResult Index()
        {
            List<employee> all_data = db.employees.ToList();

            return View(all_data);
        }
    }
}