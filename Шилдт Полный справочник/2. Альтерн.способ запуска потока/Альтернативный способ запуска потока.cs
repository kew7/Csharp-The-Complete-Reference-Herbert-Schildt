/*Несмотря на то что предыдущая программа вполне работоспособна, несколько
простых усовершенствований сделают ее более эффективной. Во-первых, можно
организовать начало выполнения потока сразу после его создания. Для потока класса
MyThread это достижимо посредством создания объекта типа Thread внутри
конструктора класса MyThread. Во-вторых, не обязательно хранить имя потока в классе
MyThread, поскольку в классе Thread определено свойство Name, которое можно
использовать с этой целью. Свойство Name определено таким образом:
public string Name { get; set; }
Так как свойство Name предназначено для чтения и записи, его можно использовать
для запоминания имени потока или для его считывания.*/

// Альтернативный способ запуска потока.
using System;
using System.Threading;

class MyThread
{
    public int count;
    public Thread thrd;
    public MyThread(string name)
    {
        count = 0;
        thrd = new Thread(new ThreadStart(this.run));
        thrd.Name = name; // Устанавливаем имя потока.
        thrd.Start(); // Запускаем поток на выполнение.
    }
    // Входная точка потока.
    void run()
    {
        Console.WriteLine(thrd.Name + " стартовал.");
        do
        {
            Thread.Sleep(500);
            Console.WriteLine("В потоке " + thrd.Name + ", count = " + count);
            count++;
        } while (count < 10);
        Console.WriteLine(thrd.Name + " завершен.");
    }
}

class MultiThreadImproved {
    public static void Main()
    {
        Console.WriteLine("Основной поток стартовал.");
        // Сначала создаем объект класса MyThread.
        MyThread mt = new MyThread("Потомок #1");
        do
        {
            Console.Write(".");
            Thread.Sleep(10);
        } while (mt.count != 10);
        Console.WriteLine("Основной поток завершен.");
    }
}