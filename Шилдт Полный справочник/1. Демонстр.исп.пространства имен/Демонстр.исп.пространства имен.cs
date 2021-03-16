// Демонстрация использования пространства имен.
using System;
// Объявляем пространство имен для счетчиков.
namespace Counter
{
    // Простой счетчик для счета в обратном направлении.
    class CountDown
    {
        int val;
        public CountDown(int n) { val = n; }
        public void reset(int n)
        {
            val = n;
        }
        public int count()
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
}

class NSDemo
{
    public static void Main()
    {
        Counter.CountDown cd1 = new Counter.CountDown(10);
        int i;
        do
        {
            i = cd1.count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        Counter.CountDown cd2 = new Counter.CountDown(20);
        do
        {
            i = cd2.count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        cd2.reset(4);
        do
        {
            i = cd2.count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
    }
}
