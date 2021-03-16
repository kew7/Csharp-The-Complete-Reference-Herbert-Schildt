// Использование метода ResetAbort().
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
            try
            {
                Console.Write(i + " ");
                if ((i % 10) == 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(250);
                }
            }
            catch (ThreadAbortException exc)
            {
                if ((int)exc.ExceptionState == 0)
                {
                    Console.WriteLine("Прерывание отменено! Код завершения = "
                                        + exc.ExceptionState);
                    Thread.ResetAbort();
                }
                else
                    Console.WriteLine("Выполнение потока прервано, код завершения = "
                                        + exc.ExceptionState);
            }
        }
        Console.WriteLine(thrd.Name + " завершился нормально.");
    }
}

class ResetAbort
{
    public static void Main()
    {
        MyThread mt1 = new MyThread("Мой поток");
        Thread.Sleep(1000); // Разрешаем стартовать
                            // дочернему потоку.
        Console.WriteLine("Прерывание выполнения потока.");
        mt1.thrd.Abort(0); // Это не остановит выполнение
                           // потока.
        Thread.Sleep(1000); // Разрешаем дочернему потоку
                            // поработать немного дольше.
        Console.WriteLine("Прерывание выполнения потока.");
        mt1.thrd.Abort(100); // Эта инструкция в состоянии
                             // остановить выполнение потока.
        mt1.thrd.Join(); // Ожидаем завершения
                         // выполнения потока.
        Console.WriteLine("Основной поток завершен.");
    }
}
