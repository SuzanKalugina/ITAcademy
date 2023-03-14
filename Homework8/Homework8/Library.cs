namespace Task1;

public class Library
{
    private delegate void BookHandler(Book book);
    private event BookHandler? OnBookAdd;

    private readonly List<Book> books = new();
    private readonly List<Reader> readers = new();

    public void AddBook(Book book)
    {
        books.Add(book);

        OnBookAdd?.Invoke(book);
    }

    public void AddReader(Reader reader)
    {
        readers.Add(reader);

        OnBookAdd += book =>
        {
            if (reader.Genres.Contains(book.Genre))
            {
                reader.ReadBook(book);
            }
        };
    }
}

