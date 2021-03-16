// Демонстрация использования события, предназначенного
// для многоадресатной передачи.

using System;

// Объявляем делегат для события.
delegate void MyEventHandler();

// Объявляем класс события.
class MyEvent
{
    public event MyEventHandler SomeEvent;
    // Этот метод вызывается для генерирования события.
    public void OnSomeEvent()
    {
        if (SomeEvent != null) SomeEvent();
    }
}
class X
{
    public void Xhandler()
    {
        Console.WriteLine("Событие, полученное объектом X.");
    }
}
class Y
{
    public void Yhandler()
    {
        Console.WriteLine("Событие, полученное объектом Y.");
    }
}

class EventDemo
{
    static void handler()
    {
        Console.WriteLine(
        "Событие, полученное классом EventDemo.");
    }

    public static void Main()
    {
        MyEvent evt = new MyEvent();
        X xOb = new X();
        Y yOb = new Y();
        // Добавляем обработчики в список события.
        evt.SomeEvent += new MyEventHandler(handler);
        evt.SomeEvent += new MyEventHandler(xOb.Xhandler);
        evt.SomeEvent += new MyEventHandler(yOb.Yhandler);

        // Генерируем событие.
        evt.OnSomeEvent();
        Console.WriteLine();

        // Удаляем один обработчик.
        evt.SomeEvent -= new MyEventHandler(xOb.Xhandler);
        evt.OnSomeEvent();
    }
}