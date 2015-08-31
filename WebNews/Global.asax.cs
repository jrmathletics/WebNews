using System;
using System.Web.Mvc;
using EPiServer;
using WebNews.Business.Rendring;

namespace WebNews
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            ViewEngines.Engines.Add(new CustomViewEngine());

            DataFactory.Instance.PublishedContent += OnPublishedContent;
            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }

        private void OnPublishedContent(Object sender, ContentEventArgs e)
        {
            LogInfo("ContentPublished:", e);

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