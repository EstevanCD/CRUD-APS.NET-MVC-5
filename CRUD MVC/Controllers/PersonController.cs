using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_MVC.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}