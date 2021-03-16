﻿// Демонстрация использования класса BitArray.
using System;
using System.Collections;

class BADemo
{
    public static void showbits(string rem, BitArray bits)
    {
        Console.WriteLine(rem);
        for (int i = 0; i < bits.Count; i++)
            Console.Write("{0, -6}", bits[i]);
        Console.WriteLine("\n");
    }
    public static void Main()
    {
        BitArray ba = new BitArray(8);
        byte[] b = { 67 };
        BitArray ba2 = new BitArray(b);
        showbits("Исходное содержимое битовой коллекции ba:", ba);
        ba = ba.Not();
        showbits("Содержимое коллекции ba после вызова метода Not():", ba);
        showbits("Содержимое коллекции ba2:", ba2);
        BitArray ba3 = ba.Xor(ba2);
        showbits("Результат операции ba XOR ba2:", ba3);
    }
}
