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
    public partial class FilmeCadastroForm : Form
    {
        public FilmeCadastroForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            richTextBoxDescricao.Clear();
            numericUpDownMinutos.Value = 0 ;
            comboBoxCategoria.SelectedIndex = -1;
            //combobox é uma lista de intens, ou seja para remover a seleção atribuimos o -1 para o indice do item selecionado
            dateTimePickerDataLancamento.ResetText();
            checkBoxEmmy.Checked = false;
            checkBoxGrammy.Checked = false;
            checkBoxOscar.Checked = false;
            radioButtonFlopouNao.Checked = false;
            radioButtonFlopouSim.Checked = false;
        }
    }
}
