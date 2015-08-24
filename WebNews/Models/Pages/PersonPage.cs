using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "PersonPage", GUID = "fa18659a-c502-43da-96bc-21561af2f8d4", Description = "")]
    public class PersonPage : BaseEditorialPage
    {

        [CultureSpecific]
        [Required(ErrorMessage = "Fornavn må være fylt ut!")]
        [Display(
            Name = "Fornavn",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string FirstName { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "Etternavn må være fylt ut!")]
        [Display(
            Name = "Etternavn",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string LastName { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "Adresse må være fylt ut!")]
        [Display(
            Name = "Adresse",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual string Street { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "Postnummer må være fylt ut!")]
        [Display(
            Name = "Postnummer(må være 4 siffer)",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        [RegularExpression("\\d{4}",
        ErrorMessage = "Ugyldig format på postnummer!")]
        public virtual string PostalCode { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "By må være fylt ut!")]
        [Display(
            Name = "By",
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual string City { get; set; }


        [CultureSpecific]
        [Required (ErrorMessage = "E-post må være fylt ut!")]
        [Display(
            Name = "E-postadresse",
            GroupName = SystemTabNames.Content,
            Order = 8)]
        [EmailAddress(ErrorMessage = "Ugyldig e-postadresse")]
        [DataType(DataType.EmailAddress)]
        public virtual string EmailAddress { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "Telefonnummer må være fylt ut!")]
        [Display(
            Name = "Telefonnummer",
            GroupName = SystemTabNames.Content,
            Order = 9)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]{8}$")]

        public virtual string PhoneNumber { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "Du må legge ved bilde!")]
        [Display(
            Name = "Personbilde",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PersonImage { get; set; }

    }
}