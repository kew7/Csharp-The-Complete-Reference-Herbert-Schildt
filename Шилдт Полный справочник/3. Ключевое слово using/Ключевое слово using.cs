// Демонстрация использования пространства имен.
/*Эта программа иллюстрирует один важный момент: использование одного
пространства имен не аннулирует другое. При объявлении действующим некоторого
пространства имен его имя просто добавляется к именам других, которые действуют в
данный момент. Следовательно, в этой программе действуют пространства имен System и
Counter.*/

using System;

// Делаем текущим пространство имен Counter.
using Counter;

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
class NSDemo
{
    public static void Main()
    {
        // Теперь класс CountDown можно использовать
        // без указания имени пространства имен.
        CountDown cd1 = new CountDown(10);
        int i;
        do
        {
            i = cd1.count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
        CountDown cd2 = new CountDown(20);
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