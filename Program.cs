using System;
using NLog;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace TP2 {
    class Program {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args) {
            CargarAlumnos();
        }

        static public void CargarAlumnos() {
            List<Alumno> ListaAlumnos = new List<Alumno>();
            Console.WriteLine("Ingrese la cantidad de alumnos a agregar");
            try {
                int cantidad = Convert.ToInt32(Console.ReadLine());
                while (cantidad != 0) {
                    Console.WriteLine("Nombre: ");
                    string Nombre = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    string Apellido = Console.ReadLine();
                    Console.WriteLine("DNI: ");
                    int Dni = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Id: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Curso (A/V/F): ");
                    string Curso = Console.ReadLine();
                    Alumno nuevoAlumno = new(Id, Nombre, Apellido, Dni, Curso);
                    nuevoAlumno.mostrarDatos();
                    ListaAlumnos.Add(nuevoAlumno);
                    cantidad--;
                }
            } catch (Exception e) {
                logger.Error("Error: " + e.Message);
                Console.WriteLine("Error: detalles en el log");
            }
            guardarEnCsv(ListaAlumnos);
        }

        static public void guardarEnCsv(List<Alumno> ListaAlumno) {
            try {
                using (var stream = new FileStream("alumnos.csv", FileMode.OpenOrCreate)) {
                    using (var writer = new StreamWriter(stream)) {
                        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) {
                            csv.WriteRecords(ListaAlumno);
                        }
                    }
                }
            } catch (Exception e) {
                logger.Error("Error: " + e.Message);
            }
        }
    }
}
