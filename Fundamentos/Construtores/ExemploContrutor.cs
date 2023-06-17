using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Construtores
{
    internal class ExemploContrutor : Executor
    {
        public override void Executar()
        {
            var computadorJose = new Computador(
                "intel core i5 11th",
                MemoriaRamEnum.Memoria32gb,
                500,
                1024);
            

            var computadorLeilane = new Computador(
                "itel core i5 11th",
                MemoriaRamEnum.Memoria32gb,
                500,
                512);
            

            var computadorLuiz = new Computador(
                "intel core i7 5th",
                MemoriaRamEnum.Memoria16gb,
                500,
                1024);
        }
    }
}
