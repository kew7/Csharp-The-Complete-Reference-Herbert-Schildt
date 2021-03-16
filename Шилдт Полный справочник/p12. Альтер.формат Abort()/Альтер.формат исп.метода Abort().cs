// Использование метода Abort(object).
using System;
using System.Threading;
class MyThread
{
    public Thread thrd;
    public MyThread(string name)
    {
        thrd = new Thread(new ThreadStart(this.run));
        thrd.Name = name;
        thrd.Start();
    }
    // Это входная точка для потока.
    void run()
    {
        try
        {
            Console.WriteLine(thrd.Name + " стартовал.");
            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(i + " ");
                if ((i % 10) == 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(250);
                }
            }
            Console.WriteLine(thrd.Name + " завершился нормально.");
        }
        catch (ThreadAbortException exc)
        {
            Console.WriteLine("Выполнение потока прервано, код завершения = " + exc.ExceptionState);
        }
    }
}

class UseAltAbort
{
    public static void Main()
    {
        MyThread mt1 = new MyThread("Мой поток");
        Thread.Sleep(1000); // Разрешаем стартовать
                            // дочернему потоку.
        Console.WriteLine("Прерывание выполнения потока.");
        mt1.thrd.Abort(100);
        mt1.thrd.Join(); // Ожидаем завершения
                         // выполнения потока.
        Console.WriteLine("Основной поток завершен.");
    }
}
