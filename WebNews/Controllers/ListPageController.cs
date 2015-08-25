using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Security;
using EPiServer.Web.Mvc;
using WebNews.Models.Pages;
using WebNews.Models.ViewModels;

namespace WebNews.Controllers
{
    public class ListPageController : PageController<ListPage>
    {
        public ActionResult Index(ListPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var model = new ListPageViewModel(currentPage);

            var serviceLocator =
                EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<EPiServer.IContentLoader>();
            var children = serviceLocator.GetChildren<BaseEditorialPage>(currentPage.ContentLink).ToList();
                //.Filter(new FilterAccess(AccessLevel.Read)).ToList();
            //  EPiServer.Filters.FilterForVisitor.Filter(children);

           

            model.ChildPages = children;
            
            return View(model);
        }
    }

    
}