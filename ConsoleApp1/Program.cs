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

            Console.Read();


        }
    }
}
