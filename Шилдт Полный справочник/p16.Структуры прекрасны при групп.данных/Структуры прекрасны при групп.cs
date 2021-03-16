// Структуры прекрасно работают при группировании данных.

using System;
using System.Text;

// Определяем структуру пакета.
struct PacketHeader
{
    public uint packNum; // Номер пакета.
    public ushort packLen; // Длина пакета.
}

// Используем структуру PacketHeader для создания
// электронной записи транзакции.
class Transaction
{
    static uint transacNum = 0;
    PacketHeader ph; // Включаем в транзакцию
                     // структуру PacketHeader.
    string accountNum;
    double amount;
    public Transaction(string acc, double val)
    {
        // Создаем заголовок пакета.
        ph.packNum = transacNum++;
        ph.packLen = 512; // arbitrary length
        accountNum = acc;
        amount = val;
    }
    // Имитируем транзакцию.
    public void sendTransaction()
    {
        Console.WriteLine("Пакет #: " + ph.packNum +
                          ", Длина: " + ph.packLen +
                          ",\n Счет #: " + accountNum +
                          ", Сумма: {0:C}\n", amount);
    }
}

// Демонстрируем использование пакетной обработки.
class PacketDemo
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode; // включаем кодировку рубля
        Transaction t = new Transaction("31243", -100.12);
        Transaction t2 = new Transaction("AB4655", 345.25);
        Transaction t3 = new Transaction("8475-09", 9800.00);
        t.sendTransaction();
        t2.sendTransaction();
        t3.sendTransaction();
    }
}