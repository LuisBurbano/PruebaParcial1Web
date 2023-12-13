using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcialWeb
{
    class EstudianteGraduado:Estudiante
    {
        public string titulo { get; set; }
        public EstudianteGraduado(string nombre, int edad, double calificacion, string titulo): base(nombre, edad, calificacion)
        {
            this.titulo = titulo;
        }

        public new void MostrarInformacion()
        {
            Console.WriteLine("El nombre del estudiante es: {0}, su edad: {1}, su calificacion es de {2} y su titulo es: {3}", this.nombre, this.edad, this.calificacion, this.titulo);
        }
    }
}
