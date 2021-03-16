// Простой компонент-шифратор.
// Назовите этот файл CipherLib.cs.
using System.ComponentModel;
namespace CipherLib
{ // Помещаем компонент в его же
  // пространство имен.
  // Обратите внимание на то, что класс CipherComp
  // наследует класс Component.
    public class CipherComp : Component
    {
        // Шифруем строку.
        public string Encode(string msg)
        {
            string temp = "";
            for (int i = 0; i < msg.Length; i++)
                temp += (char)(msg[i] + 1);
            return temp;
        }
        // Дешифруем строку.
        public string Decode(string msg)
        {
            string temp = "";
            for (int i = 0; i < msg.Length; i++)
                temp += (char)(msg[i] - 1);
            return temp;
        }
    }
}