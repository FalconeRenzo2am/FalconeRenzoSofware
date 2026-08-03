namespace GestionMaterialesConstruccion.Datos
{
    /// <summary>
    /// Punto único de acceso a la base de datos (patrón Singleton): toda la aplicación
    /// pasa por esta única instancia para obtener un contexto de Entity Framework,
    /// en vez de que cada Controladora arme su propia conexión por su cuenta.
    /// Cada llamado a <see cref="CrearContexto"/> devuelve un <see cref="AppDbContext"/>
    /// nuevo y de corta vida (lo recomendado para EF Core, una unidad de trabajo por
    /// operación), pero la configuración de acceso a la base queda centralizada acá.
    /// </summary>
    public sealed class ConexionBD
    {
        private static readonly Lazy<ConexionBD> instanciaPerezosa = new(() => new ConexionBD());

        public static ConexionBD Instancia => instanciaPerezosa.Value;

        private ConexionBD()
        {
        }

        public AppDbContext CrearContexto() => new();
    }
}
