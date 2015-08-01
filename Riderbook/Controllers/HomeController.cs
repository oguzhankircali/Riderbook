using Riderbook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Riderbook.Controllers
{
    public class HomeController : RBController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2(string data)
        {
            return View();
        }

    }
}
