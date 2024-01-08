namespace ItemBoxUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Init the database Connectors
            ItemLibraray.GlobalConfig.Init_Connections(ItemLibraray.DatabaseType.Text);

            Application.Run(new CreateItemUI());
        }
    }
}