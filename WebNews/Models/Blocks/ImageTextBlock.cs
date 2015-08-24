using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace WebNews.Models.Blocks
{
    [ContentType(DisplayName = "ImageTextBlock", GUID = "751589a2-ac93-4e5d-8b96-e54131c417ca", Description = "")]
    public class ImageTextBlock : BlockData
    {
        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BlockImage { get; set; }

        [CultureSpecific]
        [Display(
    Name = "Header",
    Description = "Name field's description",
    GroupName = SystemTabNames.Content,
    Order = 1)]
        public virtual String Header { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Body",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 2)]
        public virtual String Body { get; set; }

    }
}