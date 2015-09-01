using System;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAccess;
using WebNews.Business.Rendring;
using WebNews.Models.Pages;

namespace WebNews
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            ViewEngines.Engines.Add(new CustomViewEngine());

            DataFactory.Instance.PublishedContent += OnPublishedContent;
            DataFactory.Instance.PublishingContent += OnPublishingContent;
            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }

        private void OnPublishedContent(Object sender, ContentEventArgs e)
        {
            LogInfo("ContentPublished:", e);

        }

        private void SetEventPageCoordinatesInDB(ContentEventArgs e)
        {
            var originalPage = DataFactory.Instance.GetPage(e.ContentLink.ToPageReference());
            var page = originalPage.CreateWritableClone() as EventPage;

            if (page != null)
            {
                if (page.Coordinates != null)
                {

                    page.Latitude = double.Parse(page.Coordinates.Split(',')[0]);
                    page.Longitude = double.Parse(page.Coordinates.Split(',')[1]);
                }
                DataFactory.Instance.Save(page, SaveAction.Save);
            }
        }

        private void OnPublishingContent(object sender, ContentEventArgs e)
        {
            SetEventPageCoordinatesInDB(e);
            LogInfo("PublishingContent", e);
        }

        private void LogInfo(string type, ContentEventArgs e)
        {
            log4net.ILog log =
                log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            var msg = string.Format("EventType: {0}, PageId: {1}, Name:{2}", type, e.ContentLink.ID, e.Content.Name);
            log.Error(msg);
        }
    }
}