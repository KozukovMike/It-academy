namespace HW_13;

public class NewsProvider
{
    public event EventHandler<NewsEventArgs> NewsEvent;

    public void SendNews(string category, string news)
    {
        OnNewsEvent(new NewsEventArgs(category, news));
    }

    protected void OnNewsEvent(NewsEventArgs e)
    {
        NewsEvent?.Invoke(this, e);
    }
}
