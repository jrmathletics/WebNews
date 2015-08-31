using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;
using WebNews.Business.UIDescriptors;
using WebNews.Models.ViewModels;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "EventPage", GUID = "4f448415-2c4f-4536-8061-cae990e2e74e", Description = "")]
    public class EventPage : BaseEditorialPage
    {

        [CultureSpecific]
        [Display(
            Name = "EventText",
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual XhtmlString EventText { get; set; }


        [CultureSpecific]
        [Required(ErrorMessage = "A StartTime is needed!")]
        [Display(
            Name = "StartTime",
            GroupName = SystemTabNames.Content,
            Order = 8)]
        public virtual DateTime StartTime { get; set; }

        [CultureSpecific]
        [Display(
            Name = "EndTime",
            GroupName = SystemTabNames.Content,
            Order = 9)]
        public virtual DateTime? EndTime { get; set; }

        [AllowedTypes(new[] { typeof(PersonPage) })]
        [CultureSpecific]
        [Display(
            Name = "EventPerson",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentReference EventPerson { get; set; }

        [EditorDescriptor(EditorDescriptorType = typeof(CoordinatesEditorDescriptor))]
        public virtual string Coordinates { get; set; }

    }
}