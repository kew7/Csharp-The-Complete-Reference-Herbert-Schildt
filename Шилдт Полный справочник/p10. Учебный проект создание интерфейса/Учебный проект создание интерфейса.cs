using System;
// Интерфейс шифрования и дешифрирования строк.
public interface ICipher
{
    string encode(string str);
    string decode(string str);
}

/* Простая реализация интерфейса ICipher, которая кодирует сообщение посредством сдвига
 * каждого символа на 1 позицию вверх. Так, буква А превратится в букву Б и т.д. */
class SimpleCipher : ICipher
{
    // Метод возвращает зашифрованную строку, заданную
    // открытым текстом.
    public string encode(string str)
    {
        string ciphertext = "";
        for (int i = 0; i < str.Length; i++)
            ciphertext = ciphertext + (char)(str[i] + 1);
        return ciphertext;
    }
    // Метод возвращает дешифрированную строку, заданную
    // зашифрованным текстом.
    public string decode(string str)
    {
        string plaintext = "";
        for (int i = 0; i < str.Length; i++)
            plaintext = plaintext + (char)(str[i] - 1);
        return plaintext;
    }
}

/* В этой реализации интерфейса ICipher используется
побитовая обработка и ключ. */
class BitCipher : ICipher
{
    ushort key;
    // Определяем ключ при построении объектов
    // класса BitCipher.
    public BitCipher(ushort k)
    {
        key = k;
    }
    // Метод возвращает зашифрованную строку, заданную
    // открытым текстом.
    public string encode(string str)
    {
        string ciphertext = "";
        for (int i = 0; i < str.Length; i++)
            ciphertext = ciphertext + (char)(str[i] ^ key);
        return ciphertext;
    }
    // Метод возвращает дешифрированную строку, заданную
    // зашифрованным текстом.
    public string decode(string str)
    {
        string plaintext = "";
        for (int i = 0; i < str.Length; i++)
            plaintext = plaintext + (char)(str[i] ^ key);
        return plaintext;
    }
}

// Демонстрация использования интерфейса ICipher.
class ICipherDemo
{
    public static void Main()
    {
        ICipher ciphRef;
        SimpleCipher sc = new SimpleCipher(); // объект класса простого шифрования
        BitCipher bit = new BitCipher(27); // объект с ключом шифрования, 27 - ключ для шифрования
        string plain;
        string coded;
        // Сначала переменная ciphRef ссылается на объект
        // класса SimpleCipher (простое шифрование).
        ciphRef = sc;
        Console.WriteLine("Использование простого шифра.");
        plain = "testing";
        coded = ciphRef.encode(plain);
        Console.WriteLine("Зашифрованный текст: " + coded);
        plain = ciphRef.decode(coded);
        Console.WriteLine("Открытый текст: " + plain);
        // Теперь переменная ciphRef refer ссылается на
        // объект класса BitCipher (поразрядное шифрование).
        ciphRef = bit;
        Console.WriteLine(
        "\nИспользование поразрядного шифрования.");
        plain = "testing";
        coded = ciphRef.encode(plain);
        Console.WriteLine("Зашифрованный текст: " + coded);
        plain = ciphRef.decode(coded);
        Console.WriteLine("Открытый текст: " + plain);
    }
}