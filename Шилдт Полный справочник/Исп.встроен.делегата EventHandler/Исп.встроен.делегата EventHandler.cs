// Использование встроенного делегата EventHandler.
using System;

// Объявляем класс события.
class MyEvent
{
    public event EventHandler SomeEvent; // Объявление
                                         // использует делегат EventHandler.
                                         // Этот метод вызывается для генерирования
                                         // SomeEvent-событие.
    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent(this, EventArgs.Empty);
    }
}

class EventDemo
{
    static void handler(object source, EventArgs arg)
    {
        Console.WriteLine("Событие произошло.");
        Console.WriteLine("Источником является класс " +
        source + ".");
    }
    public static void Main()
    {
        MyEvent evt = new MyEvent();
        // Добавляем обработчик handler() в список событий.
        evt.SomeEvent += new EventHandler(handler);
        // Генерируем событие.
        evt.OnSomeEvent();
    }
}
