// Перегрузка индексатора для класса FailSoftArray.
using System;
class FailSoftArray
{
    int[] a; // Ссылка на базовый массив.
    public int Length; // Length (длина) - открытый член.
    public bool errflag; // Индикатор результата
                         // последней операции.
                         // Создаем массив заданной длины.
    public FailSoftArray(int size)
    {
        a = new int[size];
        Length = size;
    }
    // Это int-индексатор для класса FailSoftArray.
    public int this[int index]
    { // Это — get-аксессор.
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
        // Это — set-аксессор.
        set
        {
            if (ok(index))
            {
                a[index] = value;
                errflag = false;
            }
            else errflag = true;
        }
    }
    /* Это еще один индексатор для класса FailSoftArray.
    Здесь в качестве индекса принимается double-аргумент.
    Затем аргумент округляется до ближайшего целого
    индекса. */
    public int this[double idx]
    { // Это — get-аксессор.
        get
        {
            int index;
            // Округление до ближайшего целого int-значения.
            if ((idx - (int)idx) < 0.5)
                index = (int)idx;
            else
                index = (int)idx + 1;
            if (ok(index))
            {
                errflag = false;
                return a[index];
            }
            else {
                errflag = true;
                return 0;
            }
        }
        // Это — set-аксессор.
        set
        {
            int index;
            // Округление до ближайшего целого int-значения.
            if ((idx - (int)idx) < 0.5)
                index = (int)idx;
            else
                index = (int)idx + 1;
            if (ok(index))
            {
                a[index] = value;
                errflag = false;
            }
            else
                errflag = true;
        }
    }
    // Метод возвращает true, если индекс внутри границ.
    private bool ok(int index)
    {
        if (index >= 0 & index < Length) return true;
        return false;
    }
}
// Демонстрируем отказоустойчивый массив.
class FSDemo
{
    public static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        // Помещаем в массив fs несколько значений.
        for (int i = 0; i < fs.Length; i++)
            fs[i] = i;
        // Теперь используем в качестве индекса
        // int- и double-значения.
        Console.WriteLine("fs[1]: " + fs[1]);
        Console.WriteLine("fs[2]: " + fs[2]);
        Console.WriteLine("fs[1.1]: " + fs[1.1]);
        Console.WriteLine("fs[1.6]: " + fs[1.6]);
    }
}