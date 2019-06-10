using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar() {
            //Acessar a variavel 'a' dentro do método executar;
            //var teste = new DesafioAtributo();
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a); 
        }
    }
}
