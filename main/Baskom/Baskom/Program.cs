using System.Collections;
using Baskom.View;
using Baskom.Controller;
using Baskom.Model;

namespace Baskom
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.Database.openDb();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new View.v_Login());
            Database.Database.closeDb();
        }
    }
}