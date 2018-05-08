using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using California_State_Polytechnic_University_Pomona.Models;
namespace California_State_Polytechnic_University_Pomona.Controllers
{
    public class UserController : Controller
    {    
        // GET: User
        public ActionResult Index()
        {
             CalPomonaEntities3 db = new CalPomonaEntities3();
           
            
            return View(db.Users.ToList());
        }

        public ActionResult LogTest(int Id,string password)
        {
            CalPomonaEntities3 db = new CalPomonaEntities3();
            
          var y = db.Users.Where(x=>x.User_Id==Id && x.Password==password).ToList();
            int role=0;
            foreach(var x in y)
            {
                role = x.Role.RoleID;
                
                
            }
            if(y.Count==1)
            {
                Session["user"] = Id;
                Session["password"] = password;
                if (role == 0)
                {
                    return RedirectToAction("Index", "Admin");
                }
                
                else if (role == 1)
                {
                    return RedirectToAction("Index", "ProfessorMulti");
                }
                else if (role==2)
                {
                    return RedirectToAction("Index", "StudentMultiPage", new { id = Id });
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return RedirectToAction("Index", "User");
            }
// var user = from p in db.Users where (p.User_Id == id && p.Password == password) select p.Password;

           
          
        }
    }
}