// Обработка сообщений от кнопки.
using System;
using System.Windows.Forms;
using System.Drawing;
class ButtonForm : Form
{
    Button MyButton = new Button();
    public ButtonForm()
    {
        Text = "Реакция на щелчок";
        MyButton = new Button();
        MyButton.Text = "Щелкните";
        MyButton.Location = new Point(100, 200);
        // Добавляем в список обработчик событий кнопки.
        MyButton.Click += new EventHandler(MyButtonClick);
        Controls.Add(MyButton);
    }
    [STAThread]
    public static void Main()
    {
        ButtonForm skel = new ButtonForm();
        Application.Run(skel);
    }
    // Обработчик для кнопки MyButton.
    protected void MyButtonClick(object who, EventArgs e)
    {
        if (MyButton.Top == 200)
            MyButton.Location = new Point(10, 10);
        else
            MyButton.Location = new Point(100, 200);
    }
}
