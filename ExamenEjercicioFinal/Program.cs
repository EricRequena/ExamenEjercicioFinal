﻿using System;
namespace Examen
{
    public class Program
    {
        public static void Main()
        {
            char opcio;

            do
            {
                MostrarMenu();
                opcio = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcio)
                {
                    case 'a':
                        ValidarSenar();
                        break;
                    case 'b':
                        CalculaPotencia();
                        break;
                    case 'c':
                        Console.WriteLine(RetornaAleatori());
                        break;
                    case 'd':
                        ComptaVocalsConsonants();
                        break;
                    case 'e':
                        Console.WriteLine("Programa finalitzat. Fins aviat!");
                        break;
                    default:
                        Console.WriteLine("Opció no vàlida. Si us plau, tria una opció correcta.");
                        break;
                }

            } while (opcio != 'e');

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
        public static int RetornaAleatori()
        {
            Random rand = new Random();
            int rangInferior, rangSuperior;
            Console.WriteLine("Introdueix el Rang Superior");
            rangSuperior = Convert.ToInt32(Console.ReadLine());
            rangInferior = Convert.ToInt32(Console.ReadLine());
            return rand.Next(rangInferior, rangSuperior + 1);
        }
        static void ComptaVocalsConsonants()
        {
            int vocals = 0;
            int consonants = 0;

            string text;

            Console.WriteLine("Introdueix el text");
            text = Console.ReadLine();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiouAEIOU".Contains(c))
                        vocals++;
                    else
                        consonants++;
                }
            }
        }
    }
    public static double ValidarNombre()
    {
        double nombre;
        while (!double.TryParse(Console.ReadLine(), out nombre) || nombre < 0)
        {
            Console.WriteLine("Si us plau, introdueix un nombre natural vàlid.");
        }
        return nombre;
    }
}


