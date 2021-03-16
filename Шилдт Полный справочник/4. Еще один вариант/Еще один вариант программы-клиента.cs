// Еще один вариант программы-клиента, в которой
// используется компонент CipherComp.
using System;
using CipherLib; // Импортируем пространство имен
// компонента CipherComp.
class CipherCompClient
{
    public static void Main()
    {
        CipherComp cc = new CipherComp();
        string text = "Тестирование";
        string ciphertext = cc.Encode(text);
        Console.WriteLine(ciphertext);
        string plaintext = cc.Decode(ciphertext);
        Console.WriteLine(plaintext);
        text = "Компоненты - мощное средство языка C#.";
        ciphertext = cc.Encode(text);
        Console.WriteLine(ciphertext);
        plaintext = cc.Decode(ciphertext);
        Console.WriteLine(plaintext);
        cc.Dispose(); // Освобождаем ресурсы.
    }
}
