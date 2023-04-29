using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Vetores
{
    internal class ExemploVetor
    {
        public void Executar()
        {
            ExemplosNomes();
        }
         private void ExemplosNomes()
        {
            string[] nomes = new string[3];
            nomes[0] = "Lucas";
            nomes[1] = "Ana";
            nomes[2] = "fabricio";
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

        }
    }
}
