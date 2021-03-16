// Обмен двух ссылок.
using System;
class RefSwap
{
    int a, b;
    public RefSwap(int i, int j)
    {
        a = i;
        b = j;
    }
    public void show()
    {
        Console.WriteLine("a: {0}, b: {1}", a, b);
    }
    // Этот метод теперь изменяет свои аргументы.
    public void swap(ref RefSwap ob1, ref RefSwap ob2)
    {
        RefSwap t;
        t = ob1;
        ob1 = ob2; ob2 = t;
    }
}
class RefSwapDemo
{
    public static void Main()
    {
        RefSwap x = new RefSwap(1, 2);
        RefSwap y = new RefSwap(3, 4);
        Console.Write("x перед вызовом: ");
        x.show();
        Console.Write("y перед вызовом: ");
        y.show();
        Console.WriteLine();
        // Обмениваем объекты, на которые ссылаются x и y.
        x.swap(ref x, ref y);
        Console.Write("x после вызова: ");
        x.show();
        Console.Write("y после вызова: ");
        y.show();
    }
}