/* Более удачный способ реализации операторов !, | и &
для класса ThreeD. Эта версия автоматически делает
работоспособными операторы && и ||. */
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
    // Перегружаем оператор "|" для вычислений по
    // сокращенной схеме.
    public static ThreeD operator |(ThreeD op1, ThreeD op2)
    {
        if (((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) |
        ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)))
            return new ThreeD(1, 1, 1);
        else
            return new ThreeD(0, 0, 0);
    }
    // Перегружаем оператор "&" для вычислений по
    // сокращенной схеме.
    public static ThreeD operator &(ThreeD op1, ThreeD op2)
    {
        if (((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
        ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))
            return new ThreeD(1, 1, 1);
        else
            return new ThreeD(0, 0, 0);
    }
    // Перегружаем оператор "!".
    public static bool operator !(ThreeD op)
    {
        if (op) return false;
        else return true;
    }
    // Перегружаем оператор true.
    public static bool operator true(ThreeD op)
    {
        if ((op.x != 0) || (op.y != 0) || (op.z != 0))
            return true; // Хотя бы одна координата не
                         // равна нулю.
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
        if (a) Console.WriteLine("a - ИСТИНА.");
        if (b) Console.WriteLine("b - ИСТИНА.");
        if (c) Console.WriteLine("с - ИСТИНА.");
        if (!a) Console.WriteLine("a - ЛОЖЬ.");
        if (!b) Console.WriteLine("b - ЛОЖЬ.");
        if (!c) Console.WriteLine("с - ЛОЖЬ.");
        Console.WriteLine();
        Console.WriteLine("Используем операторы & и !");
        if (a & b) Console.WriteLine("a & b - ИСТИНА.");
        else Console.WriteLine("a & b - ЛОЖЬ.");
        if (a & c) Console.WriteLine("a & с - ИСТИНА.");
        else Console.WriteLine("a & с - ЛОЖЬ.");
        if (a | b) Console.WriteLine("a | b - ИСТИНА.");
        else Console.WriteLine("a | b - ЛОЖЬ.");
        if (a | c) Console.WriteLine("a | с - ИСТИНА.");
        else Console.WriteLine("a | с - ЛОЖЬ.");
        Console.WriteLine();

        // Теперь используем операторы &.& и ||, действующие
        // по сокращенной схеме вычислений.
        Console.WriteLine("Используем \"сокращенные\" операторы && и ||");

        // Первый операнд при && тестируется с помощью operator false класса Thread
        if (a && b) Console.WriteLine("а && b - ИСТИНА.");
        else Console.WriteLine("a && b - ЛОЖЬ.");
        if (a && c) Console.WriteLine("a && с - ИСТИНА.");
        else Console.WriteLine("a && с - ЛОЖЬ.");

        // Первый операнд при || тестируется с помощью operator true класса Thread
        if (a || b) Console.WriteLine("a || b - ИСТИНА.");
        else Console.WriteLine("a || b - ЛОЖЬ.");
        if (a || c) Console.WriteLine("a || c - ИСТИНА.");
        else Console.WriteLine("a || c - ЛОЖЬ.");
        Console.WriteLine();
    }
}