// Эта версия программы использует класс SimpleCipher.
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
        //На этот раз вместо класса Bitcipher используем
        // класс SimpleCipher.
        UnlistedPhone phone1 = new UnlistedPhone("Tom", "555-3456", new SimpleCipher());
        UnlistedPhone phone2 = new UnlistedPhone("Mary", "555-88 91", new SimpleCipher());
        Console.WriteLine("Телефонный номер абонента по имени " +
                          phone1.Name + " : " + phone1.Number);
        Console.WriteLine("Телефонный номер абонента по имени " +
                          phone2.Name + " : " + phone2.Number);
    }
}
