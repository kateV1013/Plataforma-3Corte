# Catálogo de Cursos - Sistema de Gestión Académica

## 📋 Descripción del Proyecto

Este proyecto implementa un **sistema de gestión de cursos académicos** desarrollado como parte del caso práctico de **Plataformas de Colaboración Digital**. El sistema permite administrar un catálogo de cursos universitarios con funcionalidades completas de consulta, búsqueda y navegación.

### 🎯 Características Principales

- **Aplicación de Consola en C#**: Sistema interactivo con menú de opciones
- **Gestión de 5 Cursos**: Catálogo precargado con información académica completa
- **Búsqueda Inteligente**: Filtrado por nombre con soporte case-insensitive usando LINQ
- **Paginación Eficiente**: Navegación por lotes de 3 cursos para mejor visualización
- **Documentación HTML**: Página web con código fuente completo y sintaxis resaltada
- **Uso Documentado de GitHub Copilot**: Comentarios claros sobre asistencia de IA

---

## 🚀 Instrucciones de Ejecución

### Opción 1: Ejecutar la Aplicación C# (Consola)

#### Requisitos Previos
- **.NET SDK 6.0 o superior** ([Descargar aquí](https://dotnet.microsoft.com/download))
- **Visual Studio 2022**, VS Code, o cualquier editor compatible con C#

#### Pasos para Ejecutar

**Método A: Usando la Terminal (Recomendado)**

```bash
# 1. Crear el proyecto
dotnet new console -n CatalogoCursos
cd CatalogoCursos

# 2. Reemplazar el contenido de Program.cs con el código proporcionado

# 3. Ejecutar la aplicación
dotnet run
```

**Método B: Usando Visual Studio**

1. Abre **Visual Studio 2022**
2. Selecciona: **Crear un nuevo proyecto**
3. Busca y selecciona: **Aplicación de Consola**
4. Nombre del proyecto: `CatalogoCursos`
5. Framework: **.NET 6.0 o superior**
6. Reemplaza todo el contenido de `Program.cs` con el código del proyecto
7. Presiona **F5** o clic en el botón **▶ Ejecutar**

#### Uso del Menú Interactivo

Una vez ejecutado, verás el siguiente menú:

```
╔═══════════════════════════════════════════╗
║     📚 CATÁLOGO DE CURSOS - DEMO        ║
╚═══════════════════════════════════════════╝

[1] 📋 Listar todos los cursos
[2] 🔍 Buscar cursos por nombre
[3] 📄 Ver cursos paginados
[4] 🚪 Salir

Seleccione una opción: _
```

**Opciones disponibles:**

- **[1] Listar todos los cursos**: Muestra los 5 cursos completos con ID, nombre, área y créditos
- **[2] Buscar cursos**: Permite buscar cursos por nombre (ignora mayúsculas/minúsculas)
- **[3] Paginación**: Navega por páginas de 3 cursos usando teclas A (Anterior), S (Siguiente), Q (Salir)
- **[4] Salir**: Cierra la aplicación

---

### Opción 2: Ver la Documentación HTML

El proyecto incluye una página HTML interactiva con el código fuente completo y documentación visual.

#### Pasos para Abrir

**1. Localizar el archivo**
```
📁 Proyecto/
   └── index.html  (o el nombre del archivo HTML proporcionado)
```

**2. Abrir en el navegador**
- **Método 1**: Doble clic en el archivo `index.html`
- **Método 2**: Clic derecho → **Abrir con** → Selecciona tu navegador (Chrome, Firefox, Edge, Safari)
- **Método 3**: Arrastra el archivo hacia una ventana del navegador

**3. Contenido incluido en el HTML**
- ✅ Código fuente completo con resaltado de sintaxis
- ✅ Instrucciones paso a paso de instalación
- ✅ Descripción de todas las funcionalidades
- ✅ Checklist de requisitos cumplidos
- ✅ Documentación sobre uso de GitHub Copilot
- ✅ README embebido en formato visual

---

## 📂 Estructura del Proyecto

```
CatalogoCursos/
│
├── Program.cs              # Código principal de la aplicación C#
├── README.md               # Este archivo (documentación)
├── index.html              # Documentación visual del proyecto
├── CatalogoCursos.csproj   # Archivo de configuración del proyecto .NET
└── bin/                    # Carpeta de salida (generada automáticamente)
    └── Debug/
        └── net6.0/
            └── CatalogoCursos.exe  # Ejecutable compilado
```

---

## ⚙️ Funcionalidades Implementadas

| Funcionalidad | Descripción | Estado |
|---------------|-------------|:------:|
| **Listado completo** | Muestra los 5 cursos registrados con toda su información | ✅ |
| **Búsqueda por nombre** | Filtra cursos usando texto (ignora mayúsculas/minúsculas) | ✅ |
| **Paginación** | Divide los cursos en páginas de 3 elementos navegables | ✅ |
| **Menú interactivo** | Interfaz de consola con opciones numeradas y colores | ✅ |
| **Validación de entrada** | Maneja opciones inválidas con mensajes de error claros | ✅ |
| **Documentación HTML** | Página web con código y documentación completa | ✅ |
| **README completo** | Instrucciones detalladas de instalación y uso | ✅ |

---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje:** C# (.NET 6.0+)
- **Herramientas:** LINQ, Collections, Console API
- **Control de versiones:** Git / GitHub
- **Asistencia IA:** GitHub Copilot (documentado en comentarios)
- **Documentación:** HTML5 + CSS3

---

## 🤖 Uso de GitHub Copilot

Se utilizó **GitHub Copilot** como asistente de programación para:

1. ✅ **Estructura de la clase `Curso`**: Propiedades y método `ToString()`
2. ✅ **Diseño del menú principal**: Layout visual con caracteres especiales
3. ✅ **Lógica de búsqueda con LINQ**: Método `Where()` con comparación case-insensitive
4. ✅ **Implementación de paginación**: Cálculos con `Skip()` y `Take()`

> ⚠️ **Nota importante:** Todas las sugerencias de Copilot fueron revisadas, comprendidas y documentadas en comentarios del código fuente.

---

## 📊 Datos de Ejemplo

El sistema incluye **5 cursos precargados**:

| ID | Nombre del Curso | Área Académica | Créditos |
|:--:|------------------|----------------|:--------:|
| 1 | Algoritmos I | Computación | 4 |
| 2 | Introducción a la Programación | Computación | 3 |
| 3 | Matemática Discreta | Matemáticas | 4 |
| 4 | Bases de Datos | Computación | 3 |
| 5 | Estructuras de Datos | Computación | 4 |

---

## 🎓 Contexto Académico

**Asignatura:** Plataformas de Colaboración Digital  
**Actividad:** Caso Práctico - Coordinación de Tareas con Trello y GitHub  
**Objetivo:** Coordinar trabajo técnico utilizando herramientas digitales (Trello, GitHub, Visual Studio)  
**Institución:** Universidad Autónoma de Nicaragua

---

## 📝 Checklist de Entregables

- [x] Mini app compila y ejecuta correctamente
- [x] Muestra lista de 3-5 cursos estáticos
- [x] Implementa filtro de búsqueda por texto
- [x] Implementa paginación simulada
- [x] README con instrucciones de ejecución
- [x] Comentarios documentando uso de GitHub Copilot
- [x] Código limpio y bien estructurado
- [x] Documentación HTML incluida

---

## 🔧 Solución de Problemas

### Error: "dotnet: command not found"
**Solución:** Instala .NET SDK desde [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

### El programa no muestra caracteres especiales correctamente
**Solución:** Asegúrate de que la línea `Console.OutputEncoding = System.Text.Encoding.UTF8;` esté en el código

### Error de compilación con strings
**Solución:** Agrega `= string.Empty` a las propiedades `Nombre` y `Area` en la clase `Curso`

---

## 👤 Autor

**[Tu Nombre Completo]**  
Universidad Autónoma de Nicaragua  
Carrera: Ingeniería en Sistemas de Información / Ingeniería en Computación  
GitHub: [Tu usuario de GitHub]

---

## 📅 Fecha de Entrega

Noviembre 2025

---

## 📝 Licencia

Este proyecto es de uso académico y educativo exclusivamente.

---

## 🚀 Próximos Pasos

Para continuar mejorando el proyecto, considera:

- [ ] Agregar persistencia de datos (archivo JSON o base de datos)
- [ ] Implementar funcionalidad de agregar/eliminar cursos
- [ ] Crear interfaz gráfica con Windows Forms o WPF
- [ ] Agregar validación de datos de entrada
- [ ] Exportar catálogo a PDF o Excel

---

**¿Preguntas o problemas?** Contacta a tu instructor o revisa la documentación del proyecto en el archivo `index.html`.
