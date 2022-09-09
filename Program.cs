using System;
using NLog;

namespace TP2 {
    class Program {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args) {
            Console.WriteLine("Ingrese la cantidad de alumnos a agregar");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            while (cantidad != 0) {
                Alumno nuevoAlumno = new Alumno();
                Console.WriteLine("Nombre: ");
                nuevoAlumno.Nombre = Console.ReadLine();
                Console.WriteLine("Apellido: ");
                nuevoAlumno.Apellido = Console.ReadLine();
                Console.WriteLine("DNI: ");
                nuevoAlumno.Dni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Id: ");
                nuevoAlumno.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Curso (A/V/F): ");
                nuevoAlumno.Apellido = Console.ReadLine();
                nuevoAlumno.mostrarDatos();
                cantidad--;
            }
        }
    }
}
