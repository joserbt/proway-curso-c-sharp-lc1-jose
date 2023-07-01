using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsExemplos.Forms.Pedidos
{
    partial class ListagemPedidosForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.radioButtonStatusTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonStatusOrcamento = new System.Windows.Forms.RadioButton();
            this.radioButtonStatusEfetivado = new System.Windows.Forms.RadioButton();
            this.radioButtonStatusCancelado = new System.Windows.Forms.RadioButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonCriarOrcamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(35, 13);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(55, 20);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Cliente";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(35, 36);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(246, 28);
            this.comboBoxClientes.TabIndex = 2;
            // 
            // radioButtonStatusTodos
            // 
            this.radioButtonStatusTodos.AutoSize = true;
            this.radioButtonStatusTodos.Location = new System.Drawing.Point(287, 36);
            this.radioButtonStatusTodos.Name = "radioButtonStatusTodos";
            this.radioButtonStatusTodos.Size = new System.Drawing.Size(70, 24);
            this.radioButtonStatusTodos.TabIndex = 3;
            this.radioButtonStatusTodos.TabStop = true;
            this.radioButtonStatusTodos.Text = "Todos";
            this.radioButtonStatusTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusOrcamento
            // 
            this.radioButtonStatusOrcamento.AutoSize = true;
            this.radioButtonStatusOrcamento.Location = new System.Drawing.Point(287, 66);
            this.radioButtonStatusOrcamento.Name = "radioButtonStatusOrcamento";
            this.radioButtonStatusOrcamento.Size = new System.Drawing.Size(110, 24);
            this.radioButtonStatusOrcamento.TabIndex = 4;
            this.radioButtonStatusOrcamento.TabStop = true;
            this.radioButtonStatusOrcamento.Text = "Orçamentos";
            this.radioButtonStatusOrcamento.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusEfetivado
            // 
            this.radioButtonStatusEfetivado.AutoSize = true;
            this.radioButtonStatusEfetivado.Location = new System.Drawing.Point(428, 36);
            this.radioButtonStatusEfetivado.Name = "radioButtonStatusEfetivado";
            this.radioButtonStatusEfetivado.Size = new System.Drawing.Size(99, 24);
            this.radioButtonStatusEfetivado.TabIndex = 5;
            this.radioButtonStatusEfetivado.TabStop = true;
            this.radioButtonStatusEfetivado.Text = "Efetivados";
            this.radioButtonStatusEfetivado.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusCancelado
            // 
            this.radioButtonStatusCancelado.AutoSize = true;
            this.radioButtonStatusCancelado.Location = new System.Drawing.Point(428, 66);
            this.radioButtonStatusCancelado.Name = "radioButtonStatusCancelado";
            this.radioButtonStatusCancelado.Size = new System.Drawing.Size(106, 24);
            this.radioButtonStatusCancelado.TabIndex = 6;
            this.radioButtonStatusCancelado.TabStop = true;
            this.radioButtonStatusCancelado.Text = "Cancelados";
            this.radioButtonStatusCancelado.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(287, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(49, 20);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            // 
            // buttonCriarOrcamento
            // 
            this.buttonCriarOrcamento.Location = new System.Drawing.Point(668, 13);
            this.buttonCriarOrcamento.Name = "buttonCriarOrcamento";
            this.buttonCriarOrcamento.Size = new System.Drawing.Size(120, 116);
            this.buttonCriarOrcamento.TabIndex = 8;
            this.buttonCriarOrcamento.Text = "Criar orçamento";
            this.buttonCriarOrcamento.UseVisualStyleBackColor = true;
            this.buttonCriarOrcamento.Click += new System.EventHandler(this.buttonCriarOrcamento_Click);
            // 
            // ListagemPedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCriarOrcamento);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.radioButtonStatusCancelado);
            this.Controls.Add(this.radioButtonStatusEfetivado);
            this.Controls.Add(this.radioButtonStatusOrcamento);
            this.Controls.Add(this.radioButtonStatusTodos);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListagemPedidosForm";
            this.Text = "ListagemPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelCliente;
        private ComboBox comboBoxClientes;
        private RadioButton radioButtonStatusTodos;
        private RadioButton radioButtonStatusOrcamento;
        private RadioButton radioButtonStatusEfetivado;
        private RadioButton radioButtonStatusCancelado;
        private Label labelStatus;
        private Button buttonCriarOrcamento;
    }
}