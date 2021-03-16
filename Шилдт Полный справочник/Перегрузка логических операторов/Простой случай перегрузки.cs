// Простой способ перегрузки операторов !, | и &
// для класса ThreeD.
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
    // Перегрузка оператора "|".
    public static bool operator |(ThreeD op1, ThreeD op2)
    {
        if (((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) |
        ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)))
            return true;
        else
            return false;
    }
    // Перегрузка оператора "&".
    public static bool operator &(ThreeD op1, ThreeD op2)
    {
        if (((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
        ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))
            return true;
        else
            return false;
    }
    // Перегрузка оператора "!".
    public static bool operator !(ThreeD op)
    {
        if ((op.x != 0) || (op.y != 0) || (op.z != 0))
            return false;
                else return true;
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
        ThreeD a = new ThreeD(5, 0, 7);
        ThreeD b = new ThreeD(10, 0, 10);
        ThreeD c = new ThreeD(0, 0, 0);
        Console.Write("Координаты точки a: ");
        a.show();
        Console.Write("Координаты точки b: ");
        b.show();
        Console.Write("Координаты точки c: ");
        c.show();
        Console.WriteLine();
        if (!a) Console.WriteLine("a - ЛОЖЬ.");
        if (!b) Console.WriteLine("b - ЛОЖЬ.");
        if (!c) Console.WriteLine("с - ложь.");
        Console.WriteLine();
        if (a & b) Console.WriteLine("a & b - ИСТИНА.");
        else Console.WriteLine("a & b - ЛОЖЬ.");
        if (a & c) Console.WriteLine("a & с - ИСТИНА.");
        else Console.WriteLine("a & с - ЛОЖЬ.");
        if (a | b) Console.WriteLine("a | b - ИСТИНА.");
        else Console.WriteLine("a | b - ЛОЖЬ.");
        if (a | c) Console.WriteLine("a | с - ИСТИНА.");
        else Console.WriteLine("a | с - ЛОЖЬ.");
    }
}