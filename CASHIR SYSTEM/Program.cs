using CASHIR_SYSTEM.Areas.Meals.forms;
using CASHIR_SYSTEM.Areas.Order;
using CASHIR_SYSTEM.Areas.Orders;
using CASHIR_SYSTEM.Areas.Orders.OrderForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASHIR_SYSTEM
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
            //Application.Run(new Tables());
            Application.Run(new AddOrder());
            //Application.Run(new AddFoodItem());
        }
    }
}
