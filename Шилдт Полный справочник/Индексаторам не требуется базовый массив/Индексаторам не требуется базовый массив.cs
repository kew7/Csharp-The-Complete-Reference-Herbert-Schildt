// Индексаторы не обязательно должны использовать
// реальные массивы.
using System;
class PwrOfTwo
{
    /* Доступ к логическому массиву, который содержит
    степени числа 2 для чисел от 0 до 15. */
    public int this[int index]
    {
        // Вычисляем и возвращаем степень числа 2.
        get
        {
            if ((index >= 0) && (index < 16))
                return pwr(index);
            else return -1;
        }
        // Здесь нет set-аксессора.
    }
    int pwr(int p)
    {
        int result = 1;
        for (int i = 0; i < p; i++)
            result *= 2;
        return result;
    }
}
class UsePwrOfTwo
{
    public static void Main()
    {
        PwrOfTwo pwr = new PwrOfTwo();
        Console.Write("Первые 8 степеней числа 2: ");
        for (int i = 0; i < 8; i++)
            Console.Write(pwr[i] + " ");
        Console.WriteLine();
        Console.Write("А вот несколько ошибок: ");
        Console.Write(pwr[-1] + " " + pwr[17]);
        Console.WriteLine();
    }
}