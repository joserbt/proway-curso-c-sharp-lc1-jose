using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OriantaçãoObjetos
{
    internal class ListaColaboradores
    {
        public void CalcularFolhasPagamentos()
        {
            FolhaPagamento jose = new FolhaPagamento();
            jose.NomeColaborador = "José";
            jose.QuantidadeHoras = 160;
            jose.ValorHora = 60;
            double salarioJosé = jose.CalcularSalarioBruto();
            double inssJose = jose.CalcularInss();

            FolhaPagamento matheus = new FolhaPagamento();
            matheus.NomeColaborador = "José";
            matheus.QuantidadeHoras = 160;
            matheus.ValorHora = 60;
            double salarioMathues = matheus.CalcularSalarioBruto();
            double inssMatheus = matheus.CalcularInss();

            FolhaPagamento francisco = new FolhaPagamento();
            francisco.NomeColaborador = "José";
            francisco.QuantidadeHoras = 160;
            francisco.ValorHora = 60;
            double salarioFrancisco = francisco.CalcularSalarioBruto();
            double inssFrancisco = francisco.CalcularInss();

            Console.WriteLine($@"Folha de pagamento {francisco.NomeColaborador}
                                Salario Líquido: {salarioFrancisco}
                                inss: {inssFrancisco}
                                Folha de pagamento {matheus.NomeColaborador}
                                Salario Líquido: {salarioMathues}
                                inss: {inssMatheus}   
                                Folha de pagamento {jose.NomeColaborador}
                                Salario Líquido: {salarioJosé}
                                inss: {inssJose}");
        }
    }
}