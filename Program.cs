using ProjetoDS.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new CarregamentoSistema());
=======
            Application.Run(new FrmProduto());
>>>>>>> 07dd74b86e1a92c64cb1ebe65b6c2f24cc480416
        }
    }
}
