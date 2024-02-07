namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title);
        }
    }
}

public class Book
{
    public string Title;
    public int Price;

    public Book(string title, int price)
    {
        Title = title;
        Price = price;
    }
}

public class BookRepository
{
    public List<Book> GetBooks() => new()
    {
        new Book("Title 1", 100),
        new Book("Title 2", 5),
        new Book("Title 3", 100)
    };
}

