// Простейшее Windows-приложение, основанное
// на применении окон.

using System;
using System.Windows.Forms;
// Класс WinSkel - производный от класса Form.
class WinSkel : Form
{
    public WinSkel()
    {
        // Присваиваем окну имя.
        Text = "Рама Windows-окна";
    }
    // Метод Main() используется только для запуска приложения.
    [STAThread]
    public static void Main()
    {
        WinSkel skel = new WinSkel(); // Создаем форму.
                                      // Запускаем механизм функционирования окна.
        Application.Run(skel);
    }
}