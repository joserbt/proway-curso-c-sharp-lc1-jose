using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.vertorComFor
{
    internal class ExemploVetorComFor
    {
        public void Executar()
        {
            ExemploNumeros();
        }
        private void ExeplosNomes()
        {
            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("nomes: ");
                nomes[i] = Console.ReadLine();
            }

            Console.Clear();
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            
        }
        private void ExemploNumeros()
        {
            int[] numeros = new int[6];
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int soma = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }

            int maiorNumero = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                int numero = numeros[i];
                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }

            int menorNumero = int.MaxValue; //maior valor de um int
            for (int i = 0; i < numeros.Length; i++)
            {
                int numero = numeros[i];
                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }
            }

            double media = soma / Convert.ToDouble(numeros.Length);
            Console.WriteLine($"soma: {soma} \nmédia: {media}"); //interpolação de string
            Console.WriteLine("maior numero: " + maiorNumero);
            Console.WriteLine("menor numero: " + menorNumero);
        }
        //for(declaração;condição;incr)
    }
}
