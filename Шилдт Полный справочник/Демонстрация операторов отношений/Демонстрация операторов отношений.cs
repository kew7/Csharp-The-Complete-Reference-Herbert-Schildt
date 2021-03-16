// Демонстрация использования операторов отношений
// и логических операторов.
using System;
class RelLogOps
{
    public static void Main()
    {
        int i, j;
        bool b1, b2;
        i = 10;
        j = 11;
        if (i < j) Console.WriteLine("i < j");
        if (i <= j) Console.WriteLine("i <= j");
        if (i != j) Console.WriteLine("i != j");
        if (i == j) Console.WriteLine("Это не будет выполнено.");
        if (i > j) Console.WriteLine("Это не будет выполнено.");
        b1 = true;
        b2 = false;
        if (b1 & b2) Console.WriteLine("Это не будет выполнено.");
        if (!(b1 & b2)) Console.WriteLine("! (b1 & b2) -- ИСТИНА");
        if (b1 | b2) Console.WriteLine("b1 | b2 -- ИСТИНА");
        if (b1 ^ b2) Console.WriteLine("b1 ^ b2 -- ИСТИНА");
    }
}