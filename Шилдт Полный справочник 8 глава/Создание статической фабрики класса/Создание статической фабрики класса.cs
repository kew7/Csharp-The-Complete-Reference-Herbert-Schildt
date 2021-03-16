
// Создание статической "фабрики" класса.
using System;
class MyClass
{
    int a, b;
    // Создаем "фабрику" для класса MyClass.
    static public MyClass factory(int i, int j)
    {
        MyClass t = new MyClass();
        t.a = i;
        t.b = j;
        return t; // Метод возвращает объект.
    }
    public void show()
    {
        Console.WriteLine("а и b: " + a + " " + b);
    }
}

class MakeObjects {
    public static void Main() {
        int i, j;
        // Генерируем объекты с помощью "фабрики" класса.
        for(i=0, j=10; i < 10; i++, j--) {
        MyClass ob = MyClass.factory(i, j); // Получение объекта.
        ob.show();
        }     
        Console.WriteLine();
    }
}
/*В этой версии программы метод factory() вызывается посредством указания
имени класса:
MyClass ob = MyClass.factory(i, j); // Получение объекта.
Этот пример показывает, что нет необходимости создавать объект класса MyClass
до использования “фабрики” класса.*/