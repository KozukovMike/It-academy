namespace HW_5;

internal class Program
{
    static void Main(string[] args)
    {
        var book1 = new Book();
        var book2 = new Book("The Lord of the Rings", "Tolkien", 1024);
        var book3 = new Book();
        book3.Author = "Rowling";
        book3.Title = "Harry Potter";
        book3.Pages = 512;
        var message1 = book1.GetDescription();
        var message2 = book2.GetDescription();
        var message3 = book3.GetDescription();
        Console.WriteLine(message1);
        Console.WriteLine(message2);
        Console.WriteLine(message3);
    }
}
