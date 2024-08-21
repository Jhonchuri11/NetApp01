using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creando un objeto 
            Rectangulo rectangulo = new Rectangulo();


            // Definiendo dos variables

            /*
            int area = 0;
            int perimetro = 0;

            rectangulo.Base = 20;
            rectangulo.Altura = 30;

            Console.WriteLine("El area del recatangulo es: ");
            area = rectangulo.CalcularArea();
            Console.WriteLine(area);
            Console.WriteLine("El perimetro del rectangulo es: ");
            perimetro = rectangulo.CalcularPerimetro();
            Console.WriteLine(perimetro);


            Person person = new Person
            {
                Nombres = "Jhon",
                Apellidos = "Churivanti"
            };

            person.AsignarNombresCompletos();
            Console.WriteLine(person.NombresCompletos);


            Profesor profesor = new Profesor
            {
                Nombres = "PRO1",
                Apellidos = "PRO2",
                Sueldo = 2000
            };

            Estudiante estudiante = new Estudiante
            {
                Nombres = "E1",
                Apellidos = "AP1",
                Codigo = 1000
            };

            */

            Rectangular rectangular = new Rectangular
            {
                x1 = 1, y1 = 1,
                x2 = 1, y2 = 4,
                x3 = 5, y3 = 4,
                x4 = 5, y4 = 1  
            };
            rectangular.CalcularBase();
            rectangular.CalcularAltura();
            rectangular.CalcularArea();
            rectangular.CalcularPerimetro();

            Console.WriteLine(rectangular.Base);
            Console.WriteLine(rectangular.Altura);
            Console.WriteLine(rectangular.Area);
            Console.WriteLine(rectangular.Perimetro);



            Console.Read();

            // Base 1 en horizontal
            // (0,8) (4,8)
           
            // 8
            // Base 2 en horizontal

            // (0,0) (4,0)
            // 4

            // Base = 4
            // Altura = 8
            // Area = 32
        }
    }
}
