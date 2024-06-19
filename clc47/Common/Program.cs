using System;
using System.Windows.Forms;

namespace calc
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Form f = new Form();
            Application.Run(f);
        }
    }
}
