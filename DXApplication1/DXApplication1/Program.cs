using System;
using System.Windows.Forms;

namespace DXApplication1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XtraForm1());
        }
    }
}
