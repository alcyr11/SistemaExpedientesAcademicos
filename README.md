# Sistema de Gestión de Expedientes Académicos

## Descripción

Este proyecto consiste en un sistema web desarrollado en ASP.NET Core MVC para la gestión de expedientes académicos.

El sistema permite administrar alumnos, materias y expedientes académicos, incluyendo el registro de notas finales y observaciones. Además, cuenta con una vista estadística que muestra el promedio de notas por alumno mediante gráficas.

---

## Tecnologías Utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap
- Chart.js
- C#
- .NET 8

---

## Funcionalidades

### Gestión de Alumnos
- Agregar alumnos
- Editar alumnos
- Eliminar alumnos
- Visualizar información de alumnos

### Gestión de Materias
- Agregar materias
- Editar materias
- Eliminar materias
- Visualizar materias

### Gestión de Expedientes
- Registrar expedientes académicos
- Asociar alumnos con materias
- Registrar nota final y observaciones
- Editar expedientes
- Eliminar expedientes

### Estadísticas
- Visualización del promedio de notas por alumno
- Gráfica estadística dinámica utilizando Chart.js

---

## Base de Datos

El proyecto utiliza Entity Framework Core con migraciones para la creación y administración de la base de datos.

### Tablas principales
- Alumnos
- Materias
- Expedientes

---

## Cómo Ejecutar el Proyecto

### 1. Clonar el repositorio
### 2. Abrir el proyecto

Abrir la solución en Visual Studio.

### 3. Restaurar paquetes NuGet

Restaurar automáticamente los paquetes NuGet del proyecto.

En caso de que las librerías no sean reconocidas correctamente, instalar o restaurar los siguientes paquetes:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.VisualStudio.Web.CodeGeneration.Design

### 4. Ejecutar migraciones

Abrir la Consola del Administrador de Paquetes y ejecutar:

```powershell
Update-Database
```
### 5. Ejecutar el sistema

Presionar el botón de inicio en Visual Studio (IIS Express o HTTPS) para ejecutar el proyecto.

---

## Autor

Proyecto desarrollado por Alcyr Alexander Figueroa Landaverde

Universidad Don Bosco

