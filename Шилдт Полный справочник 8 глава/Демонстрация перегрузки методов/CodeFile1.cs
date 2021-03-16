/*В C# два или больше методов внутри одного класса могут иметь одинаковое имя, 
  но при условии, что их параметры будут различными. Такую ситуацию называют
  перегрузкой методов (method overloading), а методы, которые в ней задействованы,
  — перегруженными (overloaded). Перегрузка методов — один из способов реализации полиморфизма в C#.*/

// Демонстрация перегрузки методов.
using System;
class Overload {
public void ovlDemo() {
Console.WriteLine("Без параметров");
}
    // Перегружаем метод ovlDemo() для одного
    // целочисленного параметра.
    public void ovlDemo(int a) {
    Console.WriteLine("Один параметр: " + a);
    }
    // Перегружаем метод ovlDemo() для двух
    // целочисленных параметров.
    public int ovlDemo(int a, int b) {
    Console.WriteLine("Два int-параметра: " + a + " " + b);
    return a + b;
}
    // Перегружаем метод ovlDemo() для двух
    // double-параметров.
    public double ovlDemo(double a, double b)
    {
        Console.WriteLine("Два double-параметра: " +
        a + " " + b);
        return a + b;
    }
}
class OverloadDemo
{
    public static void Main()
    {
        Overload ob = new Overload();
        int resI;
        double resD;
        // Вызываем все версии метода ovlDemo().
        ob.ovlDemo();
        Console.WriteLine();
        ob.ovlDemo(2);
        Console.WriteLine();
        resI = ob.ovlDemo(4, 6);
        Console.WriteLine("Результат вызова ob.ovlDemo(4, 6): "
        + resI);
        Console.WriteLine();
        resD = ob.ovlDemo(1.1, 2.32);
        Console.WriteLine(
        "Результат вызова ob.ovlDemo(1.1, 2.2): " + resD);
    }
}