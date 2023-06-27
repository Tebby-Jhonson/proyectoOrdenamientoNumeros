using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los números uno por uno (ingrese 'fin' para terminar):");

        // Leer los números ingresados por el usuario
        var numeros = new List<int>();
        while (true)
        {
            string entrada = Console.ReadLine();
            if (entrada.ToLower() == "fin")
                break;

            if (int.TryParse(entrada, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido o 'fin' para terminar.");
            }
        }

        // Convertir la lista de números a un array
        int[] array = numeros.ToArray();

        // Aplicar el algoritmo Bubble Sort para ordenar los números
        BubbleSort(array);

        // Imprimir los números ordenados de menor a mayor
        Console.WriteLine("Números ordenados de menor a mayor:");
        foreach (int numero in array)
        {
            Console.Write(numero + " ");
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Intercambiar los elementos
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
