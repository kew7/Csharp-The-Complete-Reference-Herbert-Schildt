// Простой пример "объективизации" и "дезобъективизации".
using System;
class BoxingDemo
{
    public static void Main()
    {
        int x;
        object obj;
        x = 10;
        obj = x; // "Превращаем" x в объект.
        int y = (int)obj; // Обратное "превращение"
                          // объекта obj в int-значение.
        Console.WriteLine(y);
    }
}
