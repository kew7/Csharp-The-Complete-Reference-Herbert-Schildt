// MiniCrawler: Web-такси.
using System;
using System.Net;
using System.IO;

class MiniCrawler
{
    // Находим гиперссылку в строке.
    static string FindLink(string htmlstr, ref int startloc)
    {
        int i;
        int start, end;
        string uri = null;
        string lowcasestr = htmlstr.ToLower();
        i = lowcasestr.IndexOf("href=\"http", startloc);
        if (i != -1)
        {
            start = htmlstr.IndexOf('"', i) + 1;
            end = htmlstr.IndexOf('"', start);
            uri = htmlstr.Substring(start, end - start);
            startloc = end;
        }
        return uri;
    }
    public static void Main(string[] args)
    {
        string link = null;
        string str;
        string answer;
        int curloc; // Содержит текущую позицию в ответе.
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: MiniCrawler <uri>");
            return;
        }
        string uristr = args[0]; // Содержит текущий URI-адрес.
        try
        {
            do
            {
                Console.WriteLine("Переход по адресу " + uristr);
                // Создаем WebRequest-запрос по заданному URI.
                HttpWebRequest req = (HttpWebRequest)
                WebRequest.Create(uristr);
                uristr = null; // Запрещаем дальнейшее
                               // использование этого URI-адреса.
                               // Отсылаем этот запрос и получаем ответ.
                HttpWebResponse resp = (HttpWebResponse)
                req.GetResponse();
                // Из потока, содержащего ответ, получаем
                // входной поток.
                Stream istrm = resp.GetResponseStream();

                // Представляем входной поток
                // в виде StreamReader-объекта.
                StreamReader rdr = new StreamReader(istrm);

                // Считываем целую страницу.
                str = rdr.ReadToEnd();
                curloc = 0;
                do
                {
                    // Находим следующий URI-адрес для перехода
                    // по гиперссылке.
                    link = FindLink(str, ref curloc);
                    if (link != null)
                    {
                        Console.WriteLine("Гиперссылка найдена: " + link);
                        Console.Write("Ссылка, Дальше, Выход?");
                        answer = Console.ReadLine();
                        if (string.Compare(answer, "C", true) == 0)
                        {
                            uristr = string.Copy(link);
                            break;
                        }
                        else if (string.Compare(answer, "B", true) == 0)
                        {
                            break;
                        }
                        else if (string.Compare(answer, "Д", true) == 0)
                        {
                            Console.WriteLine("Поиск следующей ссылки.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Больше ссылок не найдено.");
                        break;
                    }
                } while (link.Length > 0);
                // Закрываем поток, содержащий ответ.
                resp.Close();
            } while (uristr != null);
        }
        catch (WebException exc)
        {
            Console.WriteLine("Сетевая ошибка: " + exc.Message + "\nКод состояния: " + exc.Status);
        }
        catch (ProtocolViolationException exc)
        {
            Console.WriteLine("Ошибка протокола: " + exc.Message);
        }
        catch (UriFormatException exc)
        {
            Console.WriteLine("Ошибка в формате URI: " + exc.Message);
        }
        catch (NotSupportedException exc)
        {
            Console.WriteLine("Неизвестный протокол: " + exc.Message);
        }
        catch (IOException exc)
        {
            Console.WriteLine("I/O Error: " + exc.Message);
        }
        Console.WriteLine("Завершение программы MiniCrawler.");
    }
}
