// Создание собственных средств управления списком событий.
using System;
// Объявляем делегат для события.
delegate void MyEventHandler();

// Объявляем класс события для хранения трех
// обработчиков событий.
class MyEvent
{
    MyEventHandler[] evnt = new MyEventHandler[3];
    public event MyEventHandler SomeEvent
    {
        // Добавляем обработчик события в список.
        add
        {
            int i;
            for (i = 0; i < 3; i++)
                if (evnt[i] == null)
                {
                    evnt[i] = value;
                    break;
                }
            if (i == 3)
                Console.WriteLine(
                "Список обработчиков событий полон.");
        }
        // Удаляем обработчик события из списка.
        remove
        {
            int i;
            for (i = 0; i < 3; i++)
                if (evnt[i] == value)
                {
                    evnt[i] = null;
                    break;
                }
            if (i == 3)
                Console.WriteLine("Обработчик события не найден.");
        }
    }
    // Этот метод вызывается для генерирования событий.
    public void OnSomeEvent()
    {
        for (int i = 0; i < 3; i++)
            if (evnt[i] != null) evnt[i]();
    }
}
// Создаем классы, которые используют
// делегат MyEventHandler.
class W
{
    public void Whandler()
    {
        Console.WriteLine("Событие получено объектом W.");
    }
}
class X
{
    public void Xhandler()
    {
        Console.WriteLine("Событие получено объектом X.");
    }
}
class Y
{
    public void Yhandler()
    {
        Console.WriteLine("Событие получено объектом Y.");
    }
}
class Z
{
    public void Zhandler()
    {
        Console.WriteLine("Событие получено объектом Z.");
    }
}
class EventDemo
{
    public static void Main()
    {
        MyEvent evt = new MyEvent();
        W wOb = new W();
        X xOb = new X();
        Y yOb = new Y();
        Z zOb = new Z();
        // Добавляем обработчики в список.
        Console.WriteLine("Добавление обработчиков событий.");
        evt.SomeEvent += new MyEventHandler(wOb.Whandler);
        evt.SomeEvent += new MyEventHandler(xOb.Xhandler);
        evt.SomeEvent += new MyEventHandler(yOb.Yhandler);
        // Этот обработчик сохранить нельзя — список полон.
        evt.SomeEvent += new MyEventHandler(zOb.Zhandler);
        Console.WriteLine();
        // Генерируем события.
        evt.OnSomeEvent();
        Console.WriteLine();

        // Удаляем обработчик из списка.
        Console.WriteLine("Удаляем обработчик xOb.Xhandler.");
        evt.SomeEvent -= new MyEventHandler(xOb.Xhandler);
        evt.OnSomeEvent();
        Console.WriteLine();
        // Пытаемся удалить его еще раз.
        Console.WriteLine("Попытка повторно удалить обработчик xOb.Xhandler.");
        evt.SomeEvent -= new MyEventHandler(xOb.Xhandler);
        evt.OnSomeEvent();
        Console.WriteLine();
        // Теперь добавляем обработчик Zhandler.
        Console.WriteLine("Добавляем обработчик zOb.Zhandler.");
        evt.SomeEvent += new MyEventHandler(zOb.Zhandler);
        evt.OnSomeEvent();
    }
}