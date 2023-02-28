using Task2;

var book1 = new Book("Основы IT", "синий", 120);
var book2 = new Book("Основы кройки и шитья", "белый", 95);
var magazine1 = new Magazine("Успех", "каждый понедельник", "студенты");
var magazine2 = new Magazine("Домашний доктор", "1го числа ежемесячно", "пенсионеры");

IPrintable[] printedProduct = {book1, book2, magazine1, magazine2};
foreach (var item in printedProduct)
{
    item.Print();
}

Book.PrintBooks(printedProduct);
Magazine.PrintMagazines(printedProduct);