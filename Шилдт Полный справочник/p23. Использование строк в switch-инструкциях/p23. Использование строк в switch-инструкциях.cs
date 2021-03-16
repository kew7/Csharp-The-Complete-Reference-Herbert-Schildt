// Демонстрация возможности строкового управления
// инструкцией switch.
using System;
class StringSwitch
{
    public static void Main()
    {
        string[] strs = { "один", "два", "три", "два", "один" };
        foreach (string s in strs)
        {
            switch (s)
            {
                case "один":
                    Console.Write(1);
                    break;
                case "два":
                    Console.Write(2);
                    break;
                case "три":
                    Console.Write(3);
                    break;
            }
        }
        Console.WriteLine();
    }
}