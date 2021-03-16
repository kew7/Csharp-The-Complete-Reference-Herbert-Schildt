// Демонстрация использования деструктора.
using System;
class Destruct
{
    public int x;
    public Destruct(int i)
    {
        x = i;
    }
    // Вызывается при утилизации объекта.
    ~Destruct()
    {
        Console.WriteLine("Деструктуризация " + x);
    }
    // Метод создает объект, который немедленно // разрушается.
    public void generator(int i)
    {
        Destruct о = new Destruct(i);
    }
}
class DestructDemo
{
    public static void Main()
    {
        int count;
        Destruct ob = new Destruct(0);
        /* Теперь сгенерируем большое число объектов.
        В какой-то момент начнется сбор мусора.
        Замечание: возможно, для активизации этого
        процесса вам придется увеличить количество
        генерируемых объектов. */
        for (count = 1; count < 10; count++)
            ob.generator(count);
        Console.WriteLine("Готово!");
    }
}