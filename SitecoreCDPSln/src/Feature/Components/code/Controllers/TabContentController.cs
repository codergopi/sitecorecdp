using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCDP.Feature.Components.Controllers
{
    public class TabContentController : Controller
    {
        // GET: TabContent
        public ActionResult Index()
        {
            return View("/Views/TabContent/Index.cshtml");
        }
    }
}