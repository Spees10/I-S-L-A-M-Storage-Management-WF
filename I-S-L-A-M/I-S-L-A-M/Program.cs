using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_S_L_A_M
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ProductForm());
            //Application.Run(new ReportsForm());
            //Application.Run(new SellProductForm());
            //Application.Run(new CreateSupplier());
            //Application.Run(new CategoryForm());
            //Application.Run(new CreateBranch());
            Application.Run(new Main());
        }
    }
}