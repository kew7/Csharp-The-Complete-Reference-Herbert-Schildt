// Демонстрация использования простейшего события.
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

class EventDemo
{
    // Обработчик события.
    static void handler() {
        Console.WriteLine("Произошло событие.");
    }
    public static void Main()
    {
        MyEvent evt = new MyEvent();
        
        // Добавляем метод handler() в список события.
        evt.SomeEvent += new MyEventHandler(handler);
        // Генерируем событие.
        evt.OnSomeEvent();
    }
}