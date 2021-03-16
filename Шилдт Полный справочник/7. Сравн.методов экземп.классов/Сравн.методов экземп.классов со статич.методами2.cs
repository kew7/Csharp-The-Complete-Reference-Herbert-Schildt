/* При использовании в качестве обработчиков событий статического
метода уведомление о событиях получает класс. */
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
    /* Это статический метод, используемый в качестве
    обработчика события. */
    public static void Xhandler()
    {
        Console.WriteLine("Событие получено классом.");
    }
}

class EventDemo
{
    public static void Main()
    {
        MyEvent evt = new MyEvent();
        evt.SomeEvent += new MyEventHandler(X.Xhandler);
        // Генерируем событие.
        evt.OnSomeEvent();
    }
}

