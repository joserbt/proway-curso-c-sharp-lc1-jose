using ProWayModelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms
{
    public partial class ProdutoCadatroSimplificadoForm : Form
    {
        private int indiceLinhaEdicao = -1; //Não esta no modo de edição
        public ProdutoCadatroSimplificadoForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelListaProdutos_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = textBoxNome.Text.Trim();
            produto.Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            produto.ValorUnitario = Convert.ToDouble(textBoxPrecoUnitario.Text);

            //
            if (indiceLinhaEdicao == -1)
            {
                dataGridView1.Rows.Add(new object[]
                {
                produto.Nome,
                produto.Quantidade,
                produto.ValorUnitario,
                produto.Quantidade * produto.ValorUnitario
                });
            }
            else
            {
                dataGridView1.Rows[indiceLinhaEdicao].Cells[0].Value = produto.Nome;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[1].Value = produto.Quantidade;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[0].Value = produto.ValorUnitario;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[3].Value = produto.Quantidade * produto.ValorUnitario;
                indiceLinhaEdicao = -1;
            }
            LimparCampos();
        }
        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxQuantidade.Clear();
            textBoxPrecoUnitario.Clear();
            textBoxNome.Focus();
                
        }

        //CRUD
        // C = Create
        // R = Read
        // U = Update
        // D = Delete
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //obtendo o indice da linha selecionada
            int indiceLihaSelecionanda = dataGridView1.SelectedRows[0].Index;

            //removendo a linha selecioanada do datagrid
            dataGridView1.Rows.RemoveAt(indiceLihaSelecionanda);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaEdicao = dataGridView1.SelectedRows[0].Index;

            string nome = dataGridView1.Rows[indiceLinhaEdicao].Cells[0].Value.ToString();
            int quantidade = Convert.ToInt32(dataGridView1.Rows[indiceLinhaEdicao].Cells[1].Value);
            double valorUnitario = Convert.ToDouble(dataGridView1.Rows[indiceLinhaEdicao].Cells[2].Value);

            textBoxNome.Text = nome;
            textBoxQuantidade.Text = quantidade.ToString;
            textBoxPrecoUnitario.Text = valorUnitario.ToString;
        }
    }
}
