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
            Name ="Main",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual XhtmlString MainBody { get; set; }
         
    }
}