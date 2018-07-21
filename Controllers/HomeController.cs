using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine(user);
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Success");
            }
            else
            {
                Console.WriteLine(ModelState);
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }


        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
