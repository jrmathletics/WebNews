using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "EventPage", GUID = "4f448415-2c4f-4536-8061-cae990e2e74e", Description = "")]
    public class EventPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "EventText",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString EventText { get; set; }


        [CultureSpecific]
        [Required(ErrorMessage = "A StartTime is needed!")]
        [Display(
            Name = "StartTime",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual DateTime StartTime { get; set; }

        [CultureSpecific]
        [Display(
            Name = "EndTime",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual DateTime? EndTime { get; set; }

        [CultureSpecific]
        [Display(
            Name = "EventPerson",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual ContentReference EventPerson { get; set; }

    }
}