using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    internal class lacoRepeticaoWhile
    {
        //Método sem retorno, dica void
        //Metodo sem parâmetros, dica n tem variáveis dentro dos ()
        public void Executar()
        {
            int opcaoDesejada = 0;
            while(opcaoDesejada != 8001)
            {
                
                Console.WriteLine("\n 1 = Exemplo 01 " + 
                                "\n 2 = Exemplo 02 " +
                                "\n 3 = exemplo 03");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                if (opcaoDesejada == 1)
                {
                    Exemplo01();
                }
                else if (opcaoDesejada == 2)
                {
                    Exemplo02();
                }
                else if (opcaoDesejada == 3)
                {
                    Exemplo03();
                }
                else if(opcaoDesejada != 8001)
                {
                    Console.WriteLine("opção inválida");
                   
                }
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            //Exemplo01();
            //Exemplo02();
            Exemplo03();
        }
        public void Exemplo01()
        {
            int indice = 0;
            while(indice < 10)
            {
                indice++;
                Console.WriteLine("oie");
                //indice = indice + 1;
            }
            Console.WriteLine("terminou o exemplo de while");
        }
        /// <summary>
        /// solicitar nome e sobrenome para 3 usuarios
        /// </summary>
        public void Exemplo02()
        {
            int indice = 0;
            while(indice < 3)
            //input
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine().Trim();
            Console.WriteLine("sobrenome: ");
            string sobrenome = Console.ReadLine().Trim();
            
            //processamento
            string nomeCompleto = nome + "" + sobrenome;

            //output
            Console.WriteLine("nome completo: " + nomeCompleto);
            indice = indice + 1;

        }
        /// <summary>
        /// exemplo pedis para o usuário a quantidade de notas que deseja cadastrar, solicitando-as.
        /// </summary>
        public void Exemplo03()
        {
            Console.Write("digite a quantidade de notas a registrar: ");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

            int indice = 0;
            double somaNotas = 0;
            double maiorNota = 0;
            double menorNota = 10;
            while (indice < quantidadeDesejada)
            {
                Console.Write("Nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                somaNotas = somaNotas + nota;

                if(nota > maiorNota)
                {
                    maiorNota = nota;
                }

                if(nota < menorNota)
                {
                    menorNota = nota;
                }

                indice = indice + 1;

            }
            double media = somaNotas / quantidadeDesejada;
            Console.WriteLine("média: "+ media +
                              "\n menor nota: " +menorNota +
                              "\n maior nota: " + maiorNota);
            
        }
    }
}
