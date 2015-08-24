using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "ArticlePage", GUID = "ba296511-df1d-400a-b2ac-9923d06e118e", Description = "")]
    public class ArticlePage : BaseEditorialPage
    {
        [CultureSpecific]
        [Display(
                    Name = "Artikkeltekst",
                    GroupName = SystemTabNames.Content,
                    Order = 3)]
        public virtual XhtmlString BodyText { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            this.VisibleInMenu = true;
        }
    }
}