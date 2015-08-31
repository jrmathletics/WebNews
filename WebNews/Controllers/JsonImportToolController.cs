using System.Web.Mvc;
using EPiServer.PlugIn;
using EPiServer.Web.Mvc;
using WebNews.Plugins.Admin;

namespace WebNews.Controllers
{
    [GuiPlugIn(DisplayName = "Json Import Tool",
        Description = "Example",
        Area = PlugInArea.AdminMenu,
        Url = "~/Plugins/Admin/JsonImportTool.aspx")]
    public class JsonImportToolController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }
    }
}