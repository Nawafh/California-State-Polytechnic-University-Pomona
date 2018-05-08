using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using California_State_Polytechnic_University_Pomona.Models;
using California_State_Polytechnic_University_Pomona.MultiModels;

namespace California_State_Polytechnic_University_Pomona.Controllers
{
    public class StudentMultiPageController : Controller
    {
       
        // GET: StudentMultiPage
        public ActionResult Index(int? id)
        {
            CalPomonaEntities3 db = new CalPomonaEntities3();
            StudentMultiView student = new StudentMultiView();
            
            student.Students = db.Students.Where(m=>m.Student_Id==id).ToList();
            student.Courses = db.Courses.ToList();
            student.Enrolls = db.Enrolls.Where(m=>m.FK_Student_ID==id).ToList();
           
            return View(student);

        }
        public ActionResult OfficeHour(int? id)
        {
            CalPomonaEntities3 db = new CalPomonaEntities3();
            StudentMultiView professor = new StudentMultiView();

            professor.Professors = db.Professors.Where(m => m.Professor_Id == id).ToList();
            professor.OfficeHours = db.OfficeHours.Where(m =>id == m.Professor.Professor_Id).ToList();
            professor.Courses = db.Courses.Where(m => id == m.Professor.Professor_Id).ToList();

            return View(professor);

        }

        public ActionResult ContactProfessor(int? prof,int? stud)
        {
            CalPomonaEntities3 db = new CalPomonaEntities3();
            StudentMultiView person = new StudentMultiView();

            person.Professors = db.Professors.Where(m => m.Professor_Id == prof).ToList();
            person.Students = db.Students.Where(m => m.Student_Id == stud).ToList();

            return View(person);

        }
    }
}