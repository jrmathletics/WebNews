using EPiServer;
using EPiServer.PlugIn;

namespace WebNews.Plugins.Admin
{
    [GuiPlugIn(DisplayName = "Json Import Tool",
        Description = "Example",
        Area = PlugInArea.AdminMenu,
        Url = "~/Plugin/Admin/JsonImportTool.aspx")]
    public partial class AdminTest : SimplePage
    {
        public string PluginDisplayString { get; set; }

    }
}