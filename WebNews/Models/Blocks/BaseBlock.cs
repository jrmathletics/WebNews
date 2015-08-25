using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace WebNews.Models.Blocks
{
    [ContentType(DisplayName = "BaseBlock", GUID = "219ab8e1-5b91-4178-b0d5-13e04c6a5a2f", Description = "")]
    public abstract class BaseBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Textblock header",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Header { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Body",
                    Description = "Textblock body",
                    GroupName = SystemTabNames.Content,
                    Order = 2)]
        public virtual XhtmlString Body { get; set; }
    }
}