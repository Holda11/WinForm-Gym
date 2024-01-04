using SemestralniPrace_JanHolda.Functions.Login;
using SemestralniPrace_JanHolda.Functions.Permice;
using SemestralniPrace_JanHolda.Functions.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralniPrace_JanHolda
{
    internal static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StaticLogin.CreateLoginFile();
            StaticTable.CreateStaticTable();
            StaticPermice.CreatePermiceFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
