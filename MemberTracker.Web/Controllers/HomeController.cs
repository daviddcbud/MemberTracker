using MemberTracker.Data;
using MemberTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberTracker.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var list = new List<Person>();
            var p = new Person();
            p.LastName = "Freeman";
            p.FirstName = "Dave";
            p.Id = 1;
            list.Add(p);
            p = new Person();
            p.LastName = "Freeman";
            p.FirstName = "Jason";
            p.Id = 2;
            list.Add(p);
            for (int i = 0; i < 1000; i++)
            {
                p = new Person();
                p.LastName = i.ToString() + " testing";
                p.FirstName = "holo";
                p.Id = i;
                list.Add(p);
                
            }
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
