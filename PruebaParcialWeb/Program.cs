using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaParcialWeb
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1
            int numero1 = 5;
            int numero2 = 7;
            int resultado = 0;
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Suma de {0} y {1}", numero1, numero2);
            resultado = Ejercicio1Suma(numero1, numero2);
            Console.WriteLine("El resultado es: {0}",resultado);


            //Ejercicio 2
            Console.WriteLine("Ejercicio 2");
            int edad = 19;
            Console.WriteLine("El edad es: {0}", edad);
            Ejercicio2Control(edad);

            //Ejercicio 3
            Console.WriteLine("Ejercicio 3");
            Estudiante estudiante1 = new Estudiante("Luis", 24, 18.4);

            Console.WriteLine("El nombre del estudiante es: {0}, su edad es: {1} y su calificacion es: {2}"
                ,estudiante1.nombre, estudiante1.edad,estudiante1.calificacion);

            //Ejercicio 4
            Console.WriteLine("Ejercicio 4");
            estudiante1.MostrarInformacion();


            //Ejericio 5
            Console.WriteLine("Ejercicio 5");
            EstudianteGraduado graduado1 = new EstudianteGraduado("Luis", 23, 17.4, "Ingeniero");
            graduado1.MostrarInformacion();
            Console.WriteLine("Pulse cualquier tecla para cerrar el programa");
            Console.ReadKey();
        }

        static int Ejercicio1Suma(int n1, int n2)
        {
            
            return n1+n2;
        }
        static void Ejercicio2Control(int edad)
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
        }
    }
}
