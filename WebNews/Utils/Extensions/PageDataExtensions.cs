using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.Filters;
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

    }
}