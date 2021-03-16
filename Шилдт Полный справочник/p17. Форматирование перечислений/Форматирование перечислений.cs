// Форматирование перечисления.
using System;
class EnumFmtDemo
{
    enum Direction { Север, Юг, Восток, Запад }
    [Flags]
    enum Status
    {
        Готов = 0x1, Автономный_режим = 0x2,
        Ожидание = 0x4, Данные_переданы = 0x8,
        Данные_получены = 0x10,
        Системный_режим = 0x20
    }
    public static void Main()
    {
        Direction d = Direction.Запад;
        Console.WriteLine("{0:G}", d);
        Console.WriteLine("{0:F}", d);
        Console.WriteLine("{0:D}", d);
        Console.WriteLine("{0:X}", d);
        Status s = Status.Готов | Status.Данные_переданы;
        Console.WriteLine("{0:G}", s);
        Console.WriteLine("{0:F}", s);
        Console.WriteLine("{0:D}", s);
        Console.WriteLine("{0:X}", s);
    }
}
