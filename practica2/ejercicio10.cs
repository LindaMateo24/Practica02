using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            {
                int[] arreglo = new int[10]; // arreglo de tamaño 10

                // llenar el arreglo con números aleatorios entre 1 y 100
                Random random = new Random();
                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i] = random.Next(1, 101);
                }

                Console.WriteLine("Arreglo original:");
                imprimirArreglo(arreglo);

                // ordenar el arreglo de manera descendente utilizando el método de la burbuja
                for (int i = 0; i < arreglo.Length; i++)
                {
                    for (int j = 0; j < arreglo.Length - 1; j++)
                    {
                        if (arreglo[j] < arreglo[j + 1])
                        {
                            int temp = arreglo[j];
                            arreglo[j] = arreglo[j + 1];
                            arreglo[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Arreglo ordenado de manera descendente:");
                imprimirArreglo(arreglo);

                // ordenar el arreglo de manera ascendente utilizando el método de la burbuja
                for (int i = 0; i < arreglo.Length; i++)
                {
                    for (int j = 0; j < arreglo.Length - 1; j++)
                    {
                        if (arreglo[j] > arreglo[j + 1])
                        {
                            int temp = arreglo[j];
                            arreglo[j] = arreglo[j + 1];
                            arreglo[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Arreglo ordenado de manera ascendente:");
                imprimirArreglo(arreglo);
            }
        }
        private static void imprimirArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
        }

    }
}

