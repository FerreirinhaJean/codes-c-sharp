using System;
using System.Collections.Generic;

namespace ListForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = { 3, 9, 4, 8, 20, 15, 63 };

            foreach(int numero in arrayNumeros)
            {
                Console.WriteLine(numero);
            }

            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(5);
            listaNumeros.Add(25);
            listaNumeros.Add(89);
            listaNumeros.Add(1);
            listaNumeros.Add(6);

            Console.WriteLine();

            foreach(int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }

            listaNumeros.Sort();//ordena lista
            Console.WriteLine();
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
