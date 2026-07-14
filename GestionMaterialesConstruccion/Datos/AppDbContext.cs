using GestionMaterialesConstruccion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionMaterialesConstruccion.Datos
{
    /// <summary>
    /// Requiere LocalDB (incluido con Visual Studio 2022, carga de trabajo ".NET desktop development").
    /// </summary>
    public class AppDbContext : DbContext
    {
        private const string ConnectionString =
            @"Server=(localdb)\mssqllocaldb;Database=GestionMaterialesConstruccionDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Material> Materiales { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetallesCompra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .HasIndex(e => e.Email)
                .IsUnique();

            modelBuilder.Entity<Proveedor>()
                .HasIndex(p => p.Codigo)
                .IsUnique();

            modelBuilder.Entity<Material>()
                .HasIndex(m => m.Codigo)
                .IsUnique();

            modelBuilder.Entity<Compra>()
                .HasIndex(c => c.Codigo)
                .IsUnique();

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Proveedor)
                .WithMany(p => p.Compras)
                .HasForeignKey(c => c.ProveedorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleCompra>()
                .HasOne(d => d.Compra)
                .WithMany(c => c.Detalles)
                .HasForeignKey(d => d.CompraId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DetalleCompra>()
                .HasOne(d => d.Material)
                .WithMany()
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.Restrict);

            // Usuario administrador inicial: admin@falconesa.com / admin123
            modelBuilder.Entity<Empleado>().HasData(new Empleado
            {
                Id = 1,
                Nombre = "Renzo",
                Apellido = "Falcone",
                Dni = "00000000",
                Legajo = "B00049222-T1",
                Email = "admin@falconesa.com",
                Contrasenia = "admin123",
                Rol = RolEmpleado.Administrador
            });
        }
    }
}
