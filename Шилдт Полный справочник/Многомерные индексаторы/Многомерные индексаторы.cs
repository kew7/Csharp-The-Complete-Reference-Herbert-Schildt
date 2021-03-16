// Двумерный отказоустойчивый массив.
using System;
class FailSoftArray2D
{
    int[,] a; // Ссылка на базовый двумерный массив.
    int rows, cols; // размерности
    public int Length; // Length - открытый член.
    public bool errflag; // Индикатор результата
                         // последней операции.
    // Создаем массив заданного размера.
    public FailSoftArray2D(int r, int с)
    {
        rows = r;
        cols = с;
        a = new int[rows, cols];
        Length = rows * cols;
    }
    // Это индексатор для класса FailSoftArray2D.
    public int this[int index1, int index2]
    {
        // Это — get-аксессор.
        get
        {
            if (ok(index1, index2))
            {
                errflag = false;
                return a[index1, index2];
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
            if (ok(index1, index2))
            {
                a[index1, index2] = value;
                errflag = false;
            }
            else
                errflag = true;
        }
    }
    // Метод возвращает значение true, если индексы
    // находятся внутри границ.
    private bool ok(int index1, int index2)
    {
        if (index1 >= 0 & index1 < rows &
        index2 >= 0 & index2 < cols)
            return true;
        return false;
    }
}
// Демонстрируем использование двумерного индексатора.
class TwoDIndexerDemo
{
    public static void Main()
    {
        FailSoftArray2D fs = new FailSoftArray2D(3, 5);
        int x;
        // Демонстрируем "мягкую посадку" при ошибках.
        Console.WriteLine("Мягкое приземление.");
        for (int i = 0; i < 6; i++)
            fs[i, i] = i * 10;
        for (int i = 0; i < 6; i++)
        {
            x = fs[i, i];
            if (x != -1) Console.Write(x + " ");
        }
        Console.WriteLine();
        //А теперь генерируем ошибки.
        Console.WriteLine(
        "\nРабота с уведомлением об ошибках.");
        for (int i = 0; i < 6; i++)
        {
            fs[i, i] = i * 10;
            if (fs.errflag)
                Console.WriteLine(
                "fs[" + i + ", " + i + "] вне границ");
        }
        for (int i = 0; i < 6; i++)
        {
            x = fs[i, i];
            if (!fs.errflag)
                Console.Write(x + " ");
            else
                Console.WriteLine(
                "fs[" + i + ", " + i + "] вне границ");
        }
    }
}