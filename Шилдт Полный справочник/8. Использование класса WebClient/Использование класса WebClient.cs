// Использование класса WebClient для загрузки
// информации в файл.
using System;
using System.Net;
using System.IO;

class WebClientDemo
{
    public static void Main()
    {
        WebClient user = new WebClient();
        string uri = "https://www.youtube.com";
        string fname = "data.txt";
        try
        {
            Console.WriteLine("Загрузка данных из Web-страницы " + uri + " в файл " + fname);
            user.DownloadFile(uri, fname);
        }
        catch (WebException exc)
        {
            Console.WriteLine(exc);
        }
        catch (UriFormatException exc)
        {
            Console.WriteLine(exc);
        }
        Console.WriteLine("Загрузка завершена.");
    }
}
