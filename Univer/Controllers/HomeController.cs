using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Univer.Models;

namespace Univer.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string result = "Вы не авторизованы";
            if(User.Identity.IsAuthenticated)
            {
                result = "Ваш логин: " + User.Identity.Name;
            }
            return result;
        }
        private UserContext db = new UserContext();

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }
        [HttpGet]
        public ActionResult CreateDis()
        {
            return View();
        }
    }
}