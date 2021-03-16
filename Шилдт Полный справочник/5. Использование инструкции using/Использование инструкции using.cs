// Использование инструкции using.
using System;
using CipherLib; // Импортируем пространство имен
// компонента CipherComp.
class CipherCompClient
{
    public static void Main()
    {
        // Объект ее разрушится по завершении этого блока.
        using (CipherComp cc = new CipherComp())
        {
            string text = "Инструкция using.";
            string ciphertext = cc.Encode(text);
            Console.WriteLine(ciphertext);
            string plaintext = cc.Decode(ciphertext);
            Console.WriteLine(plaintext);
        }
    }
}
