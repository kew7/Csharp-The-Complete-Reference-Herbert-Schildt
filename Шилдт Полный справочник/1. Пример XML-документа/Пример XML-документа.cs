// Пример XML-документа.
using System;
/// <remark>
/// Это пример XML-документа.
/// В классе Test показано использование ряда тегов.
/// </remark>
class Test
{
    /// <summary>
    /// Выполнение начинается с метода Main().
    /// </summary>
    public static void Main()
    {
        int sum;
        sum = Summation(5);
        Console.WriteLine("Сумма последовательных " + 5 +
        " чисел равна " + sum);
    }
    /// <summary>
    /// Метод Summation() возвращает сумму ряда чисел.
    /// <param name = "val">
    /// Последнее слагаемое передается в параметре val.
    /// </param>
    /// <see cref="int"> </see>
    /// <returns>
    /// Результат возвращается как int-значение.
    /// </returns>
    /// </summary>
    static int Summation(int val)
    {
        int result = 0;
        for (int i = 1; i <= val; i++)
            result += i;
        return result;
    }
}
