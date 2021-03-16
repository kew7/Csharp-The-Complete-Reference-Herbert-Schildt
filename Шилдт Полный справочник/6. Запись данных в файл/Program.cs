// Запись данных в файл.
using System;
using System.IO;
class WriteToFile
{
    public static void Main(string[] args)
    {
        FileStream fout;
        // Открываем выходной файл.
        try
        {
            fout = new FileStream("test.txt", FileMode.Create);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "\nОшибка при открытии выходного файла.");
            return;
        }
        // Записываем в файл алфавит.
        try
        {
            for (char c = 'A'; c <= 'Z'; c++)
                fout.WriteByte((byte)c);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "Ошибка при записи в файл. ");
        }
        fout.Close();
    }
}