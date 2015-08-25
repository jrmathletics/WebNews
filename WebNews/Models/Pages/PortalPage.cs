using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "PortalPage", GUID = "6aeec750-dec5-4af4-92df-cb20a3c3dedd", Description = "")]
    public class PortalPage : BaseEditorialPage
    {

        [CultureSpecific]
        [Display(
            Name = "ContentArea",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual ContentArea PortalContentArea { get; set; }

    }
}