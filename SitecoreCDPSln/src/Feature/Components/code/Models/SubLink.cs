using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreCDP.Feature.Components.Models
{
    public class SubLink
    {
        public string SubNavTitle { get; set; }

        public string SubNavUrl { get; set; }

        public bool IsCurrentPage { get; set; }
    }
}