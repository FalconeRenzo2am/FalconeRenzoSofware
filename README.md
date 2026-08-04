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

Además:
- **Roles configurables**: desde "Gestionar Empleados" hay un botón **Crear
  Rol** que abre un formulario para crear/editar roles, eligiendo a qué
  pantallas del sistema da acceso cada uno (tildando permisos) y qué
  empleados lo tienen asignado (tildando empleados). El menú principal
  habilita o deshabilita cada botón según los permisos del rol del empleado
  logueado.
- **Asignación de rol solo desde "Gestionar Roles"**: en "Gestionar
  Empleados" el rol se muestra como una etiqueta de solo lectura, no se
  puede elegir ahí. Un empleado recién creado queda con **"Rol no
  asignado"** (sin ningún permiso) hasta que alguien con acceso a
  "Gestionar Roles" lo asigne a un rol.
- **Botón Volver**: todos los formularios de gestión (Proveedores,
  Materiales, Compras, Detalle de Compra, Empleados, Roles) tienen un botón
  "Volver" que cierra la pantalla actual y devuelve el control a la anterior,
  sin necesidad de cerrar la ventana con la X.
- **Reportes y Gráficos**: pantalla estilo dashboard con indicadores (KPIs) y
  8 reportes/gráficos (barras verticales y horizontales, torta y líneas,
  todos dibujados a mano con GDI+, sin librerías externas), adaptados a lo
  que existe en el sistema (compras, stock y proveedores; no hay ventas ni
  clientes):
  - KPIs: total comprado histórico, comprado este mes, materiales distintos
    comprados, cantidad de proveedores, stock total disponible y materiales
    en stock crítico.
  - Reportes: Stock por Material, Compras por Proveedor, Compras por Mes
    (con filtro de fechas), Materiales más Comprados, Compras por Categoría
    (según el Tipo del material), Estado del Stock (normal/bajo/sin stock),
    Evolución del Stock (con filtro de fechas) y Materiales sin Movimiento.
  - El "stock crítico" se calcula contra un nuevo campo editable en
    Materiales: **Stock mínimo** (umbral por material, no confundir con el
    stock actual que sigue siendo de solo lectura).
- **Patrón Singleton**: el acceso a la base de datos pasa por una única
  instancia (`Datos/ConexionBD`), en vez de que cada Controladora arme su
  propia conexión por su cuenta.

## Arquitectura

El proyecto sigue la arquitectura en capas reflejada en los diagramas de
secuencia de la documentación (Interfaz → Controladora → Entidad):

- `Modelos/` – Entidades del dominio (Persona, Empleado, Proveedor, Material,
  Compra, DetalleCompra, Rol, Permiso, ReporteItem, IndicadoresDashboard).
- `Datos/` – `AppDbContext` (Entity Framework Core, persistencia en SQL
  Server LocalDB) y `ConexionBD` (Singleton: punto único de acceso a la
  base de datos).
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
   datos `GestionMaterialesConstruccionDB_v6` en `(localdb)\mssqllocaldb` si
   no existe, junto con dos roles (Administrador y Empleado) y un usuario
   administrador de prueba:
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
- Si venías de una versión anterior del proyecto, el nombre de la base de
  datos cambió (ahora `GestionMaterialesConstruccionDB_v6`) para que se
  genere de cero con el esquema más reciente, sin necesidad de borrar nada
  a mano. Cada vez que cambia el modelo de datos de forma incompatible con
  lo ya creado en tu LocalDB, va a aparecer un nombre de base nuevo acá.
- El stock (`Cantidad`) de un material no se carga ni edita a mano desde
  "Gestionar Materiales": arranca en 0 y solo se modifica al confirmar
  líneas de Detalle de Compra (repone stock) o al eliminarlas (lo revierte).
- Cada material tiene un `PrecioUnitario` editable desde "Gestionar
  Materiales", junto con el `Valor total` (Cantidad × PrecioUnitario)
  calculado y mostrado en el propio formulario. El dashboard de "Reportes y
  Gráficos" agrega el KPI "Valor total del stock" con la suma de todos los
  materiales.
- En el reporte "Estado del Stock" (gráfico de torta), los colores son fijos
  según el significado: rojo = sin stock, amarillo = stock bajo, verde =
  stock normal.
- Todos los formularios usan `AutoScaleMode.Font`, con la fuente base en
  "Segoe UI, 12pt" (antes 9pt): esto agranda proporcionalmente todos los
  controles y el tamaño de cada ventana, para que se vea cómodo en pantallas
  de notebook más chicas o de mayor densidad de píxeles.
