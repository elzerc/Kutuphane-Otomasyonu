namespace KutuphaneOtomasyon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // Bu sat�r� ekleyin
            Application.Run(new Form1());
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);



            //Form1 anaForm = new Form1();

            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

        }
    }
}