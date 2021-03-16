// Отображение заголовков Web-сайта.
using System;
using System.Net;
class HeaderDemo
{
    public static void Main()
    {
        // Создаем WebRequest-запрос по URI-адресу.
        HttpWebRequest req = (HttpWebRequest) WebRequest.Create("https://xunit.net");
        
        // Отправляем этот запрос и получаем ответ.
        HttpWebResponse resp = (HttpWebResponse) req.GetResponse();

        // Получаем список имен.
        string[] names = resp.Headers.AllKeys;

        // Отображаем заголовок в виде пар имя/значение.
        Console.WriteLine("{0,-20}{1}\n", "Имя", "Значение");
        foreach (string n in names)
                Console.WriteLine("{0,-20}{1}", n, resp.Headers[n]);
        
        // Закрываем поток, содержащий ответ.
        resp.Close();
    }
}
