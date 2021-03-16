// Использование класса Uri.
using System;
using System.Net;
class UriDemo
{
    public static void Main()
    {
        Uri sample = new Uri("https://xunit.net/docs/getting-started/netfx/visual-studio#create-class-library");
        Console.WriteLine("Хост: " + sample.Host);
        Console.WriteLine("Порт: " + sample.Port);
        Console.WriteLine("Протокол: " + sample.Scheme);
        Console.WriteLine("Локальный маршрут: " + sample.LocalPath);
        Console.WriteLine("Запрос: " + sample.Query);
        Console.WriteLine("Маршрут и запрос: " + sample.PathAndQuery);
    }
}
