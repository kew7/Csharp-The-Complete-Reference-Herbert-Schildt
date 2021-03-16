/*Чтобы выполнить сортировку или поиск значения в массиве объектных ссылок,
 тип класса этих объектов должен реализовать интерфейс IComparable.
 Если класс не реализует этот интерфейс, при попытке выполнить сортировку
 или поиск значения в массиве будет динамически сгенерировано исключение.
К счастью, интерфейс IComparable реализовать нетрудно, поскольку он состоит
только из одного метода:
    int CompareTo(object v)
Этот метод сравнивает вызывающий объект со значением в параметре v. Он
возвращает положительное число, если вызывающий объект больше значения v, нуль, если
два сравниваемых объекта равны, и отрицательное число, если вызывающий объект меньше
значения v.*/

// Сортировка и поиск в массиве объектов.
using System;
class MyClass : IComparable
{
    public int i;
    public MyClass(int x)
    {
        i = x;
    }
    // Реализуем интерфейс IComparable.
    public int CompareTo(object v)
    {
        return i - ((MyClass)v).i;
    }
}

class SortDemo
{
    public static void Main()
    {
        MyClass[] nums = new MyClass[5];
        nums[0] = new MyClass(5);
        nums[1] = new MyClass(2);
        nums[2] = new MyClass(3);
        nums[3] = new MyClass(4);
        nums[4] = new MyClass(1);
        // Отображаем исходный порядок следования элементов
        // в массиве.
        Console.Write("Исходный порядок; ");
        foreach (MyClass o in nums)
            Console.Write(o.i + " ");
        Console.WriteLine();
        // Сортируем массив.
        Array.Sort(nums);
        // Отображаем отсортированный массив.
        Console.Write("Порядок после сортировки: ");
        foreach (MyClass o in nums)
            Console.Write(o.i + " ");
        Console.WriteLine();
        // Поиск объекта MyClass(2).
        MyClass x = new MyClass(2);
        int idx = Array.BinarySearch(nums, x);
        Console.WriteLine("Индекс объекта MyClass(2) равен " + idx);
    }
}
