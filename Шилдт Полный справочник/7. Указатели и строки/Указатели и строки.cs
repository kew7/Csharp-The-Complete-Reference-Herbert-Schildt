// Использование fixed-инструкций для получения
// указателя на начало строки.
using System;
class Fixedstring
{
    unsafe public static void Main()
    {
        string str = "Это простой тест.";
        // Направляем указатель p на начало строки str.
        fixed (char* p = str)
        {
            // Отображаем содержимое строки str
            // с помощью указателя р.
            for (int i = 0; p[i] != 0; i++)
                Console.Write(p[i]);
        }
        Console.WriteLine();
    }
}