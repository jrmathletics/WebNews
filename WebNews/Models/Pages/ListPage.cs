using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "ListPage", GUID = "67aee80d-54c3-40a8-8c2c-79a49fb1bfd2", Description = "")]
    public class ListPage : BaseEditorialPage
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string MainBody { get; set; }
         
    }
}