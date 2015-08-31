using EPiServer;

namespace WebNews.Events
{
    public interface IPublishedPage
    {
        void PublishedPage(object sender, PageEventArgs e);
    }
}