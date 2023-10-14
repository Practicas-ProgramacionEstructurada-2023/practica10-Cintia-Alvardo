using System;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            do
            {
                Console.WriteLine("\nMenú de opciones");
                Console.WriteLine("1. Cálculo de factorial de un número");
                Console.WriteLine("2. Suma de números enteros hasta n");
                Console.WriteLine("3. Cálculo de la serie de fibonacci");
                Console.WriteLine("4. Declaración y asignación de un arreglo");
                Console.WriteLine("5. Inicialización de un arreglo en la declaración");
                Console.WriteLine("6. Arreglo de cadenas");
                Console.WriteLine("7. Salir");
                Console.Write("\nIngrese su opción");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                   switch (opcion)
                   {
                    case 1:
                        int num = 6;
                        long resultado = Factorial(num);
                        Console.WriteLine($"El factorial de {num} es {resultado}");
                        break;

                    case 2:
                        int NumEnt = 5;
                        int resultadoEnt = SumaNumeros(NumEnt);
                        Console.WriteLine($"La suma de los númersos enteros desde 1 hasta {NumEnt} es {resultadoEnt}");
                        break;

                    case 3:
                        int NumFibo = 10;
                        for (int i = 0; i < NumFibo; i++)
                        {
                            Console.WriteLine(Fibonacci(i) + " ");
                        }
                        break;

                    case 4:
                        int [] numeros = new int [5];
                        numeros[0] = 10;
                        numeros[1] = 20;
                        numeros[2] = 30;
                        numeros[3] = 40;
                        numeros[4] = 50;

                        Console.WriteLine("El pimer elemento del arreglo es: " + numeros[0]);
                        Console.WriteLine("El segundo elemento del arreglo es: " + numeros[1]);
                        break;

                    case 5:
                       int[] numeross = { 01, 20, 30, 40, 50};

                        Console.WriteLine("El pimer elemento del arreglo es: " +  numeross[0]);
                        Console.WriteLine("El segundo elemento del arreglo es: " + numeross[1]);
                        break;

                    case 6:
                        string [] nombres = {"Juan" , "Maria", "Carlos", "Ana"};
                        foreach (string nombre in nombres)
                        {
                           Console.WriteLine("Nombre: " + nombre);
                        }
                        break;

                    case 7:
                        Console.WriteLine("\nSaliendo del Programa.......");
                        break;
                   }
                    
                }
                else
                {
                    Console.WriteLine("\nOpción no válida. Intente de nuevo");
                }
 
            } while (opcion != 7);
        }

        static int Factorial(int n)
        {
            if (n <= 1)
                return 0;
            else
                return n * Factorial(n-1);
        }

        static int SumaNumeros(int n)
        {
            if (n <= 0)
                return 0;
            else
                return n + SumaNumeros(n-1);
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n-1) + Fibonacci(n-2);
        }
    }
}
