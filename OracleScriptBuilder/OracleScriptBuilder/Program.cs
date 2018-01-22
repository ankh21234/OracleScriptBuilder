using OracleScriptBuilder.Source.View;
using System;
using System.Windows.Forms;

namespace OracleScriptBuilder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmIdentityScriptBuilder());
        }
    }
}
