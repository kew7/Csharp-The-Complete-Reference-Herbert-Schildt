// Создание decimal-значения "вручную".
using System;
class CreateDec
{
    public static void Main()
    {
        decimal d = new decimal(12345, 0, 0, false, 2);
        Console.WriteLine(d);
    }
}
