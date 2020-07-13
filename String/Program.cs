using System;


namespace FormatacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Jean Gabriel Ferreira";

            //REPLACE
            string a = texto.Replace("Gabriel","Eduardo");
            Console.WriteLine(a);
            Console.WriteLine();

            //SUBSTRING
            string b = texto.Substring(0, 5);
            Console.WriteLine(b);
            Console.WriteLine();

            //LENGTH
            int tamanho = texto.Length;
            Console.WriteLine(tamanho);
            Console.WriteLine();

            //SPLIT
            string[] arrayTexo = texto.Split(" ");
            Console.WriteLine("\nSPLIT");
            foreach (string line in arrayTexo)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            //JOIN
            Console.WriteLine();
            string c = String.Join(" ", arrayTexo);
            Console.WriteLine(c);
            Console.WriteLine();


            //CONTAINS
            if (texto.Contains("Jean"))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.WriteLine();

            //REMOVE
            string d = texto.Remove(5, 8);
            Console.WriteLine("REMOVE");
            Console.WriteLine(d);
            Console.WriteLine();


            //INSERT
            texto = texto.Insert(texto.Length," TESTE");
            Console.WriteLine("INSERT");
            Console.WriteLine(texto);
            Console.WriteLine();





        }
    }
}
