// Демонстрация использования директивы #elif.
#define RELEASE
using System;
class Test
{
    public static void Main()
    {
#if EXPERIMENTAL
Console.WriteLine("Компилируется для экспериментальной версии.");
#elif RELEASE
        Console.WriteLine("Компилируется для бета-версии.");
#else
Console.WriteLine("Компилируется для внутреннего тестирования.");
#endif

#if TRIAL && !RELEASE
Console.WriteLine("Пробная версия.");
#endif
        Console.WriteLine("Эта информация отображается во всех версиях.");
    }
}
