using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
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
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Coordinates { get; set; }
        public EventPageViewModel(EventPage currentPage) : base(currentPage)
        {
            ServiceLocator = EPiServer
                             .ServiceLocation
                             .ServiceLocator
                             .Current.GetInstance<IContentLoader>();
            EventStartTime.ToString("dd/MM/yyyy hh:mm");
            if (EventEndTime != null)
            {
                EventEndTime.ToString("dd/MM/yyyy hh:mm");
            }
            if (currentPage.EventPerson != null)
            {
                EventCreatorEmail = GetCreatorEmail(currentPage);
                EventCreatorPhoneNumber = GetCreatorPhoneNumber(currentPage);
            }
            if (currentPage.Coordinates != null)
            {
                Coordinates = currentPage.Coordinates;
                GetPosition(Coordinates);
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

        public void GetPosition(string coordinates)
        {
            char[] splitter = { ',' };
            string[] coords = coordinates.Split(splitter);
            Longitude = Double.Parse(coords[1]);
            Latitude = Double.Parse(coords[0]);
        }

        public string GetCreatorPhoneNumber(EventPage currentPage)
        {
            return ServiceLocator.Get<PersonPage>(currentPage.EventPerson).PhoneNumber;

        }

    }
}