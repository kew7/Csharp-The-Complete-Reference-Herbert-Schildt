// Демонстрация использования нумератора.
using System;
using System.Collections;
class EnumeratorDemo
{
    public static void Main()
    {
        ArrayList list = new ArrayList(1);
        for (int i = 0; i < 10; i++)
            list.Add(i);
        // Используем нумератор для доступа к списку.
        IEnumerator etr = list.GetEnumerator();
        while (etr.MoveNext())
            Console.Write(etr.Current + " ");
        Console.WriteLine();
        // Устанавливаем позицию нумератора в начало коллекции.
        etr.Reset();
        while (etr.MoveNext())
            Console.Write(etr.Current + " ");
        Console.WriteLine();
    }
}
