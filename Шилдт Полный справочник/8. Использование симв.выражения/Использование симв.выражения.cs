// Использование символьного выражения.
#define EXPERIMENTAL
#define TRIAL
using System;
class Test
{
    public static void Main()
    {
#if EXPERIMENTAL
        Console.WriteLine("Компилируется для экспериментальной версии.");
#endif
#if EXPERIMENTAL && TRIAL
        Console.Error.WriteLine("Тестирование экспериментальной пробной версии.");
#endif
        Console.WriteLine("Эта информация отображается во всех версиях.");
    }
}

