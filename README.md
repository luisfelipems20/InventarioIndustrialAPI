# Inventario Industrial API

API REST desarrollada en C# con ASP.NET Core .NET 8 y Entity Framework Core, conectada a SQL Server. Permite gestionar el inventario de repuestos de una planta industrial con alertas de stock crítico.

## Tecnologías
- C# / .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server 2025
- Swagger / OpenAPI

## Endpoints
| Método | Ruta | Descripción |
|--------|------|-------------|
| GET | /api/Repuestos | Obtener todos los repuestos |
| GET | /api/Repuestos/{id} | Obtener repuesto por ID |
| POST | /api/Repuestos | Agregar nuevo repuesto |
| PUT | /api/Repuestos/{id} | Actualizar repuesto |
| DELETE | /api/Repuestos/{id} | Eliminar repuesto |

## Configuración
1. Clonar el repositorio
2. Crear la base de datos en SQL Server ejecutando el script en `/database/script.sql`
3. Actualizar la cadena de conexión en `appsettings.json`
4. Ejecutar con `dotnet run`

## Autor
Luis Felipe — Técnico en Programación y Análisis de Sistemas
