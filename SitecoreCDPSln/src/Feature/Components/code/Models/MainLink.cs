using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreCDP.Feature.Components.Models
{
    public class MainLink
    {
        public string NavTitle { get; set; }

        public string NavUrl { get; set; }

        public bool IsCurrentPage { get; set; }

        public List<SubLink> SubNavItems { get; set; }
    }
}