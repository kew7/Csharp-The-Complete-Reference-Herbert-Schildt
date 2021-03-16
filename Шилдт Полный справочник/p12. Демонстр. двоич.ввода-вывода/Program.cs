// Запись в файл двоичных данных с последующим их считыванием.

using System;
using System.IO;
class RWData
{
    public static void Main()
    {
        BinaryWriter dataOut;
        BinaryReader dataIn;
        int i = 10;
        double d = 1023.56;
        bool b = true;

        try
        {
            dataOut = new BinaryWriter(new FileStream("testdata", FileMode.Create));
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "\nНе удается открыть файл.");
            return;
        }
        try
        {
            Console.WriteLine("Запись " + i);
            dataOut.Write(i);
            Console.WriteLine("Запись " + d);
            dataOut.Write(d);
            Console.WriteLine("Запись " + b);
            dataOut.Write(b);
            Console.WriteLine("Запись " + 12.2 * 7.4);
            dataOut.Write(12.2 * 7.4);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "\nОшибка при записи.");
        }
        dataOut.Close();
        Console.WriteLine();

        // Теперь попробуем прочитать эти данные.
        try
        {
            dataIn = new BinaryReader(new FileStream("testdata", FileMode.Open));
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message + "\nНе удается открыть файл.");
            return;
        }
        try
        {
            i = dataIn.ReadInt32();
            Console.WriteLine("Считывание " + i);
            d = dataIn.ReadDouble();
            Console.WriteLine("Считывание " + d);
            b = dataIn.ReadBoolean();
            Console.WriteLine("Считывание " + b);
            d = dataIn.ReadDouble();
            Console.WriteLine("Считывание " + d);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "Ошибка при считывании.");
        }
        dataIn.Close();
        Console.ReadLine();
    }
}