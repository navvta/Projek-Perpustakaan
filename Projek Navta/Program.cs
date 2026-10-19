using System;
using System.Windows.Forms;

namespace Project_Perpus_Nama_Kelas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormUtama());
        }
    }
}
