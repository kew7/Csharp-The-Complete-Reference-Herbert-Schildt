/*
При работе с перегруженными конструкторами иногда необходимо обеспечить вызов
одного конструктора из другого. В C# это реализуется с помощью еще одной формы
ключевого слова this.
 */

// Демонстрация вызова конструктора с помощью ссылки this.
namespace Overload_trough_This
{
    using System;
    class XYCoord
    {
        public int x, y;
        public XYCoord() : this(0, 0)
        {
            Console.WriteLine("Внутри конструктора XYCoord()");
        }
        public XYCoord(XYCoord obj) : this(obj.x, obj.y)
        {
            Console.WriteLine("Внутри конструктора XYCoord(obj)");
        }
        public XYCoord(int i, int j)
        {
            Console.WriteLine("Внутри конструктора XYCoord(int, int)");
            x = i;
            y = j;
        }
    }
    class OverloadConsDemo
    {
        public static void Main()
        {
            XYCoord t1 = new XYCoord();
            XYCoord t2 = new XYCoord(8, 9);
            XYCoord t3 = new XYCoord(t2);
            Console.WriteLine("t1.x, t1.y: " + t1.x + ", " + t1.y);
            Console.WriteLine("t2.x, t2.y: " + t2.x + ", " + t2.y);
            Console.WriteLine("t3.x, t3.y: " + t3.x + ", " + t3.y);
        }
    }
}