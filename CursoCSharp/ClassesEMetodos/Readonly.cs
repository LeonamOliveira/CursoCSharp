using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    public class Cliente {
        public string Nome;
        public readonly DateTime Nascimento;
        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, 
                Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
    {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());

            //novoCliente.Nascimento = new DateTime(2020, 10, 10);
        }
    }
}
