using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2 {
    class Alumno {
        int id;
        string nombre;
        string apellido;
        int dni;
        string curso;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Curso { get => curso; set => curso = value; }

        public void mostrarDatos() {
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Apellido: " + this.Apellido);
            Console.WriteLine("DNI: " + this.Dni);
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Curso: " + NombreCurso(this.curso));
        }

        private static string NombreCurso(string CodigoCurso) {
            string NombreCompleto;
            switch (CodigoCurso) {
                case "A":
                    NombreCompleto = "Atletismo";
                    break;
                case "V":
                    NombreCompleto = "Voley";
                    break;
                case "F":
                    NombreCompleto = "Futbol";
                    break;
                default: NombreCompleto = "Error";
                    break;
            }
            return NombreCompleto;
        }
    }
}
