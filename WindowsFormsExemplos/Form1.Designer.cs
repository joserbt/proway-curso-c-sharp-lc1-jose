namespace WindowsFormsExemplos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelQuantidadeDeHorasTRabalhadas = new System.Windows.Forms.Label();
            this.textBoxQuantidadeHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.labelValorHora = new System.Windows.Forms.Label();
            this.textBoxValorHora = new System.Windows.Forms.TextBox();
            this.labelCifrao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 10);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 33);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(278, 27);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelQuantidadeDeHorasTRabalhadas
            // 
            this.labelQuantidadeDeHorasTRabalhadas.AutoSize = true;
            this.labelQuantidadeDeHorasTRabalhadas.Location = new System.Drawing.Point(12, 63);
            this.labelQuantidadeDeHorasTRabalhadas.Name = "labelQuantidadeDeHorasTRabalhadas";
            this.labelQuantidadeDeHorasTRabalhadas.Size = new System.Drawing.Size(230, 20);
            this.labelQuantidadeDeHorasTRabalhadas.TabIndex = 2;
            this.labelQuantidadeDeHorasTRabalhadas.Text = "Quantidade de horas trabalhadas";
            this.labelQuantidadeDeHorasTRabalhadas.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxQuantidadeHorasTrabalhadas
            // 
            this.textBoxQuantidadeHorasTrabalhadas.Location = new System.Drawing.Point(12, 86);
            this.textBoxQuantidadeHorasTrabalhadas.Name = "textBoxQuantidadeHorasTrabalhadas";
            this.textBoxQuantidadeHorasTrabalhadas.Size = new System.Drawing.Size(278, 27);
            this.textBoxQuantidadeHorasTrabalhadas.TabIndex = 3;
            // 
            // labelValorHora
            // 
            this.labelValorHora.AutoSize = true;
            this.labelValorHora.Location = new System.Drawing.Point(12, 116);
            this.labelValorHora.Name = "labelValorHora";
            this.labelValorHora.Size = new System.Drawing.Size(76, 20);
            this.labelValorHora.TabIndex = 4;
            this.labelValorHora.Text = "valor hora";
            // 
            // textBoxValorHora
            // 
            this.textBoxValorHora.Location = new System.Drawing.Point(44, 139);
            this.textBoxValorHora.Name = "textBoxValorHora";
            this.textBoxValorHora.Size = new System.Drawing.Size(246, 27);
            this.textBoxValorHora.TabIndex = 5;
            // 
            // labelCifrao
            // 
            this.labelCifrao.AutoSize = true;
            this.labelCifrao.Location = new System.Drawing.Point(12, 142);
            this.labelCifrao.Name = "labelCifrao";
            this.labelCifrao.Size = new System.Drawing.Size(26, 20);
            this.labelCifrao.TabIndex = 6;
            this.labelCifrao.Text = "R$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "calcular salario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCifrao);
            this.Controls.Add(this.textBoxValorHora);
            this.Controls.Add(this.labelValorHora);
            this.Controls.Add(this.textBoxQuantidadeHorasTrabalhadas);
            this.Controls.Add(this.labelQuantidadeDeHorasTRabalhadas);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelQuantidadeDeHorasTRabalhadas;
        private TextBox textBoxQuantidadeHorasTrabalhadas;
        private Label labelValorHora;
        private TextBox textBoxValorHora;
        private Label labelCifrao;
        private Button button1;
    }
}