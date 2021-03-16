/* Использование классов BinaryReader и BinaryWriter
  для реализации простой программы инвентаризации. */

using System;
using System.IO;
class Inventory
{
    public static void Main()
    {
        BinaryWriter dataOut;
        BinaryReader dataIn;
        string item; // Наименование элемента.
        int onhand; // Количество, имеющееся в наличии.
        double cost; // Цена.

        try
        {
            dataOut = new
            BinaryWriter(new FileStream("inventory.dat", FileMode.Create));
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "\nНе удается открыть файл.");
            return;
        }
        // Записываем некоторые инвентаризационные данные в файл.
        try
        {
            dataOut.Write("Молотки");
            dataOut.Write(10);
            dataOut.Write(3.95);
            dataOut.Write("Отвертки");
            dataOut.Write(18);
            dataOut.Write(1.50);
            dataOut.Write("Плоскогубцы");
            dataOut.Write(5);
            dataOut.Write(4.95);
            dataOut.Write("Пилы");
            dataOut.Write(8);
            dataOut.Write(8.95);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message +
            "\nОшибка при записи.");
        }
        dataOut.Close();
        Console.WriteLine();

        // Теперь откроем файл инвентаризации для чтения информации.
        try
        {
            dataIn = new BinaryReader(new FileStream("inventory.dat", FileMode.Open));
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message + "\nНе удается открыть файл.");
            return;
        }
        // Поиск элемента, введенного пользователем.
        Console.Write("Введите наименование для поиска: ");
        string what = Console.ReadLine();
        Console.WriteLine();
        try
        {
            for (; ; )
            {
                // Считываем запись из базы данных.
                item = dataIn.ReadString();
                onhand = dataIn.ReadInt32();
                cost = dataIn.ReadDouble();
                /* Если элемент в базе данных совпадает с элементом
                из запроса, отображаем найденную информацию. */
                if (item.CompareTo(what) == 0)
                {
                    Console.WriteLine(item + ": " + onhand +
                                        " штук в наличии. " +
                                        "Цена: {0:C} за каждую единицу.",
                                         cost);
                    Console.WriteLine("Общая стоимость по наименованию <{0}>: {1:С}.",
                                        item, cost * onhand);
                    break;
                }
            }
        }
        catch (EndOfStreamException)
        {
            Console.WriteLine("Элемент не найден.");
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "Ошибка при чтении.");
        }
        dataIn.Close();
    }
}
