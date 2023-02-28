using System.Xml.Linq;

namespace Task2
{
    internal class Book : IPrintable
    {
        public string Name { get; set; }
        public string СoverСolor { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string name, string coverСolor, int numberOfPages)
        {
            Name = name;
            СoverСolor = coverСolor;
            NumberOfPages = numberOfPages;
        }

        public void Print()
        {
            Console.WriteLine($"Это книга. Название: {Name}, цвет обложки: {СoverСolor}, количество страниц: {NumberOfPages}."); 
        }
        public static void PrintBooks(IPrintable[] printable)
        {
            foreach (var item in printable)
            {
                if (item is Book)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
