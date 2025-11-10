// Catálogo de Cursos - Aplicación de Consola C#
// Generado con ayuda de GitHub Copilot: Estructura base, clase Curso y menú principal
// Caso Práctico: Plataformas de Colaboración Digital

using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogoCursos
{
    // Generado con ayuda de Copilot: Estructura de la clase Curso
    class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // ✅ Inicializado para evitar NULL
        public string Area { get; set; } = string.Empty;   // ✅ Inicializado para evitar NULL
        public int Creditos { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Nombre} - Área: {Area} ({Creditos} créditos)";
        }
    }

    class Program
    {
        // Lista estática de cursos de ejemplo (3-5 registros según requisitos)
        static List<Curso> cursos = new List<Curso>
        {
            new Curso { Id = 1, Nombre = "Algoritmos I", Area = "Computación", Creditos = 4 },
            new Curso { Id = 2, Nombre = "Introducción a la Programación", Area = "Computación", Creditos = 3 },
            new Curso { Id = 3, Nombre = "Matemática Discreta", Area = "Matemáticas", Creditos = 4 },
            new Curso { Id = 4, Nombre = "Bases de Datos", Area = "Computación", Creditos = 3 },
            new Curso { Id = 5, Nombre = "Estructuras de Datos", Area = "Computación", Creditos = 4 }
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool continuar = true;

            // Generado con ayuda de Copilot: Estructura del menú principal
            while (continuar)
            {
                MostrarMenu();
                string? opcion = Console.ReadLine(); // ✅ Marcado como nullable

                switch (opcion)
                {
                    case "1":
                        ListarTodosCursos();
                        break;
                    case "2":
                        BuscarCursos();
                        break;
                    case "3":
                        PaginarCursos();
                        break;
                    case "4":
                        continuar = false;
                        Console.WriteLine("\n¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("\n❌ Opción no válida. Intente nuevamente.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        // Generado con ayuda de Copilot: Diseño del menú
        static void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║     📚 CATÁLOGO DE CURSOS - DEMO        ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("[1] 📋 Listar todos los cursos");
            Console.WriteLine("[2] 🔍 Buscar cursos por nombre");
            Console.WriteLine("[3] 📄 Ver cursos paginados");
            Console.WriteLine("[4] 🚪 Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");
        }

        // Función para listar todos los cursos
        static void ListarTodosCursos()
        {
            Console.WriteLine("\n📋 === LISTADO COMPLETO DE CURSOS ===");
            Console.WriteLine();
            
            foreach (var curso in cursos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("●");
                Console.ResetColor();
                Console.WriteLine($" {curso}");
            }
            
            Console.WriteLine();
            Console.WriteLine($"Total de cursos: {cursos.Count}");
        }
        // Generado con ayuda de Copilot: Lógica de búsqueda con LINQ
        static void BuscarCursos()
        {
            Console.WriteLine("\n🔍 === BÚSQUEDA DE CURSOS ===");
            Console.Write("Ingrese el término de búsqueda: ");
            string termino = Console.ReadLine() ?? "";

            // Filtro case-insensitive usando LINQ
            var resultados = cursos
                .Where(c => c.Nombre.Contains(termino, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (resultados.Count > 0)
            {
                Console.WriteLine($"\n✅ Se encontraron {resultados.Count} resultado(s):\n");
                foreach (var curso in resultados)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("🔹");
                    Console.ResetColor();
                    Console.WriteLine($" {curso}");
                }
            }
            else
            {
                Console.WriteLine("\n❌ No se encontraron cursos que coincidan con la búsqueda.");
            }
        }

    }
}
