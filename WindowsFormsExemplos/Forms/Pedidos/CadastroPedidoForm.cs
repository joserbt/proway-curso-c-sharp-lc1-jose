using WindowsFormsExemplos.Forms.Modelos;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Pedidos
{
    public partial class CadastroPedidoForm : Form
    {
        private ClienteServico clienteServico;
        private PedidoServico pedidoServico;
        private ProdutoServico produtoServico;

        public CadastroPedidoForm()
        {
            InitializeComponent();
            clienteServico = new ClienteServico();
            pedidoServico = new PedidoServico();
            produtoServico = new ProdutoServico();
        }
        
        internal void ApresentarCamposModoOrcamento()
        {
            AlterarVisibilidade(false);
        }

        internal void ApresentarCamposModoCarrinho()
        {
            AlterarVisibilidade(true);
            PreencherComboboxProdutos();
        }

        private void PreencherComboboxProdutos()
        {
            var produtos = produtoServico.ObterTodos("");

            produtos = produtos.OrderBy(produto => produto.Nome).ToList();

            comboBoxProdutos.Items.Clear();
            foreach(var produto in produtos)
            {
                comboBoxProdutos.Items.Add(produto);
            }
        }

        private void AlterarVisibilidade(bool ehVisivel)
        {
            AlterarVisibilidadeComponentes(
                ehVisivel,
                labelCodigo,
                labelCodigoValor,
                labelProduto,
                labelPrecoUnitario,
                labelPrecoUnitarioValor,
                labelTotal,
                labelTotalValor,
                labelTotalPedido,
                labelTotalPedidoValor,
                labelQuantidade,
                labelCarrinho,
                buttonCancelarPedido,
                buttonFecharPedido,
                buttonAdicionar,
                dataGridViewCarrinho,
                numericUpDownQuantidade,
                comboBoxProdutos
                );
        }

        private void AlterarVisibilidadeComponentes(bool visible, params Control[] componentes)
        {
            foreach (var componente in componentes)
                componente.Visible = visible;
        }

        private void CadastroPedidoForm_Load(object sender, EventArgs e)
        {
            PreencherComboboxClientes();
        }

        private void PreencherComboboxClientes()
        {
            var clientes = clienteServico.ObterTodos();

            //ordenar a lista de clientes (do banco de dados) 
            //para melhorar a experiencia do usuário
            clientes = clientes
                .OrderBy(cliente => cliente.Nome)
                .ToList();

            foreach (var cliente in clientes)
                comboBoxClientes.Items.Add(cliente);
        }

        private void buttonCriarOrcamento_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("escolha o cliente desejado para criar um orçamento");
                return;
            }
            
            //obter o cliente selecionado no combobox
            var clienteEscolhido = (Cliente) comboBoxClientes.SelectedItem;

            //criar o registro na tabela de pedidos do orçamento
            var iPedido = pedidoServico.CriarOrcamento(clienteEscolhido);

            //definir o codigo do orçamento para o usuario ver o codigo
            labelCodigoValor.Text = iPedido.ToString();

            ApresentarCamposModoCarrinho();

            MessageBox.Show($"Orçamento criado para cliente {clienteEscolhido.Nome}");
        }
    }
}

