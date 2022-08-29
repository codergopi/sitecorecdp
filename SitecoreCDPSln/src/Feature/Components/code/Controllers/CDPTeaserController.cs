using Sitecore.Data.Fields;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using SitecoreCDP.Feature.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCDP.Feature.Components.Controllers
{
    public class CDPTeaserController : Controller
    {
        // GET: CDPTeaser
        public ActionResult Index()
        {
            var renderingItem = RenderingContext.Current.Rendering.Item;
            MultilistField productTags = renderingItem.Fields["type"];
            var productTagsString = productTags.GetItems().Select(x => x.Name).ToList();
            DateField updatedDateTime = renderingItem.Fields["__Updated"];
            TextField description = renderingItem.Fields["description"];

            ProductCard productCard = new ProductCard
            {
                ProdTitle = renderingItem.Fields["__Display Name"].Value,
                ProdUrl = LinkManager.GetItemUrl(renderingItem),
                ProdImage = new HtmlString(FieldRenderer.Render(renderingItem, "image")),
                ProdTags = productTagsString,
                ProdShortDesc = description.Value
            };

            return View(productCard);
        }
    }
}