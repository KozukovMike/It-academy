namespace HW_13;

public class NewsEventArgs : EventArgs
{
    public string Category { get; set; }
    public string News { get; set; }

    public NewsEventArgs(string category, string news)
    {
        Category = category;
        News = news;
    }
}
