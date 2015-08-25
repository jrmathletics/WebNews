using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebNews.Business.Rendring
{
    public class CustomViewEngine : RazorViewEngine
    {
        public static readonly string[] CustomViewEngineFormats = new[]
        {
            "~/Views/Blocks/{0}/Index.cshtml",
            "~/Views/Pages/{1}/{0}.cshtml"
        };

        public CustomViewEngine()
        {
            base.PartialViewLocationFormats = base.PartialViewLocationFormats.Union(CustomViewEngineFormats).ToArray();
            base.ViewLocationFormats = base.ViewLocationFormats.Union(CustomViewEngineFormats).ToArray();
        }
    }

}