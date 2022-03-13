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
        public ActionResult FormWork()
        {
            List<employee> all_data = db.employees.ToList();

            return View(all_data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(employee employee)
        {
            db.employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("FormWork");
        }

    }
}