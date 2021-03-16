// Считывание символа с клавиатуры.
using System;
class KbIn
{
    public static void Main()
    {
        char ch;
        Console.Write("Нажмите любую клавишу, а затем -- <ENTER>: ");
        ch = (char)Console.Read(); // Считывание
                                   // char-значения.
        Console.WriteLine("Вы нажали клавишу: " + ch);
    }
}