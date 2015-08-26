using System;
using System.Collections.Generic;
using System.Linq;
using EPiServer;
using EPiServer.Core;
using WebNews.Models.Pages;
using WebNews.Utils.Extensions;
using PageDataExtensions = WebNews.Utils.Extensions.PageDataExtensions;

namespace WebNews.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : BaseEditorialPage

    {
        public T CurrentPage { get; private set; }
        public XhtmlString ViewModelFooterText { get; set; }
        public List<PageData> MenuPages { get; set; }
        public IContentLoader ServiceLocator { get; set; }
        public List<PageData> PageCrumbs { get; set; }

        public PageViewModel(T currentPage)
        {
            ServiceLocator = EPiServer
                             .ServiceLocation
                             .ServiceLocator
                             .Current.GetInstance<IContentLoader>();
            CurrentPage = currentPage;
            MenuPages = GetMenuPages();
            PageCrumbs = currentPage.GetParentPagesOfType<BasePage>()
                                    .FilterForVisitorAndMenu()
                                    .ToList();
            ViewModelFooterText = GetFooterText(currentPage);

        }

        private XhtmlString GetFooterText(T currentPage)
        {
            var currentPageAsFooterPage = currentPage as IFooterPage;
            if (currentPageAsFooterPage?.FooterText != null)
                return currentPageAsFooterPage.FooterText;

            var footerPages = CurrentPage.GetParentPagesOfType<BasePage>()
                .FilterForVisitorAndMenu()
                .Where(x => x is IFooterPage)
                .Cast<IFooterPage>();

            var parentFooterPage = footerPages.FirstOrDefault(page => page.FooterText != null);

            return (parentFooterPage != null)
                ? parentFooterPage.FooterText
                : new XhtmlString("");
        }

        public List<PageData> GetMenuPages()
        {
            var children = ServiceLocator.GetChildren<PageData>(ContentReference.StartPage).ToList();
            return children.FilterForVisitorAndMenu().ToList();
        }


    }

    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T page) where T : BaseEditorialPage
        {
            return new PageViewModel<T>(page);
        }
    }
}
