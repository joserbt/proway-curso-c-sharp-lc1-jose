using WindowsFormsExemplos.Servicos;
using static WindowsFormsExemplos.Repositorios.ProdutoRepositorio;

namespace WindowsFormsExemplos.Forms.Produtos
{
    public partial class CadastroProdutoForm : Form
    {

        private int idProdutoEditar = -1;

        //construtor é chamado qaundo é modo cadastro
        public CadastroProdutoForm()
        {
            InitializeComponent();
        }

        //construtor é chamado qaundo é modo editar
        public CadastroProdutoForm(Produto produtoEscolhido)
        {
            InitializeComponent();
            textBoxNome.Text = produtoEscolhido.Nome;
            textBoxPrecoUnitario.Text = produtoEscolhido.PrecoUnitario.ToString();
            textBoxQuantidade.Text = produtoEscolhido.Quantidade.ToString();
            idProdutoEditar = produtoEscolhido.Id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            var precoUnitario = Convert.ToDecimal(textBoxPrecoUnitario.Text);

            var produtoServico = new ProdutoServico();

            if(idProdutoEditar == -1)
            {
                produtoServico.Cadastrar(nome, precoUnitario, quantidade);

                MessageBox.Show("produto cadastrado com sucesso");
            }
            else
            {
                produtoServico.Editar(idProdutoEditar, nome, precoUnitario, quantidade);
                MessageBox.Show("produto alterado com sucesso");
            }
        }
    }
}
