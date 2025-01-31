using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DosostaApp;
namespace DosostaApp

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

          //var userverwaltung = new UserVerwaltung();
           //new Userverwaltung.Show();
            new Buchverwaltung().Show();
            Application.Run(new UserVerwaltung());
        }
    }
}
