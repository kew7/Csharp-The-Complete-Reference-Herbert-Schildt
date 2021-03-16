// Демонстрация использования директивы #else.
#define EXPERIMENTAL
using System;
class Test
{
    public static void Main()
    {
#if EXPERIMENTAL
        Console.WriteLine("Компилируется для экспериментальной версии.");
#else
Console.WriteLine("Компилируется для бета-версии.");
#endif

#if EXPERIMENTAL && TRIAL
Console.Error.WriteLine("Тестирование экспериментальной пробной версии.");
#else
        Console.Error.WriteLine("Это не экспериментальная пробная версия.");
#endif

        Console.WriteLine("Эта информация отображается во всех версиях.");
    }
}
