using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Forms.Modelos;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Clientes
{
    public partial class CadastroClienteForm : Form
    {
        private ClienteServico clienteServico;

        public CadastroClienteForm()
        {
            InitializeComponent();
            clienteServico = new ClienteServico();
        }

        private void maskedTextBoxCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarEnderecoPorCep();
            }
        }

        private void BuscarEnderecoPorCep()
        {
            var cep = maskedTextBoxCEP.Text;
            var url = $"https://viacep.com.br/ws/{cep}/json/";

            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(url).GetAwaiter().GetResult();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseText = response.Content.ReadAsStringAsync().Result;
                var endereco = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                comboBoxEstado.SelectedItem = endereco["uf"].ToUpper();
                textBoxCidade.Text = endereco["localidade"];
                textBoxBairro.Text = endereco["bairro"];
                textBoxLogradouro.Text = endereco["logradouro"];
                textBoxNumero.Focus();
            }
        }

        private void maskedTextBoxCEP_Leave(object sender, EventArgs e)
        {
            BuscarEnderecoPorCep();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var cpf = maskedTextBoxCPF.Text;
            var dataNacimento = dateTimePickerDataNascimento.Value;

            var estado = comboBoxEstado.SelectedItem.ToString();
            var cidade = textBoxCidade.Text.Trim();
            var bairro = textBoxBairro.Text.Trim();
            var cep = maskedTextBoxCEP.Text;
            var logradouro = textBoxLogradouro.Text.Trim(); ;
            var numero = textBoxNumero.Text.Trim();
            var complemento = richTextBoxComplemento.Text;

            var cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.DataNascimento = dataNacimento;

            cliente.Endereco = new Endereco();

            cliente.Endereco.Estado = estado;
            cliente.Endereco.Cidade = cidade;
            cliente.Endereco.Bairro = bairro;
            cliente.Endereco.Cep = cep;
            cliente.Endereco.Logradouro = logradouro;
            cliente.Endereco.Numero = numero;
            cliente.Endereco.Complemento = complemento;

            clienteServico.Cadastrar(cliente);
        }
    }
}
