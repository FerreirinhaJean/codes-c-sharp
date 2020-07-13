using System;

namespace ConversoesDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERSÕES IMPLICITAS
            /*De   ->  Para
             sbyte ->  short , int, long, float, double, ou decimal
             byte  ->  short , ushort, int, uint, long, ulong, float, double, ou decimal
             short ->  int , long, float, double, ou decimal
             ushort -> int , uint, long, ulong, float, double, ou decimal
             int   ->  long , float, double, ou decimal
             uint  ->  long , ulong, float, double, ou decimal
             long  ->  float , double, ou decimal*/

            //CHAR->INT
            int codigo = 'X';//aspas simples
            // conversão implícita do valor do tipo char "X" 
            // para o tipo inteiro que corresponde a seu código ASCII
            Console.WriteLine(codigo);// será exibido o valor 88, codigo ASCII para o caractere "X"

            //INTEIROS EM EXPRESSÔES
            var x = 15 / 2;//inteiro 7
            var y = 15 / 2.0;//double 7.5
                             
            //VAR
            var a = 5;//a é convertido para o tipo int
            var b = 5.0;//b é convertido para o tipo double

            //CONVERSÃO EXPLICITA
            byte c = 5;
            short d = (short)c;
            int e = (int)d;
            long f = (long)e;
            float g = (long)e;
            double h = (float)g;


            //CONVERSÕES EXPLICITAS
            /*De  ->  Para
            sbyte ->  short , int, long, float, double, ou decimal
            byte  ->  short , ushort, int, uint, long, ulong, float, double, ou decimal
            short ->  int , long, float, double, ou decimal
            ushort -> int , uint, ong, ulong, float, double, ou decimal
            int   ->  long , float, double, ou decimal
            uint  ->  long , ulong, float, double, ou decimal
            long  ->  float , double, ou decimal*/









        }
    }
}
