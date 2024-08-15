using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanchonetadaLulu.View
{
    public partial class TelaADM : Form
    {
        public TelaADM()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaCadastroProduto = new TelaCadastroProduto();
            telaCadastroProduto.Show();
        }

        private void manipularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaGerenciaProduto telaGerenciaProduto = new TelaGerenciaProduto();
            telaGerenciaProduto.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente telaCadastroCliente = new TelaCadastroCliente();
            telaCadastroCliente.Show();
        }

        private void manipularToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaGerenciaCliente telaGerenciaCliente = new TelaGerenciaCliente();
            telaGerenciaCliente.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionario telaCadastroFuncionario = new TelaCadastroFuncionario();
            telaCadastroFuncionario.Show();
        }

        private void manipularToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaGerenciaFuncionario telaGerenciaFuncionario = new TelaGerenciaFuncionario();
            telaGerenciaFuncionario.Show();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPDV telaPDV = new TelaPDV();
            telaPDV.Show();
        }
    }
}
