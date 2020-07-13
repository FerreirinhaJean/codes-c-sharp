using System;


namespace FormatacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Jean Gabriel Ferreira";

            //REPLACE
            Console.WriteLine("REPLACE");
            string a = texto.Replace("Gabriel","Eduardo");
            Console.WriteLine(a);
            Console.WriteLine();

            //SUBSTRING
            Console.WriteLine("SUBSTRING");
            string b = texto.Substring(0, 5);
            Console.WriteLine(b);
            Console.WriteLine();

            //LENGTH
            Console.WriteLine("LENGTH");
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
            Console.WriteLine("JOIN");
            string c = String.Join(" ", arrayTexo);
            Console.WriteLine(c);
            Console.WriteLine();


            //CONTAINS
            Console.WriteLine("CONTAINS");
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

            //STARTS WITH
            if (texto.StartsWith("Jean")) //verifica se string começa com palavra na condição
            {
                //true
            }
            else
            {
                //false
            }

            //ENDS WITH
            if (texto.EndsWith("Ferreira"))//verifica se string termina com palavra na condição
            {
                //true
            }
            else
            {
                //false
            }

            //COMPARANDO STRINGS
            if (texto.Equals(a))//verifica se as duas string são iguais
            {
                //true
            }
            else
            {
                //false
            }

            int resultado = texto.CompareTo(a);//compara se uma string é maior, igual ou menor que outra
            //-1 se a primeira string for menor que a segunda
            //0 se forem iguais
            //1 se a primeira string for maior que a segunda


            //INDEXOF
            int indice = texto.IndexOf("g");//retorna o indice do primeiro elemento encontrado dentro da string

            //LAST INDEXOF
            indice = texto.LastIndexOf("g");//retorna o indice do ultimo elemento encontrado dentro da string

            //IsNullOrEmpty
            if (!String.IsNullOrEmpty(texto))
            {
                //se não for nula ou vazia
            }
            else
            {
                //se for nula ou vazia
            }


            //Trim, TrimStart e TrimEnd
            string z = "    carro da fiat    ";
            Console.WriteLine("Trim, TrimStart e TrimEnd");
            Console.WriteLine("Trim:"+z.Trim());//remove espaços em brancos no inicio e fim da string
            Console.WriteLine("TrimStart:" + z.TrimStart());//remove espaço em braco no inicio da string
            Console.WriteLine("TrimEnd:" + z.TrimEnd());//remove espaço em branco no final da string

            //PadLeft e PadRight  
            string acessos = "12900";
            acessos = acessos.PadLeft(8, '0');//8 = total de caracteres finais da string, adiciona 3 caracteres '0' no inicio da string
            Console.WriteLine("\nAcesso do blog  = " + acessos);
        }
    }
}
