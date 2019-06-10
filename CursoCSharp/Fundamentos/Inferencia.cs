using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonam";
            Console.WriteLine(nome);

            //int idade
            var idade = 21;
            Console.WriteLine(idade);

            int a;
            a = 2;
            int b = 1;

            Console.WriteLine(a + b);

            Console.ReadKey();
        }
    }
}