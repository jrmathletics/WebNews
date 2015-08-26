using System.Collections.Generic;
using EPiServer.Core;
using WebNews.Models.Pages;

namespace WebNews.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : BaseEditorialPage
    {
        T CurrentPage { get; }
        XhtmlString FooterText { get; set; }
        List<PageData> MenuPages { get; set; }
        List<PageData> PageCrumbs { get; set; }
    }
}
