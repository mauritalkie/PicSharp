namespace IP_Project
{
    internal static class Program
    {
        public static UserManual userManual = new UserManual() { StartPosition = FormStartPosition.CenterScreen };
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(userManual);
        }
    }
}