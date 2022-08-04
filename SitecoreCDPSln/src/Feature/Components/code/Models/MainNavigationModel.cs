using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreCDP.Feature.Components.Models
{
    public class MainNavigationModel
    {
        public string HomeTitle { get; set; }
        public string HomeNavUrl { get; set; }
        public List<MainLink> MainLinks { get; set; }
    }
}