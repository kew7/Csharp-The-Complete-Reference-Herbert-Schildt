// Копирование массива.
using System;
class CopyDemo
{
    public static void Main()
    {
        int[] source = { 1, 2, 3, 4, 5 };
        int[] target = { 11, 12, 13, 14, 15 };
        int[] source2 = { -1, -2, -3, -4, -5 };
        // Отображаем массив-источник копирования.
        Console.Write("Массив-источник: ");
        foreach (int i in source)
            Console.Write(i + " ");
        Console.WriteLine();
        // Отображаем исходное содержимое массива-приемника.
        Console.Write("Исходное содержимое массива-приемника: ");
        foreach (int i in target)
            Console.Write(i + " ");
        Console.WriteLine();
        // Копируем весь массив.
        Array.Copy(source, target, source.Length);
        // Отображаем копию массива.
        Console.Write("Приемник после копирования: ");
        foreach (int i in target)
            Console.Write(i + " ");
        Console.WriteLine();
        // Копируем в середину массива target.
        Array.Copy(source2, 2, target, 3, 2);
        // Отображаем результат частичного копирования.
        Console.Write("Приемник после частичного копирования: ");
        foreach (int i in target)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
