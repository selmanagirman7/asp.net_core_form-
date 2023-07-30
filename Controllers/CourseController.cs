using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Form.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Form.Controllers
{
   
    public class CourseController : Controller
    {
        public ActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);

        }
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
       public IActionResult Apply([FromForm]Candidate model)
        {
            if (Repository.Applications.Any(c=>c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","There is already an applications for you");
            }
            if (ModelState.IsValid)
            {
               Repository.Add(model);
            return View("Feedback", model);// redirect ile direk home gönderir  
            }
            return View();
        }
    }
}