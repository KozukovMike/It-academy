namespace HW_13;

public class Client
{
    public string Name { get; set; }

    public void ReceiveNews(object provide, NewsEventArgs e)
    {
        Console.WriteLine($"{Name} received news in category {e.Category}: {e.News}");
    }
}
