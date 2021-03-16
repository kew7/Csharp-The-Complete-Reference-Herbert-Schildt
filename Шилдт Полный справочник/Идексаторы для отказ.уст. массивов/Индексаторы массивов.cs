//Использование индексатора для создания
// отказоустойчивого массива.
using System;
class FailSoftArray
{
    int[] a; // Ссылка на массив.
    public int Length; // Length - открытый член.
    public bool errflag; // Индикатор результата
                         // последней операции.
   // Создаем массив заданного размера.
    public FailSoftArray(int size)
    {
        a = new int[size];
        Length = size;
    }
    // Это - индексатор для класса FailSoftArray.
    public int this[int index]
    { // Это - get-аксессор.
        get
        {
            if (ok(index))
            {
                errflag = false;
                return a[index];
            }
            else
            {
                errflag = true;
                return 0;
            }
        }
        // Это - set-аксессор.
        set
        {
            if (ok(index))
            {
                a[index] = value;
                errflag = false;
            }
            else
                errflag = true;
        }
    }
    // Метод возвращает значение true, если
    // индекс - в пределах границ.
    private bool ok(int index)
    {
        if (index >= 0 & index < Length)
            return true;
        return false;
    }
}
// Демонстрируем отказоустойчивый массив.
class FSDemo
{
    public static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        int x;
        // Вот как выглядит "мягкая посадка" при ошибках.
        Console.WriteLine("Мягкое приземление.");
        for (int i = 0; i < (fs.Length * 2); i++)
            fs[i] = i * 10;
        for (int i = 0; i < (fs.Length * 2); i++)
        {
            x = fs[i];
            if (x != -1) Console.Write(x + " ");
        }
        Console.WriteLine();
        // Теперь генерируем некорректный доступ.
        Console.WriteLine(
        "\nРабота с уведомлением об ошибках.");
        for (int i = 0; i < (fs.Length * 2); i++)
        {
            fs[i] = i * 10;
            if (fs.errflag)
                Console.WriteLine("fs[" + i + "] вне границ");
        }
        for (int i = 0; i < (fs.Length * 2); i++)
        {
            x = fs[i];
            if (!fs.errflag)
                Console.Write(x + " ");
            else
                Console.WriteLine("fs[" + i + "] вне границ");
        }
    }
}