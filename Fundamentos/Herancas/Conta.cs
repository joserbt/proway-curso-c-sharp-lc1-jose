using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Herancas
{
    public class Conta
    {
        //propriedades 

        public decimal Saldo { get; set; }
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public DateTime DataAbertura { get; set; }

        public void Depositar(decimal valor)
        {
            //adicionar o valor de deposito junto ao saldo da conta
            Saldo += valor;
        }

        //virtual: permite que classes filhas modifiquem comportamentos do metodo da classe pai
        public virtual string ObterExtrato()
        {
            var extrato = $"nome: {Cliente}\nSaldo: {Saldo}";
            return extrato;
        }
    }
}
