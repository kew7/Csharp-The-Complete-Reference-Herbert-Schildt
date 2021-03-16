// Демонстрация использования псевдоимени.
using System;

// Создаем псевдоимя для класса Counter.CountDown.
using Count = Counter.CountDown;

// Объявляем пространство имен для счетчиков.
namespace Counter
{
    // Простой счетчик для счета в обратном направлении.
    class CountDown
    {
        int val;
        public CountDown(int n)
        {
            val = n;
        }
        public void reset(int n) {
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
        // Здесь Count используется в качестве имени вместо Counter.CountDown.
        Count cd1 = new Count(10);
        int i;
        do
        {
            i = cd1.count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
        Count cd2 = new Count(20);
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