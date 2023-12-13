using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcialWeb
{
    class Estudiante
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double calificacion { get; set; }

        public Estudiante(string nombre, int edad, double calificacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.calificacion = calificacion;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("El nombre del estudiante es: {0}, su edad: {1} y su calificacion es de {2}",this.nombre,this.edad,this.calificacion);
        }
    }
}
