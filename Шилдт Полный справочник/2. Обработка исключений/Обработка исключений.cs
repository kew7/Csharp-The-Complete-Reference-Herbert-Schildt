// Обработка сетевых исключений.
using System;
using System.Net;
using System.IO;
class NetExcDemo
{
    public static void Main()
    {
        int ch;
        try
        {
            // Сначала создаем WebRequest-запрос по URI-адресу.
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create("https://xunit.net");

            // Затем отправляем запрос и получаем ответ.
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();

            //Из ответа получаем входной поток.
            Stream istrm = resp.GetResponseStream();

            /* А теперь считываем и отображаем html-документ,
            полученный от заданного URI. Текст "не улетит"
            с экрана, поскольку данные отображаются порциями
            объемом в 400 символов. Просмотрев очередные
            400 символов, нажмите клавишу <ENTER>
            для получения следующей часть документа. */
            for (int i = 1; ; i++)
            {
                ch = istrm.ReadByte();
                if (ch == -1) break;
                Console.Write((char)ch);
                if ((i % 400) == 0)
                {
                    Console.Write("\nНажмите клавишу.");
                    Console.Read();
                }
            }

            // Закрываем поток, содержащий ответ. При этом
            // автоматически закроется и входной поток istrm.
            resp.Close();
        }
        catch (WebException exc)
        {
            Console.WriteLine("Сетевая ошибка: " + exc.Message +
            "\nКод состояния: " + exc.Status);
        }
        catch (ProtocolViolationException exc)
        {
            Console.WriteLine("Ошибка протокола: " + exc.Message);
        }
        catch (UriFormatException exc)
        {
            Console.WriteLine("Ошибка формата URI: " + exc.Message);
        }
        catch (NotSupportedException exc)
        {
            Console.WriteLine("Неизвестный протокол: " + exc.Message);
        }
        catch (IOException exc)
        {
            Console.WriteLine("I/O Error: " + exc.Message);
        }
    }
}
