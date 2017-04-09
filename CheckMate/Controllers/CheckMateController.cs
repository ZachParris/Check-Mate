using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckMate.Controllers
{
    public class CheckMateController : Controller
    {
        public ActionResult Detail()
        {
            if( DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/");
            }

            return Content("Hello World!");
    }
}