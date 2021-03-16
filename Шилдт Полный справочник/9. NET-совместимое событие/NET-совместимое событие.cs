﻿// А .NET-совместимое событие.

using System;

// Создаем класс, производный от класса EventArgs.
class MyEventArgs : EventArgs
{
    public int eventnum;
}

// Объявляем делегат для события.
delegate void MyEventHandler(object source, MyEventArgs arg);

// Объявляем класс события.
class MyEvent
{
    static int count = 0;
    public event MyEventHandler SomeEvent;
    // Этот метод генерирует SomeEvent-событие.
    public void OnSomeEvent()
    {
        MyEventArgs arg = new MyEventArgs();
        if (SomeEvent != null) {
            arg.eventnum = count++;
            SomeEvent(this, arg);
        }
    }
}

class X
{
    public void handler(object source, MyEventArgs arg)
    {
        Console.WriteLine("Событие " + arg.eventnum +
        " получено объектом X.");
        Console.WriteLine("Источником является класс " +
        source + ".");
        Console.WriteLine();
    }
}

class Y
{
    public void handler(object source, MyEventArgs arg)
    {
        Console.WriteLine("Событие " + arg.eventnum +
        " получено объектом Y.");
        Console.WriteLine("Источником является класс " +
        source + ".");
        Console.WriteLine();
    }
}

class EventDemo
{
    public static void Main()
    {
        X ob1 = new X();
        Y ob2 = new Y();
        MyEvent evt = new MyEvent();
        // Добавляем обработчик handler() в список событий.
        evt.SomeEvent += new MyEventHandler(ob1.handler);
        evt.SomeEvent += new MyEventHandler(ob2.handler);
        // Генерируем событие.
        evt.OnSomeEvent();
        evt.OnSomeEvent();
    }
}