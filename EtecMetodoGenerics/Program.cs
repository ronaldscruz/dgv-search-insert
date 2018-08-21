using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EtecMetodoGenerics
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
            Application.Run(new Pedidos());
            Application.Run(new CadastrarCliente());
            Application.Run(new CadastrarProduto());
        }
    }
}
