﻿/*Несмотря на то что здесь классы X и Y физически представляют собой одно и то же,
невозможно присвоить объект класса Y ссылочной переменной типа X, поскольку они
имеют разные типы.В общем случае ссылочная переменная может ссылаться только на
объекты своего типа.*/

// Эта программа не скомпилируется.
class X
{
    int a;
    public X(int i)
    {
        a = i;
    }
}
class Y
{
    int a;
    public Y(int i)
    {
        a = i;
    }
}
class IncompatibleRef
{
    public static void Main()
    {
        X x = new X(10);
        X x2;
        Y y = new Y(5);
        x2 = x; // OK, обе переменные имеют одинаковый тип.
       // x2 = y; // Ошибка, здесь переменные разного типа.
    }
}
