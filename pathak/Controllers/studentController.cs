using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pathak.Models;

namespace pathak.Controllers
{
    public class studentController : Controller
    {
        PathakEntities db = new PathakEntities();

        // GET: student
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Create()
        {
            List<student> all_data = db.students.ToList();

            return View();
        }
        public ActionResult SaveData(student student)
        {
            db.students.Add(student);
            db.SaveChanges();
            return RedirectToAction("FormWork");
        }
        public ActionResult Edit(int id)
        {
            student data = db.students.Find(id);//find data using primary key
            //employee data = db.employee.FirstorDefault(x =)
            return View(data);
        }
        public ActionResult UpdateData(student student)
        {
            student update = db.students.Find(student.id);
            update.sname = student.sname;
            update.saddress = student.saddress;
            update.scontact = student.scontact;
       
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("FormWork");

        }

    }
}
