// Клиент, который использует компонент CipherComp.
using System;
using CipherLib; // Импортируем пространство имен
// компонента CipherComp..
class CipherCompClient
{
    public static void Main()
    {
        CipherComp cc = new CipherComp();
        string text = "Это простой тест";
        string ciphertext = cc.Encode(text);
        Console.WriteLine(ciphertext);
        string plaintext = cc.Decode(ciphertext);
        Console.WriteLine(plaintext);
        cc.Dispose(); // Освобождаем ресурсы.
    }
}