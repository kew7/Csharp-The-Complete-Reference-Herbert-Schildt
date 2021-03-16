// Пример сокрытия имени в связи с наследованием.
using System;
class A
{
    public int i = 0;
}
// Создаем производный класс.
class В : A
{
    new int i; // Этот член i скрывает член i класса A.
    public В(int b)
    {
        i = b; // Член i в классе В.
    }
    public void show()
    {
        Console.WriteLine(
        "Член i в производном классе: " + i);
    }
}
class NameHiding
{
    public static void Main()
    {
        В ob = new В(2);
        ob.show();
    }
}