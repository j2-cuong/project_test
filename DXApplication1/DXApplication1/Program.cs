//using DevExpress.LookAndFeel;
//using DevExpress.Skins;
//using DevExpress.UserSkins;
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
            Application.Run(new Form1());
        }
    }
}
