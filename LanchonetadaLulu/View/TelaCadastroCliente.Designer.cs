namespace LanchonetadaLulu.View
{
    partial class TelaCadastroCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbx_nome = new TextBox();
            tbx_fone = new TextBox();
            tbx_cpf = new TextBox();
            btn_Salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 42);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro do Clientes ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(33, 111);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(33, 167);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 2;
            label3.Text = "Fone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(46, 217);
            label4.Name = "label4";
            label4.Size = new Size(53, 30);
            label4.TabIndex = 3;
            label4.Text = "CPF:";
            // 
            // tbx_nome
            // 
            tbx_nome.Font = new Font("Segoe UI", 11.25F);
            tbx_nome.Location = new Point(135, 120);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(247, 27);
            tbx_nome.TabIndex = 4;
            // 
            // tbx_fone
            // 
            tbx_fone.Font = new Font("Segoe UI", 11.25F);
            tbx_fone.Location = new Point(135, 176);
            tbx_fone.Name = "tbx_fone";
            tbx_fone.Size = new Size(181, 27);
            tbx_fone.TabIndex = 5;
            // 
            // tbx_cpf
            // 
            tbx_cpf.Font = new Font("Segoe UI", 11.25F);
            tbx_cpf.Location = new Point(135, 224);
            tbx_cpf.Name = "tbx_cpf";
            tbx_cpf.Size = new Size(127, 27);
            tbx_cpf.TabIndex = 6;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(98, 313);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(235, 62);
            btn_Salvar.TabIndex = 7;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(442, 418);
            Controls.Add(btn_Salvar);
            Controls.Add(tbx_cpf);
            Controls.Add(tbx_fone);
            Controls.Add(tbx_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastroCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimentício - SGPA";
            Load += TelaCadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_nome;
        private TextBox tbx_fone;
        private TextBox tbx_cpf;
        private Button btn_Salvar;
    }
}