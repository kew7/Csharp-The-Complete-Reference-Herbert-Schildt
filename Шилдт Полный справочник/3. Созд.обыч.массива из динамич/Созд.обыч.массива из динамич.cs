// Преобразование ArrayList-коллекции в массив.
using System;
using System.Collections;
class ArrayListToArray
{
    public static void Main()
    {
        ArrayList al = new ArrayList();
        // Добавляем элементы в динамический массив.
        al.Add(1);
        al.Add(2);
        al.Add(3);
        al.Add(4);
        Console.Write("Содержимое: ");
        foreach (int i in al)
            Console.Write(i + " ");
        Console.WriteLine();
        // Создаем обычный массив из динамического.
        int[] ia = (int[])al.ToArray(typeof(int));
        int sum = 0;
        // Суммируем элементы массива.
        for (int i = 0; i < ia.Length; i++)
            sum += ia[i];
        Console.WriteLine("Сумма равна: " + sum);
    }
}
