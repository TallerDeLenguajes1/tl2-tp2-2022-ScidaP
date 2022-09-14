using System;
using NLog;
using CsvHelper;

namespace TP2 {
    class Program {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args) {
            Console.WriteLine("Ingrese la cantidad de alumnos a agregar");
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
                cantidad--;
            }
        }
    }
}
