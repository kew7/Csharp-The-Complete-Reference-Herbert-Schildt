// Сортировка ArrayList-массива и поиск в нем
// заданного элемента.
using System;
using System.Collections;
class SortSearchDemo
{
    public static void Main()
    {
        // Создаем динамический массив.
        ArrayList al = new ArrayList();
        // Добавляем в него элементы.
        al.Add(55);
        al.Add(43);
        al.Add(-4);
        al.Add(88);
        al.Add(3);
        al.Add(19);
        Console.Write("Исходное содержимое: ");
        foreach (int i in al)
            Console.Write(i + " ");
        Console.WriteLine("\n");
        // Сортируем массив.
        al.Sort();
        // Используем цикл foreach для отображения
        // содержимого массива.
        Console.Write("Содержимое после сортировки: ");
        foreach (int i in al)
            Console.Write(i + " ");
        Console.WriteLine("\n");
        Console.WriteLine("Индекс элемента 43 равен " + al.BinarySearch(43));
    }
}
