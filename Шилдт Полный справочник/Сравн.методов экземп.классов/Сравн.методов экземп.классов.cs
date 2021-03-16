/* При использовании в качестве обработчиков событий
методов экземпляров уведомление о событиях принимают
отдельные объекты. */

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
    int id;
    public X(int x) { id = x; }
    // Метод экземпляра, используемый в качестве
    // обработчика событий.
    public void Xhandler()
    {
        Console.WriteLine("Событие принято объектом " + id);
    }
}

class EventDemo
{
    public static void Main()
    {
        MyEvent evt = new MyEvent();
        X o1 = new X(1);
        X o2 = new X(2);
        X o3 = new X(3);
        evt.SomeEvent += new MyEventHandler(o1.Xhandler);
        evt.SomeEvent += new MyEventHandler(o2.Xhandler);
        evt.SomeEvent += new MyEventHandler(o3.Xhandler);
        // Генерируем событие.
        evt.OnSomeEvent();
    }
}