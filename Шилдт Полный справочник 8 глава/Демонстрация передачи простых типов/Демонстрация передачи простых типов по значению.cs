// Демонстрация передачи простых типов по значению.
using System;
class Test
{
    /* Этот метод не оказывает влияния на аргументы,
    используемые в его вызове. */
    public void noChange(int i, int j)
    {
        i = i + j;
        j = -j;
    }
}
class CallByValue
{
    public static void Main()
    {
        Test ob = new Test();
        int a = 15, b = 20;
        Console.WriteLine("а и b перед вызовом: " + a + " " + b);
        ob.noChange(a, b);
        Console.WriteLine("а и b после вызова: " + a + " " + b);
    }
}