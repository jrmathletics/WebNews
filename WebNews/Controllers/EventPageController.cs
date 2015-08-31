using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using WebNews.Models.Pages;
using WebNews.Models.ViewModels;

namespace WebNews.Controllers
{
    public class EventPageController : PageController<EventPage>
    {
        public ActionResult Index(EventPage currentPage)
        {
            var model = new EventPageViewModel(currentPage);
            var editingHints = ViewData.GetEditHints<PageViewModel<EventPage>, EventPage>();
            editingHints.AddFullRefreshFor(p => p.EventPerson);

            return View(model);
        }
    }
}