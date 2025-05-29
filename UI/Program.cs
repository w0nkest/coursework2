using Classes;

namespace UI
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Form menu = new MenuForm();
            menu.ShowDialog();
        }
    }
}