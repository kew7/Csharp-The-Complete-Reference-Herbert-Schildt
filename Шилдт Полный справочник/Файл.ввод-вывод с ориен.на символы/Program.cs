/* Простая утилита "клавиатура-диск", которая
демонстрирует использование класса StreamWriter. */
using System;
using System.IO;

class KtoD
{
    public static void Main()
    {
        string str;
        FileStream fout;
        try
        {
            fout = new FileStream("test.txt", FileMode.Create);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "Не удается открыть файл. ");
            return;
        }
        StreamWriter fstr_out = new StreamWriter(fout);
        Console.WriteLine("Введите текст ('стоп' для завершения).");
        do
        {
            Console.Write(": ");
            str = Console.ReadLine();
            if (str != "стоп")
            {
                str = str + "\r\n"; // Добавляем символ
                                    // новой строки.
                try
                {
                    fstr_out.Write(str);
                }
                catch (IOException exc)
                {
                    Console.WriteLine(exc.Message + "Ошибка при работе с файлом.");
                    return;
                }
            }
        } while (str != "стоп");
        fstr_out.Close();
    }
}
