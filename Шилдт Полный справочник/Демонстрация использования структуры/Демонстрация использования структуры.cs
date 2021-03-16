// Демонстрация использования структуры.
using System;
// Определение структуры.
struct Book
{
    public string author;
    public string title;
    public int copyright;
    public Book(string a, string t, int c)
    {
        author = a;
        title = t;
        copyright = c;
    }
}
// Демонстрируем использование структуры Book.
class StructDemo
{
    public static void Main()
    {
        Book book1 = new Book("Herb Schildt", "C# A Beginner's Guide", 2001); // Вызов явно заданного
                                                                              // конструктора.
        Book book2 = new Book(); // Вызов конструктора
                                 // по умолчанию.
        Book book3; // Создание объекта без вызова
                    // конструктора.
        Console.WriteLine(book1.title + ", автор " + book1.author + ", (c) " + book1.copyright);
        Console.WriteLine();
        if (book2.title == null)
            Console.WriteLine("Член book2.title содержит null.\n");
        // Теперь поместим в структуру book2 данные.
        book2.title = "Brave New World";
        book2.author = "Aldous Huxley";
        book2.copyright = 1932;
        Console.Write("Теперь структура book2 содержит:\n ");
        Console.WriteLine(book2.title + ", автор " + book2.author + ", (c) " + book2.copyright);
        Console.WriteLine();
        // Console.WriteLine(bооk3.title); // Ошибка: сначала
        // необходима
        // инициализация.
        book3.title = "Red Storm Rising";
        Console.WriteLine(book3.title); // Теперь все Ok!
    }
}