using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using WebNews.Models.Pages;

namespace WebNews.Utils.Extensions
{
    public static class PageDataExtensions
    {

        public static IEnumerable<PageData> FilterForVisitorAndMenu(this IEnumerable<PageData> pageList)
        {
            if (pageList == null)
                return new List<PageData>();

            var filterdPages =
                pageList.Select(page => page)
                    .Where(page => page.VisibleInMenu)
                    .Where(page => !(page is FolderPage));

            filterdPages = FilterForVisitor.Filter(filterdPages)
                .Select(page => page)
                .Cast<PageData>();

            return filterdPages;
        }

        public enum ParentSortOrder
        {
            TopDown = 0,
            BottomUp = 1
        }

        public static List<PageData> GetParentPagesOfType<T>(this PageData currentPage,
            ParentSortOrder sortOrder = ParentSortOrder.TopDown) where T : PageData
        {
            var serviceLocator = ServiceLocator.Current.GetInstance<IContentLoader>();

            var parents = serviceLocator.GetAncestors(currentPage.ContentLink)
                .Cast<PageData>()
                .Where(x => x is T)
                .ToList();

            if (sortOrder == ParentSortOrder.TopDown)
                parents.Reverse();

            return parents;
        }

    }
}