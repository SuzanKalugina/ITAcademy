namespace Task1;

public class Reader
{
    public string Name { get; set; }
    public GenreType[] Genres { get; set; }

    public Reader(string name, params GenreType[] genres)
    {
        Name = name;
        Genres = genres;
    }

    public void ReadBook(Book book)
    {
        Console.WriteLine($"Reader: {Name}. Book: {book.Id}, {book.Genre}");
    }
}