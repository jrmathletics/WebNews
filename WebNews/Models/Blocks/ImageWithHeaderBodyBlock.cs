using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace WebNews.Models.Blocks
{
    [ContentType(DisplayName = "ImageWithHeaderBodyBlock", GUID = "718c7ee4-111f-4f7a-93b9-69f00a58cb1c", Description = "")]
    public class ImageWithHeaderBodyBlock : BaseBlock
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentReference Image { get; set; }
        
    }
}