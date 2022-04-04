using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pathak.Models;

namespace pathak.Controllers
{
    public class emp_salary_detailsController : Controller
    {
        PathakEntities db = new PathakEntities();
        // GET: emp_salary_details
        public ActionResult empslarydetail()
        {
            var employee_salary_details = db.employee_salary_details.ToList();
            return View(employee_salary_details);
        }
        public ActionResult esdcreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult esdcreate(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("FormWork", "Pathak");
        }
    }
}