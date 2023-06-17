using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Construtores
{
    internal class Computador
    {
        public string ModeloComputador { get; set; }

        public string ModeloProcessador { get; set; }

        public MemoriaRamEnum MemoriaRam { get; set; }

        public string ModeloMemoriaRam { get; set; }

        public string ModeloPlacaMae { get; set; }

        public string ModeloArmazenamento { get; set; }

        public int Armazenamento { get; set; }

        public string ModeloFonte { get; set; }
        
        public int CapacidadeFonte { get; set; }


        //contrutor tem como objetivo garantir que o obejto sera contrusido criado com as
        //propriedades necessarias preenchidas para o correto funcioanamento
        
        //escapsulamento + nome da classe(parametros)
        public Computador(
            string modeloProcessador,
            MemoriaRamEnum memoriaRam,
            int capacidadeFonte,
            int armazenamento)
        {
            // propriedaade = parâmetro
            Armazenamento = armazenamento;
            MemoriaRam = memoriaRam;
            CapacidadeFonte = capacidadeFonte;
            ModeloProcessador = modeloProcessador;
        }
    }
}
