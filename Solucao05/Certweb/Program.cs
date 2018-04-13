using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Certweb {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en"); // forçar o idioma EN
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en"); // forçar o idioma EN

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicial());
        }
    }
}
