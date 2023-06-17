using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Listas
{
    internal class ListaDeObjetos : Executor
    {
        public override void Executar()
        {
            List<Filme> filmes = new List<Filme>();

            Filme dragonBallEvolution = new Filme();
            dragonBallEvolution.Nome = "Dragon Ball Evolution";
            dragonBallEvolution.Duracao = 85;
            dragonBallEvolution.Categoria = filmeCategoriaEnum.LiveAction;
            filmes.Add(dragonBallEvolution);

            Filme beethovenMagnifico = new Filme();
            beethovenMagnifico.Nome = "Beethoven o magnifico";
            beethovenMagnifico.Duracao = 87;
            beethovenMagnifico.Categoria = filmeCategoriaEnum.Comedia;
            filmes.Add(beethovenMagnifico);

            Filme mortalKombat = new Filme();
            mortalKombat.Nome = "Mortal Kombat";
            mortalKombat.Duracao = 113;
            mortalKombat.Categoria = filmeCategoriaEnum.LiveAction;
            filmes.Add(mortalKombat);

            Filme noLimiteAmanha = new Filme();
            noLimiteAmanha.Nome = "No limite do amanhã";
            noLimiteAmanha.Duracao = 113;
            noLimiteAmanha.Categoria = filmeCategoriaEnum.LiveAction;
            filmes.Add(noLimiteAmanha);

            Filme guardioesDaGalaxia = new Filme();
            guardioesDaGalaxia.Nome = "Guardiões da Galaxia vol.3";
            guardioesDaGalaxia.Duracao = 150;
            guardioesDaGalaxia.Categoria = filmeCategoriaEnum.Acao;
            filmes.Add(guardioesDaGalaxia);

            Console.WriteLine("Lista de filmes sem For: ");
            Console.WriteLine(filmes[0].Nome);
            Console.WriteLine(filmes[0].Duracao);
            Console.WriteLine(filmes[0].Categoria);

            Console.WriteLine(filmes[1].Nome);
            Console.WriteLine(filmes[1].Duracao);
            Console.WriteLine(filmes[1].Categoria);

            Console.WriteLine(filmes[2].Nome);
            Console.WriteLine(filmes[2].Duracao);
            Console.WriteLine(filmes[2].Categoria);

            Console.WriteLine(filmes[3].Nome);
            Console.WriteLine(filmes[3].Duracao);
            Console.WriteLine(filmes[3].Categoria);

            Console.WriteLine("=========================");

            Console.WriteLine("lista de filmes com for");
            for(int i = 0 ; i < filmes.Count; i++)
            {
                Console.WriteLine(filmes[i].Nome);
                Console.WriteLine(filmes[i].Duracao);
                Console.WriteLine(filmes[i].Categoria);
            }
        }

        enum filmeCategoriaEnum
        {
            Comedia,
            LiveAction, 
            Acao
        }
        class Filme
        {
            public string Nome;
            public ushort Duracao;
            public filmeCategoriaEnum Categoria;
        }
    }
}
