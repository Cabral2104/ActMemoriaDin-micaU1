using System;
using System.Collections.Generic;

namespace UsoMemoriaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de array dinámico (List)
            List<int> numeros = new List<int>();

            Console.WriteLine("Ingrese números para agregar al array dinámico (ingrese -1 para finalizar):");
            int numero = int.Parse(Console.ReadLine());

            while (numero != -1)
            {
                numeros.Add(numero);
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray dinámico ingresado:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }

            // Ejemplo de matriz dinámica (array de arrays)
            Console.Write("\n\nIngrese el número de filas para la matriz dinámica: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas para la matriz dinámica: ");
            int columnas = int.Parse(Console.ReadLine());

            int[][] matriz = new int[filas][];
            for (int i = 0; i < filas; i++)
            {
                matriz[i] = new int[columnas];
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    matriz[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz dinámica ingresada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

