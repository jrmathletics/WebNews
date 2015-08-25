using EPiServer;
using EPiServer.Core;
using WebNews.Models.Pages;

namespace WebNews.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : BaseEditorialPage
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            var serviceLocator = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = serviceLocator.Get<HomePage>(ContentReference.StartPage);
            FooterText = startPage.FooterText;
        }
        public T CurrentPage { get; private set; }
        public XhtmlString FooterText { get; set; }
    }

    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T page) where T : BaseEditorialPage
        {
            return new PageViewModel<T>(page);
        }
    }
}
