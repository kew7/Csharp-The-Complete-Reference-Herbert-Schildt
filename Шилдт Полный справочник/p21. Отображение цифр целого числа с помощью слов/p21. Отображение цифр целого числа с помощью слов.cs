// Отображение цифр целого числа с помощью слов.
using System;
class ConvertDigitsToWords
{
    public static void Main()
    {
        int num;
        int nextdigit;
        int numdigits;
        int[] n = new int[20];
        string[] digits = { "нуль", "один", "два",
                            "три", "четыре", "пять",
                            "шесть", "семь", "восемь",
                            "девять" };
        num = 1908;
        Console.WriteLine("Число: " + num);
        Console.Write("Число в словах: ");
        nextdigit = 0; numdigits = 0;
        /* Получаем отдельные цифры и сохраняем их в массиве п.
        Эти цифры хранятся в обратном порядке. */
        do
        {
            nextdigit = num % 10;
            n[numdigits] = nextdigit;
            numdigits++;
            num = num / 10;
        }
        while (num > 0);
        numdigits--;
        // Отображаем слова.
        for (; numdigits >= 0; numdigits--)
            Console.Write(digits[n[numdigits]] + " ");
        Console.WriteLine();
    }
}