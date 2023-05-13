﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonFolhaPagamento_Click(object sender, EventArgs e)
        {
            Form1 folhaPagamentoForm = new Form1();
            folhaPagamentoForm.ShowDialog();
        }

        private void buttonCadastroSimplificadoProduto_Click(object sender, EventArgs e)
        {
            ProdutoCadatroSimplificadoForm form = new ProdutoCadatroSimplificadoForm();
            form.ShowDialog();
        }
    }
}
