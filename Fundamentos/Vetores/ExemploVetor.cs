using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fundamentos.Vetores
{
    internal class ExemploVetor
    {
        public void Executar()
        {
            Exercicio();
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

        private void Numeros()
        {
            //Numeros().Length: é o tamanho do vetor
            int [] numeros = new int[6];
            numeros[0] = 30;
            numeros[1] = 21;
            numeros[2] = 29;
            numeros[3] = 27;
            numeros[4] = 52;
            numeros[5] = 10;

            int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5];
            Console.WriteLine("soma: " + soma);
            Console.WriteLine("média: " + soma / numeros.Length);
        }

        private void ExemploProdutos()
        {
            string[] nomes = new string[3];
            double[] precosUnitarios = new double[3];
            int[] quantidades = new int[3];
            double[] totalProdutos = new double[3];
            
            //input
            Console.Write("produto: ");
            nomes[0] = Console.ReadLine().Trim();
            Console.Write("preço unitario; ");
            precosUnitarios[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("quantidade: ");
            quantidades[0] = Convert.ToInt32(Console.ReadLine());
            
            //processamento
            totalProdutos[0] = precosUnitarios[0] * quantidades[0];
            Console.WriteLine("preço do produto: " + totalProdutos[0]);

            //input
            Console.Write("produto: ");
            nomes[1] = Console.ReadLine().Trim();
            Console.Write("preço unitario; ");
            precosUnitarios[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("quantidade: ");
            quantidades[1] = Convert.ToInt32(Console.ReadLine());

            //processamento
            totalProdutos[1] = precosUnitarios[1] * quantidades[1];
            Console.WriteLine("preço do produto: " + totalProdutos[1]);

            //input
            Console.Write("produto: ");
            nomes[2] = Console.ReadLine().Trim();
            Console.Write("preço unitario; ");
            precosUnitarios[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("quantidade: ");
            quantidades[2] = Convert.ToInt32(Console.ReadLine());

            //processamento
            totalProdutos[2] = precosUnitarios[2] * quantidades[2];
            Console.WriteLine("preço do produto: " + totalProdutos[2]);

            //output
            double precoTotal = (totalProdutos[0] + totalProdutos[1] + totalProdutos[2]);
            Console.WriteLine("total a pagar: "+ precoTotal);
        }
        
        private void Exercicio()
        {
            //peso / altura *2
            string[] nome = new string[3];
            double[] altura = new double[3];
            double[] peso = new double[3];
            double[] calcularImc = new double[3];

            Console.Write("nome: ");
            nome[0] = Console.ReadLine();
            Console.Write("peso: ");
            peso[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("altura: ");
            altura[0] = Convert.ToDouble(Console.ReadLine());

            calcularImc[0] = (peso[0] / altura[0]) * 2;
            Console.WriteLine("imc: " + calcularImc[0]);

            Console.WriteLine("==================");

            Console.Write("nome: ");
            nome[1] = Console.ReadLine();
            Console.Write("peso: ");
            peso[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("altura: ");
            altura[1] = Convert.ToDouble(Console.ReadLine());

            calcularImc[1] = (peso[1] / altura[1]) * 2;
            Console.WriteLine("imc: " + calcularImc[1]);

            Console.WriteLine("==================");

            Console.Write("nome: ");
            nome[2] = Console.ReadLine();
            Console.Write("peso: ");
            peso[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("altura: ");
            altura[2] = Convert.ToDouble(Console.ReadLine());

            calcularImc[2] = (peso[2] / altura[2]) * 2;
            Console.WriteLine("imc: " + calcularImc[2]);

            Console.WriteLine("==================");
        }
    }
}   
