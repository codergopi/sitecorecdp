using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreCDP.Feature.Components.Models
{
    public class ProductCard
    {
        public string ProdTitle { get; set; }
        public string ProdUrl { get; set; }
        public HtmlString ProdImage { get; set; }
        public List<string> ProdTags { get; set; }
        public string LastUpdated { get; set; }
    }
}