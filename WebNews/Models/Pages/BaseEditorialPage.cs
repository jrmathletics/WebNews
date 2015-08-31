using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using EPiServer;
using EPiServer.BaseLibrary.Search;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Logging.Compatibility;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using WebNews.Events;

namespace WebNews.Models.Pages
{
    public abstract class BaseEditorialPage : BasePage

    {
        [Display(
            Name = "Ingress",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.LongString)]
        public virtual string IntroText { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Artikkeltekst",
                    GroupName = SystemTabNames.Content,
                    Order = 3)]
        public virtual XhtmlString BodyText { get; set; }

    }
}