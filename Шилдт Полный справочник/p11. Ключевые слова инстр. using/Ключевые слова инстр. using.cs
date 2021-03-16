// Демонстрация использования инструкции using.
using System;
using System.IO;
class UsingDemo
{
    public static void Main()
    {
        StreamReader sr = new StreamReader("test.txt");
        // Используем объект внутри инструкции using.
        using (sr)
        {
            Console.WriteLine(sr.ReadLine());
            sr.Close();
        }
        // Создаем StreamReader-объект внутри инструкции using.
        using (StreamReader sr2 = new StreamReader("test.txt"))
        {
            Console.WriteLine(sr2.ReadLine());
            sr2.Close();
        }
    }
}
