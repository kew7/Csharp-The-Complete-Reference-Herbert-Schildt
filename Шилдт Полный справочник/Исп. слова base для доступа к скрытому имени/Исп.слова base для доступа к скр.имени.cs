﻿/*Существует вторая форма использования ключевого слова base, которая действует
подобно ссылке this, за исключением того, что ссылка base всегда указывает на базовый
класс производного класса, в котором она используется.*/

// Использование ссылки base для доступа к скрытому имени.
using System;
class A
{
    public int i = 0;
}

// Создаем производный класс.
class B : A
{
    new int i; // Эта переменная i скрывает i класса А.
    public B(int a, int b)
    {
        base.i = a; // Так можно обратиться к i класса А.
        i = b; // Переменная i в классе B.
    }
    public void show()
    {
        // Эта инструкция отображает переменную i в классе А.
        Console.WriteLine("i в базовом классе: " + base.i);
        // Эта инструкция отображает переменную i в классе В.
        Console.WriteLine("i в производном классе: " + i);
    }
}

class UncoverName
{
    public static void Main()
    {
        B ob = new B(1, 2);
        ob.show();
    }
}