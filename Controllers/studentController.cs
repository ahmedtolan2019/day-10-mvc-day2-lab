using day_10_mvc_day2_lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.UI.WebControls;

namespace day_10_mvc_day2_lab.Controllers
{
    public class studentController : Controller
    {
        public static List<StudentData> students = new List<StudentData>() { new StudentData {id = 1,name="ahmedtolan", age=21,email = "ahmedtolan@gmail.com",password = "ahmed1234" } };
        // GET: student
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult displaystudents(StudentData s)
        {
             
            students.Add(s);
            return View(students);
            }        
        public ViewResult signup()
        {
            return View();
        }

        public ActionResult details(int id=0)
        {
            StudentData s = students.SingleOrDefault(n=>n.id ==id);
            return View(s);
        }
         
        
    }
}