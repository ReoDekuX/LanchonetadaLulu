namespace LanchonetadaLulu.View
{
    partial class TelaGerenciaFuncionario
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
            dataGridViewFuncionarios = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Fone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            button1 = new Button();
            tbx_NomeFuncionario = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btn_ExcluirFuncionario = new Button();
            btn_AlterarFuncionario = new Button();
            tbx_CodigoFuncionarioVer = new TextBox();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            tbx_FoneFuncionarioVer = new TextBox();
            label6 = new Label();
            tbx_EmailFuncionarioVer = new TextBox();
            tbx_NomeFuncionarioVer = new TextBox();
            btn_BuscarFuncionarioCodigo = new Button();
            tbx_CodigoFuncionario = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 38);
            label1.Name = "label1";
            label1.Size = new Size(328, 32);
            label1.TabIndex = 2;
            label1.Text = "Manipulando  Funcionarios";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(103, 101);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(588, 292);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewFuncionarios);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(tbx_NomeFuncionario);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(580, 264);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Fone, Email });
            dataGridViewFuncionarios.Location = new Point(28, 105);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.Size = new Size(511, 128);
            dataGridViewFuncionarios.TabIndex = 7;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
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
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(28, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbx_NomeFuncionario
            // 
            tbx_NomeFuncionario.Location = new Point(28, 47);
            tbx_NomeFuncionario.Name = "tbx_NomeFuncionario";
            tbx_NomeFuncionario.Size = new Size(464, 23);
            tbx_NomeFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 18);
            label2.Name = "label2";
            label2.Size = new Size(170, 15);
            label2.TabIndex = 0;
            label2.Text = "Digite o nome do Funcionarios";
            label2.Click += label2_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btn_BuscarFuncionarioCodigo);
            tabPage2.Controls.Add(tbx_CodigoFuncionario);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(580, 264);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alterar & Excluir";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ExcluirFuncionario);
            groupBox1.Controls.Add(btn_AlterarFuncionario);
            groupBox1.Controls.Add(tbx_CodigoFuncionarioVer);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_FoneFuncionarioVer);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbx_EmailFuncionarioVer);
            groupBox1.Controls.Add(tbx_NomeFuncionarioVer);
            groupBox1.Location = new Point(24, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 207);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado da Pesquisa:";
            // 
            // btn_ExcluirFuncionario
            // 
            btn_ExcluirFuncionario.Location = new Point(436, 177);
            btn_ExcluirFuncionario.Name = "btn_ExcluirFuncionario";
            btn_ExcluirFuncionario.Size = new Size(75, 23);
            btn_ExcluirFuncionario.TabIndex = 17;
            btn_ExcluirFuncionario.Text = "Excluir";
            btn_ExcluirFuncionario.UseVisualStyleBackColor = true;
            btn_ExcluirFuncionario.Click += btn_ExcluirFuncionario_Click;
            // 
            // btn_AlterarFuncionario
            // 
            btn_AlterarFuncionario.Location = new Point(355, 177);
            btn_AlterarFuncionario.Name = "btn_AlterarFuncionario";
            btn_AlterarFuncionario.Size = new Size(75, 23);
            btn_AlterarFuncionario.TabIndex = 16;
            btn_AlterarFuncionario.Text = "Alterar";
            btn_AlterarFuncionario.UseVisualStyleBackColor = true;
            btn_AlterarFuncionario.Click += btn_AlterarFuncionario_Click;
            // 
            // tbx_CodigoFuncionarioVer
            // 
            tbx_CodigoFuncionarioVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_CodigoFuncionarioVer.Location = new Point(94, 19);
            tbx_CodigoFuncionarioVer.Name = "tbx_CodigoFuncionarioVer";
            tbx_CodigoFuncionarioVer.Size = new Size(101, 33);
            tbx_CodigoFuncionarioVer.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 6;
            label4.Text = "Código:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(307, 67);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 14;
            label8.Text = "Fone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(6, 70);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 7;
            label5.Text = "Nome:";
            // 
            // tbx_FoneFuncionarioVer
            // 
            tbx_FoneFuncionarioVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_FoneFuncionarioVer.Location = new Point(374, 67);
            tbx_FoneFuncionarioVer.Name = "tbx_FoneFuncionarioVer";
            tbx_FoneFuncionarioVer.Size = new Size(137, 33);
            tbx_FoneFuncionarioVer.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(16, 126);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            // 
            // tbx_EmailFuncionarioVer
            // 
            tbx_EmailFuncionarioVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_EmailFuncionarioVer.Location = new Point(81, 123);
            tbx_EmailFuncionarioVer.Name = "tbx_EmailFuncionarioVer";
            tbx_EmailFuncionarioVer.Size = new Size(430, 33);
            tbx_EmailFuncionarioVer.TabIndex = 12;
            // 
            // tbx_NomeFuncionarioVer
            // 
            tbx_NomeFuncionarioVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_NomeFuncionarioVer.Location = new Point(81, 67);
            tbx_NomeFuncionarioVer.Name = "tbx_NomeFuncionarioVer";
            tbx_NomeFuncionarioVer.Size = new Size(220, 33);
            tbx_NomeFuncionarioVer.TabIndex = 11;
            // 
            // btn_BuscarFuncionarioCodigo
            // 
            btn_BuscarFuncionarioCodigo.Location = new Point(339, 23);
            btn_BuscarFuncionarioCodigo.Name = "btn_BuscarFuncionarioCodigo";
            btn_BuscarFuncionarioCodigo.Size = new Size(75, 23);
            btn_BuscarFuncionarioCodigo.TabIndex = 5;
            btn_BuscarFuncionarioCodigo.Text = "Buscar";
            btn_BuscarFuncionarioCodigo.UseVisualStyleBackColor = true;
            btn_BuscarFuncionarioCodigo.Click += btn_BuscarFuncionarioCodigo_Click;
            // 
            // tbx_CodigoFuncionario
            // 
            tbx_CodigoFuncionario.Location = new Point(203, 23);
            tbx_CodigoFuncionario.Name = "tbx_CodigoFuncionario";
            tbx_CodigoFuncionario.Size = new Size(122, 23);
            tbx_CodigoFuncionario.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 23);
            label3.Name = "label3";
            label3.Size = new Size(173, 15);
            label3.TabIndex = 3;
            label3.Text = "Digite o Código do Funcionario";
            // 
            // TelaGerenciaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaGerenciaFuncionario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimentício - SGPA";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
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
        private Button button1;
        private TextBox tbx_NomeFuncionario;
        private Label label2;
        private TabPage tabPage2;
        private Button btn_BuscarFuncionarioCodigo;
        private TextBox tbx_CodigoFuncionario;
        private Label label3;
        private DataGridView dataGridViewFuncionarios;
        private GroupBox groupBox1;
        private Button btn_ExcluirFuncionario;
        private Button btn_AlterarFuncionario;
        private TextBox tbx_CodigoFuncionarioVer;
        private Label label4;
        private Label label8;
        private Label label5;
        private TextBox tbx_FoneFuncionarioVer;
        private Label label6;
        private TextBox tbx_EmailFuncionarioVer;
        private TextBox tbx_NomeFuncionarioVer;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Fone;
        private DataGridViewTextBoxColumn Email;
    }
}