// Демонстрация использования атрибута Obsolete.
using System;
class Test
{
    [Obsolete("Лучше использовать метод myMeth2.")]
    static int myMeth(int a, int b)
    {
        return a / b;
    }
    // Улучшенная версия метода myMeth().
    static int myMeth2(int a, int b)
    {
        return b == 0 ? 0 : a / b;
    }
    public static void Main()
    {
        // Предупреждение, отображаемое при выполнении
        // этой инструкции.
        Console.WriteLine("4 / 3 is " + Test.myMeth(4, 3));
        // Здесь не будет никакого предупреждения.
        Console.WriteLine("4 / 3 is " + Test.myMeth2(4, 3));
    }
}
