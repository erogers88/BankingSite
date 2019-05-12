using System;
using System.Web;
using System.Web.Mvc;

namespace MVCBlankSolution.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Default()
        {
            ViewBag.Message = "Test ViewBag Message";
            return View();
        }
    }
}