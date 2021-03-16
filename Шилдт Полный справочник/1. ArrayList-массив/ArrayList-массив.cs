// Демонстрация использования ArrayList-массива.
using System;
using System.Collections;

class ArrayListDemo
{
    public static void Main()
    {
        // Создаем динамический массив.
        ArrayList al = new ArrayList();
        Console.WriteLine("Начальная емкость: " + al.Capacity);
        Console.WriteLine("Начальное количество элементов: " + al.Count);
        Console.WriteLine();
        Console.WriteLine("Добавляем 6 элементов.");
        // Добавляем элементы в динамический массив.
        al.Add('С');
        al.Add('A');
        al.Add('E');
        al.Add('B');
        al.Add('D');
        al.Add('F');
        Console.WriteLine("Текущая емкость: " + al.Capacity);
        Console.WriteLine("Количество элементов: " + al.Count);
        // Отображаем массив, используя индексацию.
        Console.Write("Текущее содержимое массива: ");
        for (int i = 0; i < al.Count; i++)
            Console.Write(al[i] + " ");
        Console.WriteLine("\n");
        Console.WriteLine("Удаляем 2 элемента.");
        // Удаляем элементы из динамического массива.
        al.Remove('F');
        al.Remove('A');
        Console.WriteLine("Текущая емкость: " + al.Capacity);
        Console.WriteLine("Количество элементов: " + al.Count);
        // Для отображения массива используем цикл foreach.
        Console.Write("Содержимое: ");
        foreach (char c in al) Console.Write(c + " ");
        Console.WriteLine("\n");
        Console.WriteLine("Добавляем еще 20 элементов.");
        // Добавляем такое количество элементов в массив,
        // которое заставит его увеличить свой размер.
        for (int i = 0; i < 20; i++)
            al.Add((char)('a' + i));
        Console.WriteLine("Текущая емкость: " + al.Capacity);
        Console.WriteLine("Количество элементов после добавления 20 новых: " + al.Count);
        Console.Write("Содержимое: ");
        foreach (char c in al)
            Console.Write(c + " ");
        Console.WriteLine("\n");
        // Изменяем содержимое массива, используя индексацию.
        Console.WriteLine("Изменяем первые три элемента.");
        al[0] = 'X';
        al[1] = 'Y';
        al[2] = 'Z';
        Console.Write("Содержимое: ");
        foreach (char c in al)
            Console.Write(c + " ");
        Console.WriteLine();
    }
}
