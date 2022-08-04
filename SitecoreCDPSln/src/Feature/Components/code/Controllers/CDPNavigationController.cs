using Sitecore.Links;
using SitecoreCDP.Feature.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCDP.Feature.Components.Controllers
{
    public class CDPNavigationController : Controller
    {
        // GET: CDPNavigation
        public ActionResult Index()
        {
            var contextItem = Sitecore.Context.Item;
            var contextDb = Sitecore.Configuration.Factory.GetDatabase(Sitecore.Context.Database.Name);
            var rootItem = contextDb.GetItem(Sitecore.Context.Site.StartPath);

            var listofNavigableItems = rootItem.GetChildren();

            MainNavigationModel navigationModel = new MainNavigationModel
            {
                HomeNavUrl = LinkManager.GetItemUrl(rootItem),
                HomeTitle = rootItem.DisplayName,
                MainLinks = listofNavigableItems
                                    .Select(x => new MainLink
                                    {
                                        NavTitle = x.DisplayName,
                                        NavUrl = LinkManager.GetItemUrl(x),
                                        SubNavItems = GetSubNavItems(x)
                                    }).ToList()
            };

            MainNavigationModel mainNavigationModel = new MainNavigationModel
            {
                HomeTitle = "Sitecore CDP Training",
                HomeNavUrl = "/",
                MainLinks = new List<MainLink>
                {
                    new MainLink { NavTitle = "Test 1", NavUrl = "/test", SubNavItems = new List<SubLink>
                    {
                        new SubLink { SubNavTitle = "Sub Test 1", SubNavUrl = "/test/subtest"},
                        new SubLink { SubNavTitle = "Sub Test 1", SubNavUrl = "/test/subtest"}
                    }
                    },
                    new MainLink { NavTitle = "Test 1", NavUrl = "/test", SubNavItems = new List<SubLink>
                    {
                        new SubLink { SubNavTitle = "Sub Test 1", SubNavUrl = "/test/subtest"},
                        new SubLink { SubNavTitle = "Sub Test 1", SubNavUrl = "/test/subtest"}
                    }
                    },
                    new MainLink { NavTitle = "Test 1", NavUrl = "/test", SubNavItems = new List<SubLink>
                    {
                        new SubLink { SubNavTitle = "Sub Test 1", SubNavUrl = "/test/subtest"},
                        new SubLink { SubNavTitle = "Sub Test 1", SubNavUrl = "/test/subtest"}
                    }
                    }
                }
            };

            return View(navigationModel);
        }

        public List<SubLink> GetSubNavItems(Sitecore.Data.Items.Item mainNavItem)
        {
            if (mainNavItem.HasChildren)
            {
                var subNavItems = mainNavItem.Children;
                List<SubLink> subLinks = subNavItems
                                            .Select(x => new SubLink
                                            {
                                                SubNavTitle = x.DisplayName,
                                                SubNavUrl = LinkManager.GetItemUrl(x),
                                            }).ToList();
                return subLinks;
            }
            else
            {
                return new List<SubLink>();
            }
        }
    }
}