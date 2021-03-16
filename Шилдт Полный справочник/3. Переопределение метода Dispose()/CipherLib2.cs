// Улучшенный вариант компонента шифрования, в котором
// поддерживается Файловый журнал регистрации всех операций.
using System;
using System.ComponentModel;
using System.IO;

namespace CipherLib
{
    // Компонент шифрования, который поддерживает
    // журнал регистрации.
    public class CipherComp : Component
    {
        static int useID = 0;
        int id; // Идентификационный номер экземпляра.
        bool isDisposed; // true, если компонент освобождается
        FileStream log;

        // Конструктор
        public CipherComp()
        {
            isDisposed = false; // Компонент не освобождается.
            try
            {
                log = new FileStream("CipherLog" + useID, FileMode.Create);
                id = useID;
                useID++;
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc);
                log = null;
            }
        }

        // Деструктор
        ~CipherComp()
        {
            Console.WriteLine("Деструктор для компонента " + id);
            Dispose(false);
        }

        // Шифруем строку. Метод возвращает и
        // сохраняет результат.
        public string Encode(string msg)
        {
            string temp = "";
            for (int i = 0; i < msg.Length; i++)
                temp += (char)(msg[i] + 1);
            // Сохраняем результат шифрования в файле.
            for (int i = 0; i < temp.Length; i++)
                log.WriteByte((byte)temp[i]);
            return temp;
        }

        // Дешифруем строку. Метод возвращает и
        // сохраняет результат.
        public string Decode(string msg)
        {
            string temp = "";
            for (int i = 0; i < msg.Length; i++)
                temp += (char)(msg[i] - 1);
            // Сохраняем результат дешифрирования в файле.
            for (int i = 0; i < temp.Length; i++)
                log.WriteByte((byte)temp[i]);
            return temp;
        }

        protected override void Dispose(bool dispAll)
        {
            Console.WriteLine("Dispose(" + dispAll + ") для компонента " + id);
            if (isDisposed)
            {
                if (dispAll)
                {
                    Console.WriteLine("Закрытие файла для " +
                    "компонента " + id);
                    log.Close(); // Закрываем файл.
                    isDisposed = true;
                }
                // Неуправляемые ресурсы не нужно освобождать.
                base.Dispose(dispAll);
            }
        }


        /*
        Рассмотрим более удачный вариант методов Encode() и Decode()

        // Метод шифрования строки. Возвращает результат и
        // сохраняет его в файле.

        public string Encode(string rasg)
        {
            // Предотвращаем использование освобожденного компонента.
            if (isDisposed)
            {
                Console.WriteLine("Ошибка: компонент уже разрушен.");
                return null;
            }
            string temp = "";
            for (int i = 0; i < msg.Length; i++)
                temp += (char)(msg[i] + 1);
            // Сохраняем результат в файле.
            for (int i = 0; i < temp.Length; i++)
                log.WriteByte((byte)temp[i]);
            return temp;
        }
        // Метод дешифрирования строки. Возвращает результат и
        // сохраняет его в файле.
        public string Decode(string msg)
        {
            // Предотвращаем использование освобожденного компонента.
            if (isDisposed)
            {
                Console.WriteLine("Ошибка: компонент уже разрушен.");
                return null;
            }
            string temp = "";
            for (int i=>0; i < msg.Length; i++)
            temp += (char)(msg[i] - 1);
            // Сохраняем результат в файле.
            for (int i = 0; i < temp.Length; i++)
                log.WriteByte((byte)temp[i]);
            return temp;
        }
         */
    }
}
