using System;
using System.Collections.Generic;
using System.Linq;
using EPiServer;
using EPiServer.Core;
using WebNews.Models.Pages;
using WebNews.Utils.Extensions;

namespace WebNews.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : BaseEditorialPage

    {
        public T CurrentPage { get; private set; }
        public XhtmlString FooterText { get; set; }
        public List<PageData> MenuPages { get; set; }
        public IContentLoader ServiceLocator { get; set; }
        public List<PageData> PageCrumbs { get; set; }

        public PageViewModel(T currentPage)
        {
            ServiceLocator = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentLoader>();
            CurrentPage = currentPage;
            MenuPages = GetMenuPages();
            PageCrumbs = currentPage.GetParentPagesOfType<BasePage>()
                                    .FilterForVisitorAndMenu()
                                    .ToList();
            FooterText = GetFooterText();
        }
        public XhtmlString GetFooterText()
        {
            var startPage = ServiceLocator.Get<HomePage>(ContentReference.StartPage);
            return startPage.FooterText;
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
