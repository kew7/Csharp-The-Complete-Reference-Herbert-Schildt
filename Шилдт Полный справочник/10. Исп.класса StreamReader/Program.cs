/* Простая утилита "клавиатура-диск", которая
демонстрирует использование класса StreamReader. */

using System;
using System.IO;
class DtoS
{
    public static void Main()
    {
        FileStream fin;
        string s;
        try
        {
            fin = new FileStream("test.txt", FileMode.Open);
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message + "Не удается открыть файл.");
            return;
        }
        StreamReader fstr_in = new StreamReader(fin);
        // Считываем файл построчно.
        while ((s = fstr_in.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
        fstr_in.Close();
    }
}
