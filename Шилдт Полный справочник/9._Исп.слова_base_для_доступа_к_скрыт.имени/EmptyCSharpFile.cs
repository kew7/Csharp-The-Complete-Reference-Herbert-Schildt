// Вызов скрытого метода.
using System;
class A
{
	public int i = 0;
	// Метод show() в классе А.
	public void show()
	{
		Console.WriteLine("i в базовом классе: " + i);
	}
}

// Создаем производный класс.
class B : A
{
	new int i; // Эта переменная i скрывает
			   // одноименную переменную класса A.
	public B(int a, int b)
	{
		base.i = a; // Так можно обратиться к
					// переменной i класса А.
		i = b; // Переменная i в классе B.
	}
	// Этот метод скрывает метод show(), определенный в
	// классе А. Обратите внимание на использование
	// ключевого слова new.
	new public void show()
	{
		base.show(); // Вызов метода show() класса А.
					 // Отображаем значение переменной i класса B.
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
