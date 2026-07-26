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
            @"Server=(localdb)\mssqllocaldb;Database=GestionMaterialesConstruccionDB_v2;Trusted_Connection=True;TrustServerCertificate=True;";

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Material> Materiales { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetallesCompra { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }

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

            modelBuilder.Entity<Rol>()
                .HasIndex(r => r.Nombre)
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

            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Rol)
                .WithMany()
                .HasForeignKey(e => e.RolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rol>()
                .HasMany(r => r.Permisos)
                .WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "RolPermiso",
                    j => j.HasOne<Permiso>().WithMany().HasForeignKey("PermisoId"),
                    j => j.HasOne<Rol>().WithMany().HasForeignKey("RolId"),
                    j =>
                    {
                        j.HasKey("RolId", "PermisoId");
                        j.HasData(
                            new { RolId = 1, PermisoId = 1 },
                            new { RolId = 1, PermisoId = 2 },
                            new { RolId = 1, PermisoId = 3 },
                            new { RolId = 1, PermisoId = 4 },
                            new { RolId = 1, PermisoId = 5 },
                            new { RolId = 2, PermisoId = 1 },
                            new { RolId = 2, PermisoId = 2 },
                            new { RolId = 2, PermisoId = 3 }
                        );
                    });

            modelBuilder.Entity<Permiso>().HasData(
                new Permiso { Id = 1, Nombre = PermisosSistema.GestionProveedores, Descripcion = "Alta, baja y modificación de proveedores" },
                new Permiso { Id = 2, Nombre = PermisosSistema.GestionMateriales, Descripcion = "Alta, baja y modificación de materiales" },
                new Permiso { Id = 3, Nombre = PermisosSistema.GestionCompras, Descripcion = "Alta, baja y modificación de compras" },
                new Permiso { Id = 4, Nombre = PermisosSistema.GestionEmpleados, Descripcion = "Alta, baja y modificación de empleados" },
                new Permiso { Id = 5, Nombre = PermisosSistema.GestionRoles, Descripcion = "Creación y edición de roles del sistema" }
            );

            modelBuilder.Entity<Rol>().HasData(
                new Rol { Id = 1, Nombre = "Administrador", Descripcion = "Acceso total al sistema" },
                new Rol { Id = 2, Nombre = "Empleado", Descripcion = "Acceso operativo, sin gestión de empleados ni roles" }
            );

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
                RolId = 1
            });
        }
    }
}
