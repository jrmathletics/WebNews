using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace WebNews.Models.Blocks
{
    [ContentType(DisplayName = "ClientBlock", GUID = "2d2d93fc-3b42-4b8b-a35e-cd5eaf88608b", Description = "")]
    public class ClientBlock : BlockData
    {
        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client1 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client2 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client3 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client4 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client5 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client6 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client7 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client8 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client9 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client10 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client11 { get; set; }

        [Display(
                GroupName = SystemTabNames.Content,
                Order = 400)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Client12 { get; set; }


    }
}