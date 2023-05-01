using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AuditVaccinationPatientsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsFormsSettings.LoadApplicationSettings();
            WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Tahoma", 11);

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("uk-UA");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk-UA");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
