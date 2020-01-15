using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationForm.Models;


namespace RegistrationForm.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        // Registration action
        [HttpGet]

        public ActionResult Registration()
        {
            return View();
        }//
         /*  
           [HttpPost]
           [ValidateAntiForgeryToken]
         public ActionResult Registration(RegistrationForm.Models.User user)
           {
               bool Status = false;
               String Message = " ";
               if (ModelState.IsValid)
               {
                   // Email is already Exist or Not

               }

               else
               {
                   Message = "InvalidRequest";
               }
               return View(user);
           }
           [NonAction]
           public bool IsEmailExicst(string emailID)
           {
               using (DatabaseEntities dc = new DatabaseEntities())
                   var v = dc.Users.Where(a => a.EmailID == EmailID()).FirstOrDefault);

           }*/
    }
    
}
