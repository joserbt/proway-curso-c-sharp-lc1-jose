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

            dataGridView1.Rows.Add(new object[]
            {
                produto.Nome,
                produto.Quantidade,
                produto.ValorUnitario,
                produto.Quantidade * produto.ValorUnitario
            });
            LimparCampos();
        }
        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxQuantidade.Clear();
            textBoxPrecoUnitario.Clear();
            textBoxNome.Focus();
                
        }
    }
}
