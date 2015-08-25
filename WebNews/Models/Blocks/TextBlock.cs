using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace WebNews.Models.Blocks
{
    [ContentType(DisplayName = "TextBlock", GUID = "f3cfc2ff-d470-417a-aa03-dd607abdd2f7", Description = "")]
    public class TextBlock : BaseBlock
    {
    }
}