using WindowsFormsExemplos.Enums;
using WindowsFormsExemplos.Forms.Modelos;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    internal class PedidoServico
    {
        private PedidoRepositorio pedidoRepositorio;

        public PedidoServico()
        {
            pedidoRepositorio = new PedidoRepositorio();
        }

        internal int CriarOrcamento(Cliente clienteEscolhido)
        {
            var pedido = new Pedido();
            pedido.Cliente = clienteEscolhido;
            pedido.Status = PedidoStatus.Orcamento;

            var pedidoId = pedidoRepositorio.CriarOrcamento(pedido);

            return pedidoId;
        }
    }
}
