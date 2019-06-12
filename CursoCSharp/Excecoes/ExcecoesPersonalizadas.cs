using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class NegativoExpection : Exception {
        public NegativoExpection() {;}

        public NegativoExpection(string message) : base(message) {;}

        public NegativoExpection(string message, Exception inner) : base(message, inner) {;}
    }

    public class ImparException : Exception {
        public ImparException(string message) : base(message) {;}
    }
    class ExcecoesPersonalizadas
    {
        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if(valor < 0)
                throw new NegativoExpection("Número negativo... :(");

            if(valor % 2 == 1) 
                throw new ImparException("Valor ímpar... :(");
            
            return valor;
        }
        public static void Executar() {
            try {
                Console.WriteLine(PositivoPar());
            } catch(NegativoExpection ex) {
                Console.WriteLine(ex.Message);
            } catch(ImparException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
