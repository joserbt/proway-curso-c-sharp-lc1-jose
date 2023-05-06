namespace WindowsFormsExemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            int quantidadeHoras = Convert.ToInt32(textBoxQuantidadeHorasTrabalhadas.Text);
            double valorHora = Convert.ToDouble(textBoxValorHora.Text);

            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.NomeColaborador = nome;
            folhaPagamento.QuantidadeHoras = quantidadeHoras;
            folhaPagamento.ValorHora = valorHora;

            MessageBox.Show($@"
                            Folha de pagamento: {folhaPagamento.NomeColaborador}
                            salario bruto: {folhaPagamento.CalcularSalarioBruto():C}
                            deconto inss: {folhaPagamento.CalcularInss():C}");
        }
    }
}