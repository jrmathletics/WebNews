using EPiServer;

namespace WebNews.Events
{
    public interface IPublishingPage
    {
        void PublishingPage(object sender, PageEventArgs e);
    }
}