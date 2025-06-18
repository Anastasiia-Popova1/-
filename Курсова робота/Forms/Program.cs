
namespace Курсова_робота.Forms
{

    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, args) =>
            {
                return;
            };

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}