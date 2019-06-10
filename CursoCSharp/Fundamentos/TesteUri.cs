using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class TesteUri
    {
        public static void Executar()
        { 
            double raio = Convert.ToDouble(Console.ReadLine());
            double area = (3.14159*raio*raio);
            Console.Write($"A={area.ToString("F4")}\n");
        }
    }
}
