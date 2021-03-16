// Использование инструкции lock для синхронизации
// доступа к объекту.
using System;
using System.Threading;

class SumArray
{
    int sum;
    public int sumIt(int[] nums)
    {
        lock (this)
        { // Блокировка всего метода.
            sum = 0; // Начальное значение суммы.
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                Console.WriteLine(
                "Промежуточная сумма для потока " + Thread.CurrentThread.Name + " равна " + sum);
                Thread.Sleep(10); // Разрешено переключение задач.
            }
            return sum;
        }
    }
}

class MyThread
{
    public Thread thrd;
    int[] a;
    int answer;
    /* Создаем один объект класса SumArray для всех
    экземпляров класса MyThread. */
    static SumArray sa = new SumArray();
    // Создаем новый поток.
    public MyThread(string name, int[] nums)
    {
        a = nums;
        thrd = new Thread(new ThreadStart(this.run));
        thrd.Name = name;
        thrd.Start(); // Запускаем поток на выполнение.
    }
    // Начало выполнения нового потока.
    void run()
    {
        Console.WriteLine(thrd.Name + " стартовал.");
        answer = sa.sumIt(a);
        Console.WriteLine("Сумма для потока " + thrd.Name + " равна " + answer);
        Console.WriteLine(thrd.Name + " завершен.");
    }
}

class Sync
{
    public static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        MyThread mt1 = new MyThread("Потомок #1", a);
        MyThread mt2 = new MyThread("Потомок #2", a);
        mt1.thrd.Join();
        mt2.thrd.Join();
    }
}
