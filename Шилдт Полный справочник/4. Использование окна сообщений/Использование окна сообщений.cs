// Добавление кнопки останова.
using System;
using System.Windows.Forms;
using System.Drawing;
class ButtonForm : Form
{
    Button MyButton;
    Button StopButton;
    public ButtonForm()
    {
        Text = "Добавление кнопки Стоп";
        // Создаем кнопки.
        MyButton = new Button();
        MyButton.Text = "Щелкните";
        MyButton.Location = new Point(100, 200);
        StopButton = new Button();
        StopButton.Text = "Стоп";
        StopButton.Location = new Point(100, 100);
        // Добавляем обработчики событий.
        MyButton.Click += new EventHandler(MyButtonClick);
        Controls.Add(MyButton);
        StopButton.Click += new EventHandler(StopButtonClick);
        Controls.Add(StopButton);
    }
    [STAThread]
    public static void Main()
    {
        ButtonForm skel = new ButtonForm();
        Application.Run(skel);
    }
    // Обработчик событий для кнопки MyButton.
    protected void MyButtonClick(object who, EventArgs e)
    {
        if (MyButton.Top == 200)
            MyButton.Location = new Point(10, 10);
        else
            MyButton.Location = new Point(100, 200);
    }
    // Обработчик событий для кнопки StopButton.
    protected void StopButtonClick(object who, EventArgs e)
    {
        // Если пользователь ответит щелчком на кнопке Yes.
        // программа будет завершена.
        DialogResult result = MessageBox.Show(
        "Остановить программу?",
        "Завершение",
        MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
            Application.Exit();
    }
}
