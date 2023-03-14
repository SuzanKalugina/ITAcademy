using Task1; 

var reader1 = new Reader("1", GenreType.Genre1, GenreType.Genre2);
var reader2 = new Reader("2", GenreType.Genre3, GenreType.Genre4);

var library = new Library();

library.AddReader(reader1);
library.AddReader(reader2);

library.AddBook(new Book(1, GenreType.Genre1));
library.AddBook(new Book(2, GenreType.Genre2));
library.AddBook(new Book(3, GenreType.Genre3));
library.AddBook(new Book(4, GenreType.Genre4));