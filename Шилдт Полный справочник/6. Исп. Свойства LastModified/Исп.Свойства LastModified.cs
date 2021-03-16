// Использование свойства LastModified.
using System;
using System.Net;
class HeaderDemo
{
    public static void Main()
    {
        HttpWebRequest req = (HttpWebRequest)
        WebRequest.Create("http://www.Microsoft.com");
        HttpWebResponse resp = (HttpWebResponse)
        req.GetResponse();
        Console.WriteLine(
        "Время и дата последней модификации: " +
        resp.LastModified);
        resp.Close();
    }
}
