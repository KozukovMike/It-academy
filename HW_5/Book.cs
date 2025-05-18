namespace HW_5;

class Book
{
    
    private string _title;
    private string _author;
    private int _pages;

    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You should write a title");
                _title = "Unknown";
            }
            else
            { 
                _title = value;
            }
        }
    }

    public string Author
    {
        get
        {
            return _author;
        }
        set 
        {

            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You should write an author to the book");
                _author = "Unknown";
            }
            else
            {
                _author = value;
            }
        }
    }

    public int Pages
    {
        get
        {
            return _pages;
        }
        set
        {

            if (value <= 0)
            {
                Console.WriteLine("You should enter a positive pages number");
                _pages = 0;
            }
            else
            {
                _pages = value;
            }
        }
    }

    public Book()
    {
        _pages = 0;
        _author = "Unknown";
        _title = "Unknown";
    }

    public Book(string title, string author, int pages)
    {
        _title= title;
        _author = author;
        _pages = pages;
    }

    public string GetDescription()
    {
        return $"Название: {Title}, Автор: {Author}, Страниц: {Pages}";
    }
}
