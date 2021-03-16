// Еще один пример использования метода Format().
using System;
class FormatDemo2
{
    public static void Main()
    {
        int i;
        int sum = 0;
        int prod = 1;
        string str;
        /* Отображаем текущие значения суммы и
        произведения чисел от 1 до 10. */
        for (i = 1; i <= 10; i++)
        {
            sum += i;
            prod *= i;
            str = String.Format(
            "Сумма:{0,3:D} Произведение:{1,8:D}", sum, prod);
            Console.WriteLine(str);
        }
    }
}
