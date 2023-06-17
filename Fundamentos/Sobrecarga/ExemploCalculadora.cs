using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Sobrecarga
{
    internal class ExemploCalculadora : Executor
    {
        public override void Executar()
        {
            var hp = new Calculadora();
            Console.WriteLine("soma: " + hp.Somar(30,10));
        }
    }
}
