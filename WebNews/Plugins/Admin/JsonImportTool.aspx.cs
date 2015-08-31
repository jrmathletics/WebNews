using EPiServer;
using EPiServer.PlugIn;

namespace WebNews.Plugins.Admin
{
    public partial class JsonImportTool : System.Web.UI.Page
    {
        public string PluginDisplayString { get; set; }
        public string PageId { get; set; }

    }
}