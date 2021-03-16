// Пространства имен предотвращают конфликты, связанные с совпадением имен.

using System;
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
// Объявляем еще одно пространство имен.
namespace Counter2
{
    /* Этот класс CountDown находится в пространстве
    имен Counter2 и не будет конфликтовать с одноименным
    классом, определенным в пространстве имен Counter. */
    class CountDown
    {
        public void count()
        {
            Console.WriteLine("Этот метод count() находится в" +
            " пространстве имен Counter2.");
        }
    }
}
class NSDemo
{
    public static void Main()
    {
        // Этот класс CountDown находится в
        // пространстве имен Counter.
        Counter.CountDown cd1 = new Counter.CountDown(10);
        // Этот класс CountDown находится в
        // пространстве имен Counter2.
        Counter2.CountDown cd2 = new Counter2.CountDown();
        int i;
        do
        {
            i = cd1.count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
        cd2.count();
    }
}