// Демонстрация использования readonly-поля.
using System;
class MyClass
{
    public static readonly int SIZE = 10;
}

class DemoReadOnly
{
    public static void Main()
    {
        int[] nums = new int[MyClass.SIZE];
        for (int i = 0; i < MyClass.SIZE; i++)
            nums[i] = i;
        foreach (int i in nums)
            Console.Write(i + " ");
        // MyClass.SIZE = 100; // Ошибка!!! readonly-поле
        // изменять нельзя!
    }
}