﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using log4net;
using WebNews.Events;

namespace WebNews.Models.Pages
{
    [ContentType(DisplayName = "BasePage", GUID = "3955ed6f-c197-4849-ab59-bcf2f8981b33", Description = "")]
    public class BasePage : PageData
    {

    }

}