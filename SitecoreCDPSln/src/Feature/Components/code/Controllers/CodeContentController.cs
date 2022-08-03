using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCDP.Feature.Components.Controllers
{
    public class CodeContentController : Controller
    {
        // GET: CodeContent
        public ActionResult Index()
        {
            return View("/Views/CodeContent/Index.cshtml");
        }
    }
}