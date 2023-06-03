using Newtonsoft.Json;
using ProWayModelos;
using System.Data;

namespace WindowsFormsExemplos.Forms
{
    public partial class FilmeCadastroForm : Form
    {
        List<Filme> filmes = new List<Filme>();
        int codigo = 1;
        string caminhoArquivoJsonFilmeDesktop = "";

        public FilmeCadastroForm()
        {
            caminhoArquivoJsonFilmeDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                            Path.DirectorySeparatorChar + "filmes.json";
            InitializeComponent();
        }

        private void FilmeCadastroForm_Load(object sender, EventArgs e)
        {
            LerFilmesArquivosJson();
            AdicionarFilmesDataGridView(filmes);
            LimparCampos();
            prencherComboBoxCategoria();
        }

        private void AdicionarFilmesDataGridView(List<Filme> filmes)
        {
            dataGridView.Rows.Clear();

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                dataGridView.Rows.Add(new object[]
                {
                    filme.Codigo,
                    filme.Nome,
                    filme.Categoria,
                    filme.Minutos
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
            numericUpDownMinutos.Value = numericUpDownMinutos.Minimum;
            comboBoxCategoria.SelectedIndex = -1;
            //combobox é uma lista de intens, ou seja para remover a seleção atribuimos o -1 para o indice do item selecionado
            dateTimePickerDataLancamento.ResetText();
            checkBoxEmmy.Checked = false;
            checkBoxGrammy.Checked = false;
            checkBoxOscar.Checked = false;
            radioButtonFlopouNao.Checked = true;
            radioButtonFlopouSim.Checked = false;
            labelCodigoEditar.Text = "";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var codigoParaEditar = labelCodigoEditar.Text;
            var minutos = Convert.ToUInt16(numericUpDownMinutos.Value);
            var vitoriaOscar = checkBoxOscar.Checked;
            var vitoriaGrammy = checkBoxGrammy.Checked;
            var vitoriaEmmy = checkBoxEmmy.Checked;
            var flopou = radioButtonFlopouSim.Checked;
            var descricao = richTextBoxDescricao.Text;
            var dataLancamento = dateTimePickerDataLancamento.Value;

            if (dataLancamento >= DateTime.Today)
            {
                MessageBox.Show("data de lançamento deve ser menor que a data atual");
            }

            if (comboBoxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("escolha uma categoria!");
                return;
            }
            var categoria = (FilmeCategoria)comboBoxCategoria.SelectedItem;
            //comboBoxCategoria

            var filme = new Filme();
            if (codigoParaEditar != "")
            {
                filme = obterFilmeParaEditar(codigoParaEditar);
            }
            filme.Nome = nome;
            filme.Minutos = minutos;
            filme.VitoriaOscar = vitoriaOscar;
            filme.VitoriaGrammy = vitoriaGrammy;
            filme.VitoriaEmmy = vitoriaEmmy;
            filme.Flopou = flopou;
            filme.Descricao = descricao;
            filme.Datalancamento = dataLancamento;
            filme.Categoria = categoria;

            if (codigoParaEditar == "")
            {
                AdicionarNovoFilme(filme);
            }

            SalvarFilmesEmAruivoJson();
            AdicionarFilmesDataGridView(filmes);
            LimparCampos();
        }

        private Filme obterFilmeParaEditar(string codigoParaEditar)
        {
            //percorrer lista de filme buscando pelo codigo do filme que sera alterado as informações
            for (int i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                //verificar se algum filme contem o codigo para editar
                if (filme.Codigo.ToString() == codigoParaEditar)
                {
                    return filme;
                }
            }

            //neste caso não exite um filme com codigoParaEditar
            return null;
        }

        private void AdicionarNovoFilme(Filme filme)
        {

            filme.Codigo = codigo;
            codigo++;

            filmes.Add(filme);
        }

        private void SalvarFilmesEmAruivoJson()
        {
            //serializando a lista, iremos tranformas a lista de objetos (filmes) em uma string contendo o JSON

            var filmesSerializados = JsonConvert.SerializeObject(filmes);
            File.WriteAllText(
                caminhoArquivoJsonFilmeDesktop, filmesSerializados);
        }

        private void LerFilmesArquivosJson()
        {

            if (File.Exists(caminhoArquivoJsonFilmeDesktop) == false)
            {
                return;
            }

            var arquivoLinhas = File.ReadAllText(
                caminhoArquivoJsonFilmeDesktop);

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
            var codigo = linhaSelecionada.Cells[0].Value.ToString();
            var filme = obterFilmeParaEditar(codigo);

            textBoxNome.Text = filme.Nome;
            labelCodigoEditar.Text = codigo;
            dateTimePickerDataLancamento.Value = filme.Datalancamento;
            checkBoxEmmy.Checked = filme.VitoriaEmmy;
            checkBoxGrammy.Checked = filme.VitoriaGrammy;
            checkBoxOscar.Checked = filme.VitoriaOscar;
            richTextBoxDescricao.Text = filme.Descricao;
            numericUpDownMinutos.Value = filme.Minutos;

            if (filme.Flopou == true)
            {
                radioButtonFlopouSim.Checked = true;
            }
            else
            {
                radioButtonFlopouNao.Checked = true;
            }


            labelCodigoEditar.Text = codigo.ToString();
        }

        private void prencherComboBoxCategoria()
        {
            //obter lista de categorias de A a Z
            var categorias = Enum.GetValues<FilmeCategoria>().OrderBy(x => x).ToList();
            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.SelectedIndex = -1;
        }

        
    }
}
