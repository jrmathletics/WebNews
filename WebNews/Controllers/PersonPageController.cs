﻿using System.Web.Mvc;
using EPiServer.Web.Mvc;
using WebNews.Models.Pages;
using WebNews.Models.ViewModels;

namespace WebNews.Controllers
{
    public class PersonPageController : PageController<PersonPage>
    {
        public ActionResult Index(PersonPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var model = PageViewModel.Create(currentPage);
            return View(model);
        }
    }
}