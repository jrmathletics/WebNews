using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Core;

namespace WebNews.Models.Pages
{
    interface IFooterPage
    {
        XhtmlString FooterText { get; set; }
    }
}
