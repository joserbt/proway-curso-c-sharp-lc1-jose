namespace WindowsFormsExemplos.Forms.Produtos
{
    partial class CadastroProdutoForm
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
            textBoxNome = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxPrecoUnitario = new TextBox();
            buttonSalvar = new Button();
            labelPrecoUnitario = new Label();
            labelQuantidade = new Label();
            labelNome = new Label();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 40);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(389, 27);
            textBoxNome.TabIndex = 20;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(12, 99);
            textBoxQuantidade.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(389, 27);
            textBoxQuantidade.TabIndex = 22;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(12, 157);
            textBoxPrecoUnitario.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(389, 27);
            textBoxPrecoUnitario.TabIndex = 24;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(316, 196);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(86, 31);
            buttonSalvar.TabIndex = 25;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(12, 133);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(103, 20);
            labelPrecoUnitario.TabIndex = 23;
            labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(12, 75);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 21;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 16);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 19;
            labelNome.Text = "Nome";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(224, 196);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(86, 31);
            buttonCancelar.TabIndex = 26;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 237);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(buttonSalvar);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelQuantidade);
            Controls.Add(labelNome);
            Name = "CadastroProdutoForm";
            Text = "CadastroProdutoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxQuantidade;
        private TextBox textBoxPrecoUnitario;
        private Button buttonSalvar;
        private Label labelPrecoUnitario;
        private Label labelQuantidade;
        private Label labelNome;
        private Button buttonCancelar;
    }
}