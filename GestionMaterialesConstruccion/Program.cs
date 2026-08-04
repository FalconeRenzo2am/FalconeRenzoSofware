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

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) => MostrarError(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
                MostrarError(e.ExceptionObject as Exception ?? new Exception(e.ExceptionObject?.ToString()));

            try
            {
                using var contexto = ConexionBD.Instancia.CrearContexto();
                contexto.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo crear o conectar la base de datos.\n\n" + ex,
                    "Error al iniciar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using var frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal());
            }
        }

        private static void MostrarError(Exception ex)
        {
            MessageBox.Show(
                "Ocurrió un error inesperado.\n\n" + ex,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
