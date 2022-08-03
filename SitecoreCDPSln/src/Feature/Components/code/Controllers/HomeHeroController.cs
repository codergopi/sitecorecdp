using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCDP.Feature.Components.Controllers
{
    public class HomeHeroController : Controller
    {
        // GET: HomeHero
        public ActionResult Index()
        {
            return View("/Views/HomeHero/Index.cshtml");
        }
    }
}