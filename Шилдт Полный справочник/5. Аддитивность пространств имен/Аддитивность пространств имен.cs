// Демонстрация аддитивности пространств имен.
using System;

// Делаем "видимым" пространство имен Counter.
using Counter;

// Теперь действующим является первое пространство имен Counter.
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

// Теперь действующим является второе пространство имен Counter.
namespace Counter
{
    // Простой счетчик для счета в прямом направлении.
    class CountUp
    {
        int val;
        int target;
        public int Target
        {
            get
            {
                return target;
            }
        }
        public CountUp(int n)
        {
            target = n;
            val = 0;
        }
        public void reset(int n)
        {
            target = n;
            val = 0;
        }
        public int count()
        {
            if (val < target) return val++;
            else return target;
        }
    }
}
class NSDemo
{
    public static void Main() {
        CountDown cd = new CountDown(10);
        CountUp cu = new CountUp(8);
        int i;
        do
        {
            i = cd.count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
        do
        {
            i = cu.count();
            Console.Write(i + " ");
        } while (i < cu.Target);
        Console.WriteLine();
    }
}