// Демонстрация использования атрибута Conditional.
#define TRIAL
using System;
using System.Diagnostics;
class Test
{
    [Conditional("TRIAL")]
    void trial()
    {
        Console.WriteLine(
        "Пробная версия, не для распространения.");
    }
    [Conditional("RELEASE")]
    void release()
    {
        Console.WriteLine("Окончательная версия.");
    }
    public static void Main()
    {
        Test t = new Test();
        t.trial(); // Вызывается только в случае, если
                   // идентификатор TRIAL определен.
        t.release(); // Вызывается только в случае, если
                     // идентификатор RELEASE определен.
    }
}
