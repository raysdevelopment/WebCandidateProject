using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCandidateProject.Data;
using WebCandidateProject.Models;

namespace WebCandidateProject.Controllers
{
    public class JavaScriptController : Controller
    {
        // GET: JavaScript
        public ActionResult Task1()
        {
            return View(new User());
        }

        // GET: JavaScript
        public ActionResult Task2()
        {
            return View();
        }

        // GET: JavaScript
        public ActionResult Task3()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult CreateNewUser(User user)
        {
            // TODO: Validate model
            
            return View("Task1", user);
        }
    }
}
