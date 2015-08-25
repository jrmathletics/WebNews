using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNews.Models.Pages;

namespace WebNews.Models.ViewModels
{
    public class ListPageViewModel : PageViewModel<ListPage>
    {
        public ListPageViewModel(ListPage currentPage) : base(currentPage)
        {

        }

        public List<BaseEditorialPage> ChildPages { get; set; }
    }
}