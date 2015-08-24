using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "BaseEditorialPage", GUID = "b8512201-40cb-4cb9-b9ca-0fff38ee122e", Description = "")]
    public abstract class BaseEditorialPage : PageData
    {

        [CultureSpecific]
        [Display(
        Name = "Overskrift",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual string Header { get; set; }

        [UIHint(UIHint.LongString)]
        [CultureSpecific]
        [Display(
                    Name = "Ingress",
                    GroupName = SystemTabNames.Content,
                    Order = 2)]
        public virtual XhtmlString IntroText { get; set; }

    }
}