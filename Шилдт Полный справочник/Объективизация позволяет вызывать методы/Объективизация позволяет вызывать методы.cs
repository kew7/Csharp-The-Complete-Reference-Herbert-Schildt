// "Объективизация" позволяет вызывать методы
// класса object для значений нессылочного типа!
using System;
class MethOnValue
{
    public static void Main()
    {
        Console.WriteLine(10.ToString());
    }
}