using System;
// Интерфейс шифрования и дешифрирования строк.
public interface ICipher
{
    string encode(string str);
    string decode(string str);
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

// Класс для хранения телефонных номеров.
class UnlistedPhone
{
    string pri_name; // Поддерживает свойство Name.
    string pri_number; // Поддерживает свойство Number.
    ICipher crypt; // Ссылка на объект шифрования.
    public UnlistedPhone(string name, string number, ICipher c)
    {
        crypt = c; // Хранит объект шифрования.
        pri_name = crypt.encode(name);  // шифрование имени
        pri_number = crypt.encode(number); // шифрование номера
    }
    public string Name
    {
        get
        {
            return crypt.decode(pri_name);
        }
        set // не используется
        {
            pri_name = crypt.encode(value);
        }
    }
    public string Number
    {
        get
        {
            return crypt.decode(pri_number);
        }
        set // не используется
        {
            pri_number = crypt.encode(value);
        }
    }
}

// Демонстрируем использование класса UnlistedPhone.
class UnlistedDemo
{
    public static void Main()
    {
        UnlistedPhone phone1 = new UnlistedPhone("Tom", "555-3456", new BitCipher(27));
        UnlistedPhone phone2 = new UnlistedPhone("Мэри", "555-8891", new BitCipher(9));
        Console.WriteLine("Телефонный номер абонента по имени " +
                           phone1.Name + " : " + phone1.Number);
        Console.WriteLine("Телефонный номер абонента по имени " +
                           phone2.Name + " : " + phone2.Number);
    }
}