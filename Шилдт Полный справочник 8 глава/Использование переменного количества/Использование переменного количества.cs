// Демонстрация использования модификатора params.
// Использование переменного количества аргументов 
using System;
class Min
{
    public int minVal(params int[] nums)
    {
        int m;
        if (nums.Length == 0)
        {
            Console.WriteLine("Ошибка: нет аргументов.");
            return 0;
        }
        m = nums[0];
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] < m) m = nums[i];
        return m;
    }
}
class ParamsDemo {
    public static void Main() {
        Min ob = new Min();
        int min;
        int a = 10, b = 20;
        // Вызываем метод с двумя значениями.
        min = ob.minVal(a, b);
        Console.WriteLine("Минимум равен " + min);

        // call with 3 values
        min = ob.minVal(a, b, -1);
        Console.WriteLine("Минимум равен " + min);

        // Вызываем метод с пятью значениями.
        min = ob.minVal(18, 23, 3, 14, 25);
        Console.WriteLine("Минимум равен " + min);

        // Этот метод можно также вызвать с int-массивом.
        int[] args = { 45, 67, 34, 9, 112, 8 };
        min = ob.minVal(args);
        Console.WriteLine("Минимум равен " + min);
    }
}