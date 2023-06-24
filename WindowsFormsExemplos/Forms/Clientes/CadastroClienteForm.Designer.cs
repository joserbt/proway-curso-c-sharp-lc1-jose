namespace WindowsFormsExemplos.Forms.Clientes
{
    partial class CadastroClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelCpf = new Label();
            labelDataNascimento = new Label();
            dateTimePickerDataNascimento = new DateTimePicker();
            labelEstado = new Label();
            comboBoxEstado = new ComboBox();
            labelCidade = new Label();
            labelBairro = new Label();
            labelCEP = new Label();
            textBoxCidade = new TextBox();
            textBoxBairro = new TextBox();
            textBoxLogradouro = new TextBox();
            labelLogradouro = new Label();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            labelComplemento = new Label();
            richTextBoxComplemento = new RichTextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            maskedTextBoxCEP = new MaskedTextBox();
            buttonCadastrar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(319, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(12, 67);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(28, 15);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(162, 67);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(112, 15);
            labelDataNascimento.TabIndex = 4;
            labelDataNascimento.Text = "Data de nascimento";
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataNascimento.Location = new Point(162, 85);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(169, 23);
            dateTimePickerDataNascimento.TabIndex = 5;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(12, 122);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 6;
            labelEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstado.Location = new Point(12, 140);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(144, 23);
            comboBoxEstado.TabIndex = 7;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(162, 122);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(44, 15);
            labelCidade.TabIndex = 8;
            labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(12, 181);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 9;
            labelBairro.Text = "Bairro";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(162, 181);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(28, 15);
            labelCEP.TabIndex = 10;
            labelCEP.Text = "CEP";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(162, 140);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(169, 23);
            textBoxCidade.TabIndex = 11;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(12, 199);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(144, 23);
            textBoxBairro.TabIndex = 12;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(12, 252);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(319, 23);
            textBoxLogradouro.TabIndex = 15;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(12, 234);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 14;
            labelLogradouro.Text = "Logradouro";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(12, 306);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(319, 23);
            textBoxNumero.TabIndex = 17;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(12, 288);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 16;
            labelNumero.Text = "Numero";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(12, 343);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 18;
            labelComplemento.Text = "Complemento";
            // 
            // richTextBoxComplemento
            // 
            richTextBoxComplemento.Location = new Point(12, 370);
            richTextBoxComplemento.Name = "richTextBoxComplemento";
            richTextBoxComplemento.Size = new Size(319, 185);
            richTextBoxComplemento.TabIndex = 19;
            richTextBoxComplemento.Text = "";
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(12, 85);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(144, 23);
            maskedTextBoxCPF.TabIndex = 20;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(162, 199);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(169, 23);
            maskedTextBoxCEP.TabIndex = 21;
            maskedTextBoxCEP.KeyDown += maskedTextBoxCEP_KeyDown;
            maskedTextBoxCEP.Leave += maskedTextBoxCEP_Leave;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(12, 567);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(319, 23);
            buttonCadastrar.TabIndex = 22;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // CadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 603);
            Controls.Add(buttonCadastrar);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(richTextBoxComplemento);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(labelNumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(labelLogradouro);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxCidade);
            Controls.Add(labelCEP);
            Controls.Add(labelBairro);
            Controls.Add(labelCidade);
            Controls.Add(comboBoxEstado);
            Controls.Add(labelEstado);
            Controls.Add(dateTimePickerDataNascimento);
            Controls.Add(labelDataNascimento);
            Controls.Add(labelCpf);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "CadastroClienteForm";
            Text = "CadastroClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelCpf;
        private Label labelDataNascimento;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelEstado;
        private ComboBox comboBoxEstado;
        private Label labelCidade;
        private Label labelBairro;
        private Label labelCEP;
        private TextBox textBoxCidade;
        private TextBox textBoxBairro;
        private TextBox textBoxLogradouro;
        private Label labelLogradouro;
        private TextBox textBoxNumero;
        private Label labelNumero;
        private Label labelComplemento;
        private RichTextBox richTextBoxComplemento;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBoxCEP;
        private Button buttonCadastrar;
    }
}