using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OriantaçãoObjetos
{
    internal class ListaColaboradoresInterativa
    {
        public void CalcularFolhasDePagamento()
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            Console.Write("Nome: ");
            folhaPagamento.NomeColaborador = Console.ReadLine();
            Console.Write("quantidade de horas trabalhadas: ");
            folhaPagamento.QuantidadeHoras = Convert.ToInt32(Console.ReadLine());
            Console.Write("valor hora: ");
            folhaPagamento.ValorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($@"Folha de pagamento: {folhaPagamento.NomeColaborador}
                                Salario bruto: {folhaPagamento.CalcularSalarioBruto}
                                INSS: {folhaPagamento.CalcularInss}");
        }
    }
}
