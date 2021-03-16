/* Отображение cookie-данных.
Чтобы узнать, какие cookie-данные использует
интересующий вас Web-сайт, укажите его имя
Например, если эту программу назвать
Cookie, то после выполнения команды
Cookie http://MSN.COM
будут отображены cookie-данные,
связанные с Web-сайтом MSN.COM. */
using System;
using System.Net;
class CookieDemo
{
    public static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: CookieDemo <uri>");
            return;
        }
        // Создаем WebRequest-запрос по заданному URI-адресу.
        HttpWebRequest req = (HttpWebRequest)  WebRequest.Create(args[0]);

        // Получаем пустой cookie-контейнер.
        req.CookieContainer = new CookieContainer();

        // Отправляем запрос и получаем ответ.
        HttpWebResponse resp = (HttpWebResponse) req.GetResponse();

        // Отображаем cookie-данные.
        Console.WriteLine("Количество cookie-разделов: " + resp.Cookies.Count);
        Console.WriteLine("40,-20){1}", "Имя", "Значение");
        for (int i = 0; i < resp.Cookies.Count; i++)
            Console.WriteLine("{0, -20}{1}",
            resp.Cookies[i].Name, resp.Cookies[i].Value);

        // Закрываем поток, содержащий ответ.
        resp.Close();
    }
}
