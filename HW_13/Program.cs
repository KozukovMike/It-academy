namespace HW_13;

internal class Program
{
    static void Main(string[] args)
    {
        NewsProvider provider = new NewsProvider();

        Client client1 = new Client { Name = "Alice" };
        Client client2 = new Client { Name = "Bob" };

        provider.NewsEvent += (sender, e) =>
        {
            if (e.Category == "News")
            {
                client1.ReceiveNews(sender, e);
            }
            else if (e.Category == "Sports")
            {
                client2.ReceiveNews(sender, e);
            }
            else
            {
                client1.ReceiveNews(sender, e);
                client2.ReceiveNews(sender, e);
            }
        };

        provider.SendNews("News", "Breaking news: New discovery made!");
        provider.SendNews("Weather", "Weather forecast: Sunny day ahead!");
        provider.SendNews("Sports", "Sports update: Team wins championship!");
    }
}
