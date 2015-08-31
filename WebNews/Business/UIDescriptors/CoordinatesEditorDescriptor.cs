using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using EPiServer.Web;

namespace WebNews.Business.UIDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = UIHint)]

    public class CoordinatesEditorDescriptor : EditorDescriptor
    {
        public const string UIHint = "CoordinatesEditorDescriptor";

        public CoordinatesEditorDescriptor()
        {
            ClientEditingClass = "tedgustaf.googlemaps.Editor";
        }
    }

}