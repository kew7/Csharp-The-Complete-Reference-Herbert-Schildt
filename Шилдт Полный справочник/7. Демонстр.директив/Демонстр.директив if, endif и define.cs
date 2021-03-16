// Демонстрация использования директив #if, #endif и #define.
#define EXPERIMENTAL
using System;
class Test
{
    public static void Main()
    {
#if EXPERIMENTAL
        Console.WriteLine("Компилируется для экспериментальной версии.");
#endif
        Console.WriteLine("Эта информация отображается во всех версиях.");
    }
}
