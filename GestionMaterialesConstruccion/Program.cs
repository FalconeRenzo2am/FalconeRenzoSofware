using GestionMaterialesConstruccion.Datos;
using GestionMaterialesConstruccion.Formularios;

namespace GestionMaterialesConstruccion
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var contexto = ConexionBD.Instancia.CrearContexto())
            {
                contexto.Database.EnsureCreated();
            }

            using var frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal());
            }
        }
    }
}
