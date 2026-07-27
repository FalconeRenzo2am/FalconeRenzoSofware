# Hoja de Seguimiento

| Fecha | Autor | Descripción del cambio |
|------------|----------------|--------------------------------------------------------------------------------------------------|
| 2026-07-14 | Renzo Falcone | Implementación inicial en C# (WinForms + EF Core) de la 1ra iteración: gestión de proveedores, materiales, compras/detalle de compra, empleados e inicio de sesión, según la documentación del TP. |
| 2026-07-26 | Renzo Falcone | Se reemplaza el rol fijo (Administrador/Empleado) por roles configurables (entidades Rol/Permiso): nuevo formulario "Gestionar Roles" accesible desde Empleados, y el menú principal habilita cada pantalla según los permisos del rol logueado. Se agrega botón "Volver" en todos los formularios de gestión. |
| 2026-07-27 | Renzo Falcone | En "Gestionar Empleados" el rol pasa a mostrarse como etiqueta de solo lectura (ya no se puede elegir ahí); un empleado nuevo queda sin rol asignado ("Rol no asignado") hasta que se le asigne uno desde "Gestionar Roles", que ahora incluye una lista de empleados con checkbox para asignar/desasignar el rol seleccionado. |
