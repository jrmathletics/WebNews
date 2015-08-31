using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer;
using WebNews.Models.Pages;

namespace WebNews.Models.ViewModels
{
    public class EventPageViewModel : PageViewModel<EventPage>
    {

        public PersonPage EventCreator { get; set; }
        public string EventCreatorEmail { get; set; }
        public string EventCreatorName { get; set; }
        public string EventCreatorPhoneNumber { get; set; }
        public EventPageViewModel(EventPage currentPage) : base(currentPage)
        {
            ServiceLocator = EPiServer
                             .ServiceLocation
                             .ServiceLocator
                             .Current.GetInstance<IContentLoader>();
            if (currentPage.EventPerson != null)
            {
                EventCreatorEmail = GetCreatorEmail(currentPage);
                EventCreatorPhoneNumber = GetCreatorPhoneNumber(currentPage);
            }

        }

        public string GetCreatorEmail(EventPage currentPage)
        {

            return ServiceLocator.Get<PersonPage>(currentPage.EventPerson).EmailAddress;
        }

        public string GetCreatorName(EventPage currentPage)
        {

            return ServiceLocator.Get<PersonPage>(currentPage.EventPerson).FirstName;

        }

        public string GetCreatorPhoneNumber(EventPage currentPage)
        {
            return ServiceLocator.Get<PersonPage>(currentPage.EventPerson).PhoneNumber;

        }

    }
}