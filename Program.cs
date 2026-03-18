using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SymfoniaBug
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                if (args.Name.StartsWith("Newtonsoft.Json"))
                {
                    var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Newtonsoft.Json.dll");
                    return Assembly.LoadFrom(path);
                }
                return null;
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}