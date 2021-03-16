// Демонстрация произвольного доступа к файлу.
using System;
using System.IO;
class RandomAccessDemo
{
    public static void Main()
    {
        FileStream f;
        char ch;
        try
        {
            f = new FileStream("random.dat", FileMode.Create);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }

        // Записываем в файл алфавит.
        for (int i = 0; i < 26; i++)
        {
            try
            {
                f.WriteByte((byte)('A' + i));
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
        }
        try
        {
            // Теперь считываем отдельные значения.
            f.Seek(0, SeekOrigin.Begin); // Поиск первого байта.
            ch = (char)f.ReadByte();
            Console.WriteLine("Первое значение равно " + ch);
            f.Seek(1, SeekOrigin.Begin); // Поиск второго байта.
            ch = (char)f.ReadByte();
            Console.WriteLine("Второе значение равно " + ch);
            f.Seek(4, SeekOrigin.Begin); // Поиск пятого байта.
            ch = (char)f.ReadByte();
            Console.WriteLine("Пятое значение равно " + ch);
            Console.WriteLine();
            // Теперь считываем значения через одно.
            Console.WriteLine("Выборка значений через одно: ");
            for (int i = 0; i < 26; i += 2)
            {
                f.Seek(i, SeekOrigin.Begin); // Переход
                                             // к i-му байту.
                ch = (char)f.ReadByte();
                Console.Write(ch + " ");
            }
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message);
        }
        Console.WriteLine();
        f.Close();
    }
}
