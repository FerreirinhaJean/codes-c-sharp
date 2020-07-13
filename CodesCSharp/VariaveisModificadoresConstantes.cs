using System;
using System.Collections.Generic;
using System.Text;

namespace CodesCSharp
{
    class VariaveisModificadoresConstantes
    {

        //VARIAVEIS

        //declaração de variaveis começa com letras ou _
        //modificador de acesso padrão private;
        int numero;
        int _numero;


        //MODIFICADORES
        public int idade;//public acesso não restrito
        protected string nome;//O acesso é limitado às classes ou tipos derivados daclasse que a variável está.
        internal int a;//O acesso é limitado ao conjunto de módulos(assembly) corrente.
        protected internal int b;//O acesso é limitado ao conjunto corrente ou tiposderivados da classe recipiente.
        private int c;//O acesso é limitado à classe que a variável está.

        //TIPOS DE DADOS VALUE TYPES
        byte d;//0 ..255
        sbyte e;//-128 ..127
        short f;//-32,768 ..32,767
        ushort g;//0 ..65,535
        int h;//-2,147,483,648 ..2,147,483,647
        uint i;//0 ..4,294,967,295
        long j;//-9,223,372,036,854,775,808..9,223,372,036,854,775,807
        ulong k;//0 ..18,446,744,073,709,551,615
        float l;//-3.402823e38 ..3.402823e38
        double m;//-1.79769313486232e308 ..1.79769313486232e308
        decimal n;//-79228162514264337593543950335..79228162514264337593543950335
        char o;//U+0000 .. U+ffff


        //CONTANTES
        const double MEDIDA = 10.5;

    }
}
