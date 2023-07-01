using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExemplos.Forms.Modelos
{
    internal class Carrinho : ModeloBase
    {
        public Pedido Venda { get; set; }
        public Produto Produto { get; set; } 
        public int Quantidade { get; set; } 
    }
}
