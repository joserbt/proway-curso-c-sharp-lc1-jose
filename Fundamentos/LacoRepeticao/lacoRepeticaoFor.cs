using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class lacoRepeticaoFor
    {
        public void Executar()
        {
            ExemploRelogio();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Exemplo01()
        {
            for (int indice = 0; indice < 5; indice = indice + 1)
            {
                Console.WriteLine("oiee");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Exemplo02()
        {

            //DateTime é ultilizado para trabalahr com data e hora
            //DateTime.Now pega pega a data e hora atual do sistema operacional
            //.AddYears(1) adiciona 1 ano na data e hora
        }

        private void Exemplo03()
        {
            //solicitar os dados para 4 alunos
            //solicitar nota01, nota02, nota03
            //calcular média
            for(int i = 0; i < 4; i++)
            {
                Console.Write("digite o nome do aluno");
                string nome = Console.ReadLine();
                Console.Write("digite a nota 1: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("digite a nota 2: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("digite a nota 3: ");
                double nota3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("digite a nota 4: ");
                double nota4 = Convert.ToDouble(Console.ReadLine());

                double media = (nota1+nota2+nota3+nota4) / 4;
                Console.WriteLine("a média do aluno " + nome + " é: " +media);

            }
        }
        private void ExemploRelogio()
        {
            for(int hora = 0; hora < 24; hora++)
            {
                for (int minuto = 0; minuto < 60; minuto++)
                {
                    for (int segundos = 0; segundos < 60; segundos++)
                    {
                        Console.Clear();
                        Console.WriteLine(hora + ":" + minuto + ":" + segundos);
                        //delay de 1s
                        Thread.Sleep(1000);
                    }
                }

            }
        }
    }
}
