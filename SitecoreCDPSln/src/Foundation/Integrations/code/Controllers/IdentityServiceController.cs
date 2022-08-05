using SitecoreCDP.Feature.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SitecoreCDP.Foundation.Integrations.Controllers
{
    public class IdentityServiceController : ApiController
    {
        [HttpPost]
        [Route("api/postidentificationdata/")]
        public string PostIdentificationData(VisitorIdentity visitorIdentity)
        {

            return "";
        }
    }
}
