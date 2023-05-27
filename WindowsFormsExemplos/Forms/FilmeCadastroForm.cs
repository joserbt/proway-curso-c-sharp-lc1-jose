using Newtonsoft.Json;
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
    public partial class FilmeCadastroForm : Form
    {
        List<Filme> filmes = new List<Filme>();
        int codigo = 1;

        public FilmeCadastroForm()
        {
            InitializeComponent();
        }

        private void FilmeCadastroForm_Load(object sender, EventArgs e)
        {
            LerFilmesArquivosJson();
            AdicionarFilmesDataGridView(filmes);
            LimparCampos();
        }

        private void AdicionarFilmesDataGridView(List<Filme> filmes)
        {
            dataGridView.Rows.Clear();

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                dataGridView.Rows.Add(new object[]
                {
                    filme.Codigo
                    , filme.Nome
                });
            }

            labelQuantidadeValor.Text = filmes.Count.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            richTextBoxDescricao.Clear();
            numericUpDownMinutos.Value = 0;
            comboBoxCategoria.SelectedIndex = -1;
            //combobox é uma lista de intens, ou seja para remover a seleção atribuimos o -1 para o indice do item selecionado
            dateTimePickerDataLancamento.ResetText();
            checkBoxEmmy.Checked = false;
            checkBoxGrammy.Checked = false;
            checkBoxOscar.Checked = false;
            radioButtonFlopouNao.Checked = false;
            radioButtonFlopouSim.Checked = false;
            labelCodigoEditar.Text = "";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var codigoParaEditar = labelCodigoEditar.Text;

            if (codigoParaEditar == "")
            {
                AdicionarNovoFilme(nome);
            }
            else
            {
                EditarFilme(nome, codigoParaEditar);
            }
            SalvarFilmesEmAruivoJson();
            AdicionarFilmesDataGridView(filmes);
        }

        private void EditarFilme(string nome, string codigoParaEditar)
        {
            for(int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                if (filme.Codigo.ToString() == codigoParaEditar)
                {
                    filme.Nome = nome;
                }
            }
        }

        private void AdicionarNovoFilme(string nome)
        {
            var filme = new Filme();
            filme.Nome = nome;
            filme.Codigo = codigo;
            codigo++;

            filmes.Add(filme);
        }

        private void SalvarFilmesEmAruivoJson()
        {
            //serializando a lista, iremos tranformas a lista de objetos (filmes) em uma string contendo o JSON

            var filmesSerializados = JsonConvert.SerializeObject(filmes);
            File.WriteAllText(
                "C:\\Users\\73343\\Desktop\\filmes.json", filmesSerializados);
        }

        private void LerFilmesArquivosJson()
        {

            if (File.Exists("C:\\Users\\73343\\Desktop\\filmes.json") == false)
            {
                return;
            }

            var arquivoLinhas = File.ReadAllText(
                "C:\\Users\\73343\\Desktop\\filmes.json");

            var filmesDeserializados = JsonConvert
                .DeserializeObject<List<Filme>>(arquivoLinhas);

            filmes = filmesDeserializados;
            ObterProximoCodigoDosFilmes();
        }
        private void ObterProximoCodigoDosFilmes()
        {
            var maiorCodigo = 0;

            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                if (filme.Codigo == maiorCodigo)
                {
                    maiorCodigo = filme.Codigo;
                }
            }

            maiorCodigo++;
            codigo = maiorCodigo;
        }

        private void pesquisar()
        {
            var textoParaPesquisa = textBoxPesquisa.Text;
            var filmesFiltrados = new List<Filme>();

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Nome.ToLower().Contains(textoParaPesquisa))
                {
                    filmesFiltrados.Add(filme);
                }
            }

            AdicionarFilmesDataGridView(filmesFiltrados);
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            //
            if (e.KeyCode == Keys.Enter)
            {
                pesquisar();
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("nenhum filme cadastrado");
                return;
            }

            //pegar a linha selecionanda
            var linhaSelecionada = dataGridView.SelectedRows[0];
            var codigoParaApagar = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            //percorre a lista de filme buscando o filme que contem o código escolhido pelo usuário
            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                if (filme.Codigo == codigoParaApagar)
                {
                    filmes.Remove(filme);
                    break;
                }
            }
            SalvarFilmesEmAruivoJson();
            AdicionarFilmesDataGridView(filmes);
            MessageBox.Show($"Filme apagado com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("nenhum filme cadastrado");
                return;
            }

            var linhaSelecionada = dataGridView.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();

            textBoxNome.Text = nome;

            labelCategoria.Text = codigo.ToString();
        }
    }
}
