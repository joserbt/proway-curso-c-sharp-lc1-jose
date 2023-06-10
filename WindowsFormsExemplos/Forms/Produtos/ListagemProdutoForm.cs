using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Produtos
{
    public partial class ListagemProdutoForm : Form
    {
        public ListagemProdutoForm()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var formulario = new CadastroProdutoForm();
            formulario.Text = "Cadatrar produto";
            formulario.ShowDialog();
        }

        private void ListagemProdutoForm_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            var produtoServico = new ProdutoServico();
            var produtos = produtoServico.ObterTodos();

            //remover todas as linhas do datagrid
            dataGridView1.Rows.Clear();

            //percorrer a a lista dos produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //obter o produto iterado
                var produto = produtos[i];

                //adicionar linha no datagrid com as informações do produto iterado

                dataGridView1.Rows.Add(new object[]
                {
                    produto.Id,
                    produto.Nome,
                    produto.Quantidade,
                    produto.PrecoUnitario
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //obter a linha selecionada do datagrid
            var linhaSelecioanada = dataGridView1.SelectedRows[0];
            //obter o valor da primeira coluna (codito == id) da linha selcionada
            var id = Convert.ToInt32(linhaSelecioanada.Cells[0].Value);

            //instaciando um objeto de classe ProdutoServico
            var produtoServico = new ProdutoServico();

            //chamar método que ira realizar o delete
            produtoServico.Apagar(id);

            //atualizar o datagrid com a lista produtos da tabela de produtos
            ListarProdutos();

        }
    }
}
