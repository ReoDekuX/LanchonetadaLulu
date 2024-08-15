namespace LanchonetadaLulu.View
{
    partial class TelaGerenciaCliente
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewClientes = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Fone = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            btn_BuscarCliente = new Button();
            tbx_NomeCliente = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btn_ExcluirCliente = new Button();
            btn_AlterarCliente = new Button();
            tbx_CodigoClienteVer = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbx_CPFClienteVer = new TextBox();
            label6 = new Label();
            tbx_foneClienteVer = new TextBox();
            label7 = new Label();
            tbx_NomeClienteVer = new TextBox();
            btn_BuscarClienteCodigo = new Button();
            tbx_CdigoCliente = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 36);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 3;
            label1.Text = "Manipulando Clientes";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(90, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(571, 292);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewClientes);
            tabPage1.Controls.Add(btn_BuscarCliente);
            tabPage1.Controls.Add(tbx_NomeCliente);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(563, 264);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, Fone, CPF });
            dataGridViewClientes.Location = new Point(31, 105);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(464, 131);
            dataGridViewClientes.TabIndex = 3;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Fone
            // 
            Fone.HeaderText = "Fone";
            Fone.Name = "Fone";
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            // 
            // btn_BuscarCliente
            // 
            btn_BuscarCliente.Location = new Point(28, 76);
            btn_BuscarCliente.Name = "btn_BuscarCliente";
            btn_BuscarCliente.Size = new Size(75, 23);
            btn_BuscarCliente.TabIndex = 2;
            btn_BuscarCliente.Text = "Buscar";
            btn_BuscarCliente.UseVisualStyleBackColor = true;
            btn_BuscarCliente.Click += btn_BuscarCliente_Click;
            // 
            // tbx_NomeCliente
            // 
            tbx_NomeCliente.Location = new Point(28, 47);
            tbx_NomeCliente.Name = "tbx_NomeCliente";
            tbx_NomeCliente.Size = new Size(464, 23);
            tbx_NomeCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 23);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 0;
            label2.Text = "Digite o nome do Cliente";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btn_BuscarClienteCodigo);
            tabPage2.Controls.Add(tbx_CdigoCliente);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(563, 264);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alterar & Excluir";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ExcluirCliente);
            groupBox1.Controls.Add(btn_AlterarCliente);
            groupBox1.Controls.Add(tbx_CodigoClienteVer);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_CPFClienteVer);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbx_foneClienteVer);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbx_NomeClienteVer);
            groupBox1.Location = new Point(6, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 206);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado da Pesquisa:";
            // 
            // btn_ExcluirCliente
            // 
            btn_ExcluirCliente.Location = new Point(436, 177);
            btn_ExcluirCliente.Name = "btn_ExcluirCliente";
            btn_ExcluirCliente.Size = new Size(75, 23);
            btn_ExcluirCliente.TabIndex = 17;
            btn_ExcluirCliente.Text = "Excluir";
            btn_ExcluirCliente.UseVisualStyleBackColor = true;
            btn_ExcluirCliente.Click += btn_ExcluirCliente_Click;
            // 
            // btn_AlterarCliente
            // 
            btn_AlterarCliente.Location = new Point(355, 177);
            btn_AlterarCliente.Name = "btn_AlterarCliente";
            btn_AlterarCliente.Size = new Size(75, 23);
            btn_AlterarCliente.TabIndex = 16;
            btn_AlterarCliente.Text = "Alterar";
            btn_AlterarCliente.UseVisualStyleBackColor = true;
            btn_AlterarCliente.Click += btn_AlterarCliente_Click;
            // 
            // tbx_CodigoClienteVer
            // 
            tbx_CodigoClienteVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_CodigoClienteVer.Location = new Point(104, 31);
            tbx_CodigoClienteVer.Name = "tbx_CodigoClienteVer";
            tbx_CodigoClienteVer.Size = new Size(101, 33);
            tbx_CodigoClienteVer.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(16, 34);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 6;
            label4.Text = "Código:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(13, 78);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 7;
            label5.Text = "Nome:";
            // 
            // tbx_CPFClienteVer
            // 
            tbx_CPFClienteVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_CPFClienteVer.Location = new Point(297, 117);
            tbx_CPFClienteVer.Name = "tbx_CPFClienteVer";
            tbx_CPFClienteVer.Size = new Size(168, 33);
            tbx_CPFClienteVer.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(23, 120);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 8;
            label6.Text = "Fone:";
            // 
            // tbx_foneClienteVer
            // 
            tbx_foneClienteVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_foneClienteVer.Location = new Point(90, 117);
            tbx_foneClienteVer.Name = "tbx_foneClienteVer";
            tbx_foneClienteVer.Size = new Size(144, 33);
            tbx_foneClienteVer.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(240, 120);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 9;
            label7.Text = "CPF:";
            // 
            // tbx_NomeClienteVer
            // 
            tbx_NomeClienteVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_NomeClienteVer.Location = new Point(90, 78);
            tbx_NomeClienteVer.Name = "tbx_NomeClienteVer";
            tbx_NomeClienteVer.Size = new Size(375, 33);
            tbx_NomeClienteVer.TabIndex = 11;
            // 
            // btn_BuscarClienteCodigo
            // 
            btn_BuscarClienteCodigo.Location = new Point(312, 23);
            btn_BuscarClienteCodigo.Name = "btn_BuscarClienteCodigo";
            btn_BuscarClienteCodigo.Size = new Size(75, 23);
            btn_BuscarClienteCodigo.TabIndex = 5;
            btn_BuscarClienteCodigo.Text = "Buscar";
            btn_BuscarClienteCodigo.UseVisualStyleBackColor = true;
            btn_BuscarClienteCodigo.Click += btn_BuscarClienteCodigo_Click;
            // 
            // tbx_CdigoCliente
            // 
            tbx_CdigoCliente.Location = new Point(180, 23);
            tbx_CdigoCliente.Name = "tbx_CdigoCliente";
            tbx_CdigoCliente.Size = new Size(114, 23);
            tbx_CdigoCliente.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 29);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 3;
            label3.Text = "Digite o Código do Cliente";
            // 
            // TelaGerenciaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(734, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaGerenciaCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimentício - SGPA";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridViewClientes;
        private Button btn_BuscarCliente;
        private TextBox tbx_NomeCliente;
        private Label label2;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Button btn_ExcluirCliente;
        private Button btn_AlterarCliente;
        private TextBox tbx_CodigoClienteVer;
        private Label label4;
        private Label label5;
        private TextBox tbx_CPFClienteVer;
        private Label label6;
        private TextBox tbx_foneClienteVer;
        private Label label7;
        private TextBox tbx_NomeClienteVer;
        private Button btn_BuscarClienteCodigo;
        private TextBox tbx_CdigoCliente;
        private Label label3;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Fone;
        private DataGridViewTextBoxColumn CPF;
    }
}