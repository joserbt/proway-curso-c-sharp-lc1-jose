﻿namespace WindowsFormsExemplos.Forms
{
    partial class FilmeCadastroForm
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
            dataGridView = new DataGridView();
            ColumnCodigo = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnDuracao = new DataGridViewTextBoxColumn();
            labelListaFilmes = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelMinutos = new Label();
            numericUpDownMinutos = new NumericUpDown();
            labelCategoria = new Label();
            comboBoxCategoria = new ComboBox();
            checkBoxOscar = new CheckBox();
            checkBoxGrammy = new CheckBox();
            checkBoxEmmy = new CheckBox();
            labelPesquisa = new Label();
            buttonCancelar = new Button();
            radioButtonFlopouSim = new RadioButton();
            radioButtonFlopouNao = new RadioButton();
            richTextBoxDescricao = new RichTextBox();
            labelFlopou = new Label();
            labelDescricao = new Label();
            labelDataLancamento = new Label();
            dateTimePickerDataLancamento = new DateTimePicker();
            labelQuantidadeValor = new Label();
            labelQuantidade = new Label();
            buttonSalvar = new Button();
            buttonEditar = new Button();
            buttonApagar = new Button();
            labelVitorias = new Label();
            textBoxPesquisa = new TextBox();
            labelCodigoEditar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnCodigo, ColumnNome, ColumnCategoria, ColumnDuracao });
            dataGridView.Location = new Point(12, 53);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(514, 608);
            dataGridView.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            ColumnCodigo.HeaderText = "Código";
            ColumnCodigo.MinimumWidth = 6;
            ColumnCodigo.Name = "ColumnCodigo";
            ColumnCodigo.ReadOnly = true;
            ColumnCodigo.Width = 125;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.MinimumWidth = 6;
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            ColumnNome.Width = 125;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.MinimumWidth = 6;
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            ColumnCategoria.Width = 125;
            // 
            // ColumnDuracao
            // 
            ColumnDuracao.HeaderText = "Duração";
            ColumnDuracao.MinimumWidth = 6;
            ColumnDuracao.Name = "ColumnDuracao";
            ColumnDuracao.ReadOnly = true;
            ColumnDuracao.Width = 125;
            // 
            // labelListaFilmes
            // 
            labelListaFilmes.AutoSize = true;
            labelListaFilmes.Font = new Font("Futura Md BT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelListaFilmes.ForeColor = SystemColors.MenuHighlight;
            labelListaFilmes.Location = new Point(12, 22);
            labelListaFilmes.Name = "labelListaFilmes";
            labelListaFilmes.Size = new Size(117, 18);
            labelListaFilmes.TabIndex = 1;
            labelListaFilmes.Text = "Lista de filmes";
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNome.Location = new Point(615, 43);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(343, 27);
            textBoxNome.TabIndex = 2;
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(615, 20);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // labelMinutos
            // 
            labelMinutos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMinutos.AutoSize = true;
            labelMinutos.Location = new Point(615, 82);
            labelMinutos.Name = "labelMinutos";
            labelMinutos.Size = new Size(62, 20);
            labelMinutos.TabIndex = 4;
            labelMinutos.Text = "Minutos";
            // 
            // numericUpDownMinutos
            // 
            numericUpDownMinutos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownMinutos.Location = new Point(615, 105);
            numericUpDownMinutos.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownMinutos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMinutos.Name = "numericUpDownMinutos";
            numericUpDownMinutos.Size = new Size(343, 27);
            numericUpDownMinutos.TabIndex = 5;
            numericUpDownMinutos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelCategoria
            // 
            labelCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(615, 144);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(615, 167);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(344, 28);
            comboBoxCategoria.TabIndex = 7;
            // 
            // checkBoxOscar
            // 
            checkBoxOscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxOscar.AutoSize = true;
            checkBoxOscar.Location = new Point(615, 233);
            checkBoxOscar.Name = "checkBoxOscar";
            checkBoxOscar.Size = new Size(68, 24);
            checkBoxOscar.TabIndex = 8;
            checkBoxOscar.Text = "Oscar";
            checkBoxOscar.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrammy
            // 
            checkBoxGrammy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxGrammy.AutoSize = true;
            checkBoxGrammy.Location = new Point(615, 263);
            checkBoxGrammy.Name = "checkBoxGrammy";
            checkBoxGrammy.Size = new Size(87, 24);
            checkBoxGrammy.TabIndex = 9;
            checkBoxGrammy.Text = "Grammy";
            checkBoxGrammy.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmmy
            // 
            checkBoxEmmy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxEmmy.AutoSize = true;
            checkBoxEmmy.Location = new Point(615, 293);
            checkBoxEmmy.Name = "checkBoxEmmy";
            checkBoxEmmy.Size = new Size(72, 24);
            checkBoxEmmy.TabIndex = 10;
            checkBoxEmmy.Text = "Emmy";
            checkBoxEmmy.UseVisualStyleBackColor = true;
            // 
            // labelPesquisa
            // 
            labelPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(172, 23);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(65, 20);
            labelPesquisa.TabIndex = 11;
            labelPesquisa.Text = "Pesquisa";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(679, 657);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // radioButtonFlopouSim
            // 
            radioButtonFlopouSim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonFlopouSim.AutoSize = true;
            radioButtonFlopouSim.Location = new Point(772, 233);
            radioButtonFlopouSim.Name = "radioButtonFlopouSim";
            radioButtonFlopouSim.Size = new Size(55, 24);
            radioButtonFlopouSim.TabIndex = 13;
            radioButtonFlopouSim.Text = "Sim";
            radioButtonFlopouSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlopouNao
            // 
            radioButtonFlopouNao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonFlopouNao.AutoSize = true;
            radioButtonFlopouNao.Checked = true;
            radioButtonFlopouNao.Location = new Point(772, 263);
            radioButtonFlopouNao.Name = "radioButtonFlopouNao";
            radioButtonFlopouNao.Size = new Size(58, 24);
            radioButtonFlopouNao.TabIndex = 14;
            radioButtonFlopouNao.TabStop = true;
            radioButtonFlopouNao.Text = "Não";
            radioButtonFlopouNao.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxDescricao.Location = new Point(615, 425);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(344, 217);
            richTextBoxDescricao.TabIndex = 15;
            richTextBoxDescricao.Text = "";
            // 
            // labelFlopou
            // 
            labelFlopou.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFlopou.AutoSize = true;
            labelFlopou.Location = new Point(772, 210);
            labelFlopou.Name = "labelFlopou";
            labelFlopou.Size = new Size(62, 20);
            labelFlopou.TabIndex = 16;
            labelFlopou.Text = "Flopou?";
            // 
            // labelDescricao
            // 
            labelDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(615, 402);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(74, 20);
            labelDescricao.TabIndex = 17;
            labelDescricao.Text = "Descrição";
            // 
            // labelDataLancamento
            // 
            labelDataLancamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDataLancamento.AutoSize = true;
            labelDataLancamento.Location = new Point(615, 335);
            labelDataLancamento.Name = "labelDataLancamento";
            labelDataLancamento.Size = new Size(144, 20);
            labelDataLancamento.TabIndex = 18;
            labelDataLancamento.Text = "Data de lançamento";
            // 
            // dateTimePickerDataLancamento
            // 
            dateTimePickerDataLancamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerDataLancamento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataLancamento.Location = new Point(615, 358);
            dateTimePickerDataLancamento.Name = "dateTimePickerDataLancamento";
            dateTimePickerDataLancamento.Size = new Size(343, 27);
            dateTimePickerDataLancamento.TabIndex = 19;
            // 
            // labelQuantidadeValor
            // 
            labelQuantidadeValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelQuantidadeValor.AutoSize = true;
            labelQuantidadeValor.Location = new Point(416, 669);
            labelQuantidadeValor.Name = "labelQuantidadeValor";
            labelQuantidadeValor.Size = new Size(87, 20);
            labelQuantidadeValor.TabIndex = 20;
            labelQuantidadeValor.Text = "Quantidade";
            // 
            // labelQuantidade
            // 
            labelQuantidade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(509, 669);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(17, 20);
            labelQuantidade.TabIndex = 21;
            labelQuantidade.Text = "0";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSalvar.Location = new Point(790, 657);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 22;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(530, 123);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 62);
            buttonEditar.TabIndex = 23;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonApagar.Location = new Point(530, 53);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 62);
            buttonApagar.TabIndex = 24;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // labelVitorias
            // 
            labelVitorias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelVitorias.AutoSize = true;
            labelVitorias.Location = new Point(615, 210);
            labelVitorias.Name = "labelVitorias";
            labelVitorias.Size = new Size(59, 20);
            labelVitorias.TabIndex = 25;
            labelVitorias.Text = "Vitorias";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPesquisa.Location = new Point(243, 20);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(362, 27);
            textBoxPesquisa.TabIndex = 26;
            textBoxPesquisa.TextChanged += textBoxPesquisa_TextChanged;
            textBoxPesquisa.KeyDown += textBoxPesquisa_KeyDown;
            // 
            // labelCodigoEditar
            // 
            labelCodigoEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCodigoEditar.AutoSize = true;
            labelCodigoEditar.Location = new Point(671, 20);
            labelCodigoEditar.Name = "labelCodigoEditar";
            labelCodigoEditar.Size = new Size(0, 20);
            labelCodigoEditar.TabIndex = 27;
            labelCodigoEditar.Visible = false;
            // 
            // FilmeCadastroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(994, 698);
            Controls.Add(labelCodigoEditar);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelVitorias);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Controls.Add(labelQuantidade);
            Controls.Add(labelQuantidadeValor);
            Controls.Add(dateTimePickerDataLancamento);
            Controls.Add(labelDataLancamento);
            Controls.Add(labelDescricao);
            Controls.Add(labelFlopou);
            Controls.Add(richTextBoxDescricao);
            Controls.Add(radioButtonFlopouNao);
            Controls.Add(radioButtonFlopouSim);
            Controls.Add(buttonCancelar);
            Controls.Add(labelPesquisa);
            Controls.Add(checkBoxEmmy);
            Controls.Add(checkBoxGrammy);
            Controls.Add(checkBoxOscar);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(numericUpDownMinutos);
            Controls.Add(labelMinutos);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(labelListaFilmes);
            Controls.Add(dataGridView);
            Name = "FilmeCadastroForm";
            Text = "Filmes";
            Load += FilmeCadastroForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label labelListaFilmes;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelMinutos;
        private NumericUpDown numericUpDownMinutos;
        private Label labelCategoria;
        private ComboBox comboBoxCategoria;
        private CheckBox checkBoxOscar;
        private CheckBox checkBoxGrammy;
        private CheckBox checkBoxEmmy;
        private Label labelPesquisa;
        private Button buttonCancelar;
        private RadioButton radioButtonFlopouSim;
        private RadioButton radioButtonFlopouNao;
        private RichTextBox richTextBoxDescricao;
        private Label labelFlopou;
        private Label labelDescricao;
        private Label labelDataLancamento;
        private DateTimePicker dateTimePickerDataLancamento;
        private Label labelQuantidadeValor;
        private Label labelQuantidade;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelVitorias;
        private TextBox textBoxPesquisa;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnDuracao;
        private Label labelCodigoEditar;
    }
}