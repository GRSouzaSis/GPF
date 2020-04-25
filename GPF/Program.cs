using GPF.View;
using System;
using System.Windows.Forms;

namespace GPF
{
    static class Program
    {
        

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //using (ThreadScopedLifestyle.BeginScope(Dependencias.Container))
            //{
            //    Dependencias.Configurar();
            //    Application.Run(new fLogin());
            //   // Application.Run(new fPrincipal());
            //}
            //--------
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
           // Application.Run(new fCadParametrizacao());
            //Application.Run(new fPrincipal());
        }
    }
}
