// Перегрузка операторов true и false для класса ThreeD.
using System;
// Класс трехмерных координат.
class ThreeD
{
    int x, y, z; // 3-х-мерные координаты.
    public ThreeD()
    {
        x = y = z = 0;
    }
    public ThreeD(int i, int j, int k)
    {
        x = i;
        y = j;
        z = k;
    }
    // Перегружаем оператор true.
    public static bool operator true(ThreeD op)
    {
        if ((op.x != 0) || (op.y != 0) || (op.z != 0))
            return true; // Хотя бы одна координата не равна 0.
        else
            return false;
    }
    // Перегружаем оператор false.
    public static bool operator false(ThreeD op)
    {
        if ((op.x == 0) && (op.y == 0) && (op.z == 0))
            return true; // Все координаты равны нулю.
        else
            return false;
    }
    // Перегружаем унарный оператор "--".
    public static ThreeD operator --(ThreeD op)
    {
        op.x--;
        op.y--;
        op.z--;
        return op;
    }
    // Отображаем координаты X, Y, Z.
    public void show()
    {
        Console.WriteLine(x + ", " + y + ", " + z);
    }
}
class TrueFalseDemo
{
    public static void Main()
    {
        ThreeD a = new ThreeD(5, 6, 7);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD(0, 0, 0);
        Console.Write("Координаты точки a: ");
        a.show();
        Console.Write("Координаты точки b: ");
        b.show();
        Console.Write("Координаты точки c: ");
        c.show();
        Console.WriteLine();
        if (a) Console.WriteLine("a - это ИСТИНА.");
        else Console.WriteLine("a - это ЛОЖЬ.");
        if (b) Console.WriteLine("b - это ИСТИНА.");
        else Console.WriteLine("b - это ЛОЖЬ.");
        if (c) Console.WriteLine("с - это ИСТИНА.");
        else Console.WriteLine("с - это ЛОЖЬ.");
        Console.WriteLine();
        Console.WriteLine(
        "Управляем циклом, используя объект класса ThreeD.");
        do
        {
            b.show();
            b--;
        } while (b);
    }
}