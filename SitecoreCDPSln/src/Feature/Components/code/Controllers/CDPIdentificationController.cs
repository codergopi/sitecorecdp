using SitecoreCDP.Feature.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCDP.Feature.Components.Controllers
{
    public class CDPIdentificationController : Controller
    {
        [HttpGet]
        public ActionResult GetIdentification()
        {
            VisitorIdentity visitorIdentity = new VisitorIdentity();
            return View(visitorIdentity);
        }
    }
}