using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OriantaçãoObjetos
{
    internal class Loja
    {
        public void Executar()
        {
            Computador computadorJose = new Computador();
            computadorJose.Processador = "i5 11500H";
            computadorJose.PlacaDeVideo = "GTX 1650 4gb";
            computadorJose.Preco = 4000;

            Computador computadorFrancisco = new Computador();
            computadorFrancisco.Processador = "i7 8700";
            computadorFrancisco.PlacaDeVideo = "GTX 1060 6GB";
            computadorFrancisco.Preco = 2500;

            Computador computadorCristina = new Computador();
            computadorCristina.Processador = "i5 12300";
            computadorCristina.PlacaDeVideo = "RtX 4090";
            computadorCristina.Preco = 18000;

            double total = computadorJose.Preco + computadorFrancisco.Preco + computadorCristina.Preco;

            Console.WriteLine("Computador Jose: " + 
                               "\nProcesador: " + computadorJose.Processador +
                               "\nPlaca de video: " + computadorJose.PlacaDeVideo +
                               "\nPreço: " + computadorJose.Preco +
                               "Computador Francisco: " +
                               "\nProcesador: " + computadorFrancisco.Processador +
                               "\nPlaca de video: " + computadorFrancisco.PlacaDeVideo +
                               "\nPreço: " + computadorFrancisco.Preco +
                               "Computador Cristina: " +
                               "\nProcesador: " + computadorCristina.Processador +
                               "\nPlaca de video: " + computadorCristina.PlacaDeVideo +
                               "\nPreço: " + computadorCristina.Preco);
                                Console.WriteLine("total: " +total);
        }
    }
}
