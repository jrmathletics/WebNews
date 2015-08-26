using System.Web.Mvc;
using EPiServer.Web.Mvc;
using WebNews.Models.Pages;
using WebNews.Models.ViewModels;

namespace WebNews.Controllers
{
    public class PortalPageController : PageController<PortalPage>
    {
        public ActionResult Index(PortalPage currentPage)
        {

            var editingHints = ViewData.GetEditHints<PageViewModel<PortalPage>, PortalPage>();
            editingHints.AddConnection(viewModel => viewModel.ViewModelFooterText, page => page.FooterText);
            var model = PageViewModel.Create(currentPage);
            return View(model);
        }
    }
}