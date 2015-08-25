using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

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