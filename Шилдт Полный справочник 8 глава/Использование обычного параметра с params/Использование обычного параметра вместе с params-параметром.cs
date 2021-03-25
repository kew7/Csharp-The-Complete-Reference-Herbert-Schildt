// Использование обычного параметра вместе
// с params-параметром.
using System;
class MyClass
{
    public void showArgs(string msg, params int[] nums)
    {
        Console.Write(msg + ": ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}

class ParamsDemo2
{
    public static void Main()
    {
        MyClass ob = new MyClass();
        ob.showArgs("Вот несколько целых чисел",
        1, 2, 3, 4, 5);
        ob.showArgs("А вот еще два числа",
        17, 20);
    }
}