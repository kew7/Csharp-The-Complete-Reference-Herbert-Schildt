// Простые часы.
using System;
class SimpleClock
{
    public static void Main()
    {
        string t;
        int seconds;
        DateTime dt = DateTime.Now;
        seconds = dt.Second;
        for (; ; )
        {
            dt = DateTime.Now;
            // Обновляем время при изменении значения
            // переменной seconds.
            if (seconds != dt.Second)
            {
                seconds = dt.Second;
                t = dt.ToString("T");
                if (dt.Minute == 0 && dt.Second == 0)
                    t = t + "\a"; // Обеспечиваем звуковой сигнал
                                  // в начале каждого часа.
                Console.WriteLine(t);
            }
        }
    }
}
