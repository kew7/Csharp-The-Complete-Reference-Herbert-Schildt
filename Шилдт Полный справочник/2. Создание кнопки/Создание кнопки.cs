// Добавление кнопки.
using System;
using System.Windows.Forms;
using System.Drawing;
class ButtonForm : Form
{
    Button MyButton = new Button();
    public ButtonForm() {
        Text = "Использование кнопки";
        MyButton = new Button();
        MyButton.Text = "Щелкните";
        MyButton.Location = new Point(100, 200);
        Controls.Add(MyButton);
    }
    [STAThread]
    public static void Main()
    {
        ButtonForm skel = new ButtonForm();
        Application.Run(skel);
    }
}