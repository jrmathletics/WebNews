using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.SpecializedProperties;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "FolderPage", GUID = "c3886e90-7404-4c62-89a0-70d339c20a70", Description = "",
        AvailableInEditMode = false)]

    public class FolderPage : BaseEditorialPage, IContentData
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            base.VisibleInMenu = false;
        }
        
    }
}