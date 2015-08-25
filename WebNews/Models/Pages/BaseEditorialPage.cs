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

        [Display(
            Name = "Ingress",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.LongString)]
        public virtual string IntroText { get; set; }
        
    }
}