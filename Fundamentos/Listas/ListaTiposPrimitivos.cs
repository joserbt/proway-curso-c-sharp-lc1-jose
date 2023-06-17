using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Listas
{
    internal class ListaTiposPrimitivos : Executor
    {
        public override void Executar()
        {
            List<string> nomes = new List<string>(); //CRUD = Create
            nomes.Add("Fabiana");
            nomes.Add("Joana");
            nomes.Add("Uélington");
            nomes.Add("Manuell");
            nomes.Add("Robinson");

            Console.WriteLine("Nomes: ");            // CRUD = Read
            Console.WriteLine("index: 0" + nomes[0]);
            Console.WriteLine("index: 1" + nomes[1]);
            Console.WriteLine("index: 2" + nomes[2]);
            Console.WriteLine("index: 3" + nomes[3]);
            Console.WriteLine("index: 4" + nomes[4]);

            //remover nome da lista por nome
            nomes.Remove("Joana");  //CRUD = Delete
            //remover nome da lista por indice
            nomes.RemoveAt(2);

            nomes[1] = nomes[1] + "Da Silva"; //CRUD = Edit

            Console.WriteLine("nomes: ");
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(7);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(8);
            numeros.Add(10);
            int somaComFor = 0;
            
            //somando os numeros da lista
            for (int i = 0; i < numeros.Count; i =+ 1)
                somaComFor = somaComFor + numeros[i];
            //adicionando os indices dos numeros na lista 
            for (int i = 0;i < numeros.Count;i =+ 1)
                Console.WriteLine($"posição {i}: {numeros[i]}");

            Console.WriteLine(somaComFor);

            //consultando se existe o numero na lista
            bool ExisteNumero11NaLista = numeros.Contains(11);
            Console.WriteLine($"existe o numero 11 na lista? {ExisteNumero11NaLista}");
            bool ExisteNumero8NaLista = numeros.Contains(8);
            Console.WriteLine($"existe o numero 11 na lista? {ExisteNumero8NaLista}");

            //retorna -1 pq n existe o numero 11 na lista
            //buscandi o indice do numero na lista
            int indiceNumero11NaLista = numeros.IndexOf(11);
            Console.WriteLine($"Indice do numeros 11: {indiceNumero11NaLista}");

            //tipos primitivos: string, int, short, long, byte, float, double, decimal, bool, char, object
            //https://bit.ly/41U8o76
        }
    }
}
