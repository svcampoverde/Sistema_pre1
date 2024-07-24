using Presentacion.ModuloLogin;
using System;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using Unity;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Resolver el formulario principal con Unity
             // FrmLogin form = UnityConfig.Container.Resolve<FrmLogin>();
            FrmIPrincipal form = UnityConfig.Container.Resolve<FrmIPrincipal>();
            Application.Run(form);
            // Application.Run(new FRMPrincipal());
        }
    }
}
