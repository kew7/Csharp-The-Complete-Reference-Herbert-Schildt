//Приостановка, возобновление и завершение потока.
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
        Console.WriteLine(thrd.Name + " завершен.");
    }
}
class SuspendResumeStop
{
    [Obsolete]
    public static void Main()
    {
        MyThread mt1 = new MyThread("Мой поток");
        Thread.Sleep(1000); // Разрешаем стартовать
                            // дочернему потоку.
        mt1.thrd.Suspend();
        Console.WriteLine("Приостановка выполнения потока.");
        Thread.Sleep(1000);
        mt1.thrd.Resume();
        Console.WriteLine("Возобновление выполнения потока.");
        Thread.Sleep(1000);
        mt1.thrd.Suspend();
        Console.WriteLine("Приостановка выполнения потока.");
        Thread.Sleep(1000);
        mt1.thrd.Resume();
        Console.WriteLine("Возобновление выполнения потока.");
        Thread.Sleep(1000);
        Console.WriteLine("Завершение выполнения потока.");
        mt1.thrd.Abort();
        mt1.thrd.Join(); // Ожидаем завершения выполнения потока.
        Console.WriteLine("Основной поток завершен.");
    }
}