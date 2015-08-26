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
            FooterText = GetFooterText(currentPage);
        }
        public XhtmlString GetFooterText(BasePage currentPage)
        {

            var closestPortalParent = currentPage.GetParentPagesOfType<PortalPage>().SingleOrDefault() as PortalPage;
            var startPage = ServiceLocator.Get<HomePage>(ContentReference.StartPage);
            if (currentPage is PortalPage)
            {
                var currentPortalPage = currentPage as PortalPage;
                if (closestPortalParent == null && currentPortalPage.CustomFooterText == null) { return startPage.FooterText; }
                if (currentPortalPage.CustomFooterText == null && closestPortalParent.CustomFooterText == null) { return startPage.FooterText; }
                if (currentPortalPage.CustomFooterText == null) { return closestPortalParent.CustomFooterText; }
                if (currentPortalPage.CustomFooterText != null) { return currentPortalPage.CustomFooterText; }
                return startPage.FooterText;

            }
            if (closestPortalParent == null) { return startPage.FooterText; }
            XhtmlString closestPortalFooter = closestPortalParent.CustomFooterText;
            if (closestPortalFooter == null) { return startPage.FooterText; }
            return closestPortalFooter;

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
