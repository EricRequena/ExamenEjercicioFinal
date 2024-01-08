using System;
namespace Examen
{
    public class Program
    {
        public static void Main()
        {

        }
        public static void MostrarMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("a. Validar si un nombre és senar");
            Console.WriteLine("b. Calcular la potència d'un nombre");
            Console.WriteLine("c. Retornar un valor aleatori");
            Console.WriteLine("d. Comptar el nombre de vocals o consonants en un text");
            Console.WriteLine("e. Sortir");
            Console.Write("Selecciona una opció: ");
        }
        public static void ValidarSenar()
        {
            Console.Write("Introdueix un nombre per validar si és senar: ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            if (nombre / 2 == 0)
            {
                Console.WriteLine("Es Senar");
            }
            else
            {
                Console.WriteLine("No es senar");
            }
        }
        public static double CalculaPotencia()
        {
            Console.Write("Introdueix la base: ");
            double baseNombre = ValidarNombre();

            Console.Write("Introdueix l'exponent: ");
            double exponent = ValidarNombre();

            return Math.Pow(baseNombre, exponent);
        }
    }
}


