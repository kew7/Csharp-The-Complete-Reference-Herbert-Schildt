// демонстрация использования контейнера
// для хранения компонентов.
using System;
using System.ComponentModel;
using CipherLib; // Импортируем пространство имен

// компонента CipherComp.
class UseContainer
{
    public static void Main(string[] args)
    {
        string str = "Использование контейнеров.";
        Container cont = new Container();
        CipherComp cc = new CipherComp();
        CipherComp cc2 = new CipherComp();
        cont.Add(cc);
        cont.Add(cc2, "Второй компонент");
        Console.WriteLine("Первое сообщение: " + str);
        str = cc.Encode(str);
        Console.WriteLine("Первое сообщение в зашифрованном виде: " + str);
        str = cc.Decode(str);
        Console.WriteLine("Первое сообщение в дешифрованном виде: " + str);
        str = "один, два, три";
        Console.WriteLine("Второе сообщение: " + str);
        str = cc2.Encode(str);
        Console.WriteLine("Второе сообщение в зашифрованном виде: " + str);
        str = cc2.Decode(str);
        Console.WriteLine("Второе сообщение в дешифрованном виде: " + str);
        Console.WriteLine("\nИмя объекта cc2: " + cc2.Site.Name);
        Console.WriteLine();
        // Освобождаем оба компонента.
        cont.Dispose();
    }
}
