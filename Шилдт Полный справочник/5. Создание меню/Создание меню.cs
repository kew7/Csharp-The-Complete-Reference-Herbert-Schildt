// Добавляем основное меню.
using System;
using System.Windows.Forms;
class MenuForm : Form
{
    MainMenu MyMenu;
    public MenuForm()
    {
        Text = "Добавление меню";
        // Создаем объект основного меню.
        MainMenu MyMenu = new MainMenu();
        // Добавляем в это меню элемент верхнего уровня.
        MenuItem m1 = new MenuItem("Файл");
        MyMenu.MenuItems.Add(m1);
        MenuItem m2 = new MenuItem("Сервис");
        MyMenu.MenuItems.Add(m2);
        // Создаем подменю Файл.
        MenuItem subm1 = new MenuItem("Открыть");
        m1.MenuItems.Add(subm1);
        MenuItem subm2 = new MenuItem("Закрыть");
        m1.MenuItems.Add(subm2);
        MenuItem subm3 = new MenuItem("Выйти");
        m1.MenuItems.Add(subm3);
        // Создаем подменю "Сервис".
        MenuItem subm4 = new MenuItem("Координаты");
        m2.MenuItems.Add(subm4);
        MenuItem subm5 = new MenuItem("Изменить размер");
        m2.MenuItems.Add(subm5);
        MenuItem subm6 = new MenuItem("Восстановить");
        m2.MenuItems.Add(subm6);
        // Добавляем обработчики событий для элементов меню.
        subm1.Click += new EventHandler(MMOpenClick);
        subm2.Click += new EventHandler(MMCloseClick);
        subm3.Click += new EventHandler(MMExitClick);
        subm4.Click += new EventHandler(MMCoordClick);
        subm5.Click += new EventHandler(MMChangeClick);
        subm6.Click += new EventHandler(MMRestoreClick);
        // Назначаем меню форме.
        Menu = MyMenu;
    }
    [STAThread]
    public static void Main()
    {
        MenuForm skel = new MenuForm();
        Application.Run(skel);
    }
    // Обработчик для команды меню Координаты.
    protected void MMCoordClick(object who, EventArgs e)
    {
        // Создаем строку, которая содержит три координаты.
        string size =
        string.Format(" {0}: {1}, {2}\n{3}: {4}, {5} ",
        "Вверху, Слева", Top, Left,
        "Внизу, Справа", Bottom, Right);
        // Отображаем окно сообщений.
        MessageBox.Show(size, "Координаты окна",
        MessageBoxButtons.OK);
    }
    // Обработчик для команды меню Изменить размер.
    protected void MMChangeClick(object who, EventArgs e)
    {
        Width = Height = 200;
    }
    // Обработчик для команды меню Восстановить.
    protected void MMRestoreClick(object who, EventArgs e)
    {
        Width = Height = 300;
    }
    // Обработчик для команды меню Открыть.
    protected void MMOpenClick(object who, EventArgs e)
    {
        MessageBox.Show("Неактивная команда", "Заглушка",
        MessageBoxButtons.OK);
    }
    // Обработчик для команды меню Закрыть.
    protected void MMCloseClick(object who, EventArgs e)
    {
        MessageBox.Show("Неактивная команда", "Заглушка",
        MessageBoxButtons.OK);
    }
    // Обработчик для команды меню Выйти.
    protected void MMExitClick(object who, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
        "Остановить программу?",
        "Завершение",
        MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes) Application.Exit();
    }
}
