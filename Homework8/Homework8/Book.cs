namespace Task1
{
    public class Book
    {
        public int Id { get; set; }
        public GenreType Genre { get; set; }

        public Book(int id, GenreType genre)
        {
            Id = id;
            Genre = genre;
        }
    }
}
