# Gestión de Materiales de Construcción (Falcone SA)

Aplicación de escritorio en C# (WinForms, .NET 8) para el TP de Ingeniería de
Software, basada en la documentación entregada (alcance, casos de uso, modelo
de dominio, diagramas de secuencia y clases, y prototipos de interfaz).

## Requerimientos implementados (1ra iteración)

- **R01** Gestionar Proveedores (alta, baja, modificación)
- **R02** Gestionar Materiales (alta, baja, modificación, control de stock)
- **R03** Gestionar Compras y su Detalle de Compra (requerimiento "CORE": cada
  línea de detalle repone stock del material comprado y recalcula el precio
  total de la compra)
- **R04** Registrar Empleados
- **R05** Iniciar sesión (email + contraseña) con verificación de permisos
  (rol Administrador / Empleado)

## Arquitectura

El proyecto sigue la arquitectura en capas reflejada en los diagramas de
secuencia de la documentación (Interfaz → Controladora → Entidad):

- `Modelos/` – Entidades del dominio (Persona, Empleado, Proveedor, Material,
  Compra, DetalleCompra).
- `Datos/` – `AppDbContext` (Entity Framework Core, persistencia en SQL
  Server LocalDB).
- `Controladoras/` – Lógica de negocio y validaciones de cada requerimiento.
- `Formularios/` – Interfaz de usuario (Windows Forms), un formulario CRUD
  por cada requerimiento, siguiendo los prototipos de pantalla del PDF.

## Cómo ejecutar en Visual Studio 2022

1. Instalar la carga de trabajo **".NET desktop development"** (incluye
   Windows Forms) y asegurarse de tener **SQL Server LocalDB** instalado
   (se instala junto con la carga de trabajo "Almacenamiento y procesamiento
   de datos" o junto a SQL Server Express).
2. Abrir `GestionMaterialesConstruccion.sln` con Visual Studio 2022.
3. Compilar el proyecto (restaura automáticamente los paquetes NuGet de
   Entity Framework Core al compilar).
4. Ejecutar (F5). Al iniciar, la aplicación crea automáticamente la base de
   datos `GestionMaterialesConstruccionDB` en `(localdb)\mssqllocaldb` si no
   existe, junto con un usuario administrador de prueba:
   - **Email:** `admin@falconesa.com`
   - **Contraseña:** `admin123`

## Notas

- La cadena de conexión está definida en `Datos/AppDbContext.cs`. Si se desea
  usar otra instancia de SQL Server, modificar la constante
  `ConnectionString`.
- El esquema de la base de datos (tablas, claves primarias y foráneas) se
  genera automáticamente a partir de las entidades mediante
  `Database.EnsureCreated()`, reflejando el diagrama de entidad-relación de
  la documentación.
