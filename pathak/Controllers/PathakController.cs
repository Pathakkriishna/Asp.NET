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
        public ActionResult Edit(int id)
        {
            employee data = db.employees.Find(id);//find data using primary key
            //employee data = db.employee.FirstorDefault(x =)
            return View(data);
        }
        public ActionResult UpdateData(employee employee)
        {
            employee update = db.employees.Find(employee.id);
            update.name = employee.name;
            update.address= employee.address;
            db.Entry(update).State= System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("FormWork");

        }

    }
}