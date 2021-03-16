// Пример обработки события, связанного с нажатием клавиши на клавиатуре.

using System;
// Выводим собственный класс EventArgs, который будет хранить код клавиши.
class KeyEventArgs : EventArgs
{
    public char ch;
}

// Объявляем делегат для события.
delegate void KeyHandler(object source, KeyEventArgs arg);

// Объявляем класс события, связанного с нажатием клавиши на клавиатуре.
class KeyEvent
{
    public event KeyHandler KeyPress;
    // Этот метод вызывается при нажатии какой-нибудь клавиши.
    public void OnKeyPress(char key)
    {
        KeyEventArgs k = new KeyEventArgs();
        if (KeyPress != null)
        {
            k.ch = key;
            KeyPress(this, k);
        }
    }
}
// Класс, который принимает уведомления о нажатии клавиши.
class ProcessKey
{
    public void keyhandler(object source, KeyEventArgs arg)
    {
        Console.WriteLine("Получено сообщение о нажатии клавиши: " + arg.ch);
    }
}
// Еще один класс, который принимает уведомления о нажатии клавиши.
class CountKeys
{
    public int count = 0;
    public void keyhandler(object source, KeyEventArgs arg)
    {
        count++;
    }
}

// Демонстрируем использование класса KeyEvent.
class KeyEventDemo
{
    public static void Main()
    {
        KeyEvent kevt = new KeyEvent();
        ProcessKey pk = new ProcessKey();
        CountKeys ck = new CountKeys();
        char ch;
        kevt.KeyPress += new KeyHandler(pk.keyhandler);
        kevt.KeyPress += new KeyHandler(ck.keyhandler);
        Console.WriteLine("Введите несколько символов. " + "Для останова введите точку.");
        do
        {
            ch = (char)Console.Read();
            kevt.OnKeyPress(ch);
        } while (ch != '.');
        Console.WriteLine("Было нажато " + ck.count + " клавиш.");
    }
}
