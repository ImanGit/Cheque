using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Cheque.Win.Start;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace Cheque.Win
{
    /// <summary>
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

        //    MessageBox.Show(DateTime.Now.ToString());
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(StructureMapConfig.Resolve<MainForm>());
        }
    }
}