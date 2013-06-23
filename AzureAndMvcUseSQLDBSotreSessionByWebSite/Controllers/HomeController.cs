using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureAndMvcUseSQLDBSotreSessionByWebSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            Session["Test"] = "Have Value";
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

    }
}
