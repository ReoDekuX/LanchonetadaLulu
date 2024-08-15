using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanchonetadaLulu.Contoller;
using LanchonetadaLulu.Model;

namespace LanchonetadaLulu.View
{
    public partial class TelaGerenciaFuncionario : Form
    {
        public TelaGerenciaFuncionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuscarFuncionarioCodigo_Click(object sender, EventArgs e)
        {
            Funcionarios.Id_Fun = Convert.ToInt32(tbx_CodigoFuncionario.Text);
            ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
            controllerFuncionarios.VisualizarCodigoFuncionarios();

            tbx_CodigoFuncionarioVer.Text = Convert.ToString(Funcionarios.Id_Fun);
            tbx_NomeFuncionarioVer.Text = Funcionarios.Nome_Fun;
            tbx_FoneFuncionarioVer.Text = Funcionarios.Fone_Fun;
            tbx_EmailFuncionarioVer.Text = Funcionarios.Email_Fun;
        }

        private void btn_AlterarFuncionario_Click(object sender, EventArgs e)
        {
            if (tbx_CodigoFuncionario.Text == "")
            {
                MessageBox.Show("Digite o Código do Funcionario");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar as informações do Funcionario: " + tbx_NomeFuncionarioVer.Text + " ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);


                if (resposta == DialogResult.Yes)
                {
                    Funcionarios.Id_Fun = Convert.ToInt32(tbx_CodigoFuncionario.Text);
                    Funcionarios.Nome_Fun = tbx_NomeFuncionarioVer.Text;
                    Funcionarios.Fone_Fun = tbx_FoneFuncionarioVer.Text;
                    Funcionarios.Email_Fun = tbx_EmailFuncionarioVer.Text;

                    ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
                    controllerFuncionarios.AlterarFuncionarios();

                    tbx_CodigoFuncionarioVer.Text = "";
                    tbx_NomeFuncionarioVer.Text = "";
                    tbx_FoneFuncionarioVer.Text = "";
                    tbx_EmailFuncionarioVer.Text = "";
                }
                else
                {
                    tbx_CodigoFuncionarioVer.Text = "";
                    tbx_NomeFuncionarioVer.Text = "";
                    tbx_FoneFuncionarioVer.Text = "";
                    tbx_EmailFuncionarioVer.Text = "";
                    tbx_CodigoFuncionario.Focus();
                }
            }
        }

        private void btn_ExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (tbx_CodigoFuncionario.Text == "")
            {
                MessageBox.Show("Digite o Código do Funcionario");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja exluir as informações do Funcionario: " + tbx_NomeFuncionarioVer.Text + " ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);


                if (resposta == DialogResult.Yes)
                {
                    Clientes.Id_Cli = Convert.ToInt32(tbx_CodigoFuncionario.Text);


                    ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
                    controllerFuncionarios.DeletarFuncionarios();


                    tbx_CodigoFuncionarioVer.Text = "";
                    tbx_NomeFuncionarioVer.Text = "";
                    tbx_FoneFuncionarioVer.Text = "";
                    tbx_EmailFuncionarioVer.Text = "";

                }
                else
                {

                    tbx_CodigoFuncionarioVer.Text = "";
                    tbx_NomeFuncionarioVer.Text = "";
                    tbx_FoneFuncionarioVer.Text = "";
                    tbx_EmailFuncionarioVer.Text = "";
                    tbx_CodigoFuncionario.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionarios.Nome_Fun = tbx_NomeFuncionario.Text;
            dataGridViewFuncionarios.DataSource = ControllerFuncionarios.VisualizarNomeFuncionario();
            dataGridViewFuncionarios.Columns[0].Visible = false;
            dataGridViewFuncionarios.Columns[1].Visible = false;
            dataGridViewFuncionarios.Columns[2].Visible = false;
            dataGridViewFuncionarios.Columns[3].Visible = false;
            dataGridViewFuncionarios.Columns[4].HeaderCell.Value = "Código";
            dataGridViewFuncionarios.Columns[5].HeaderCell.Value = "Funcionario";
            dataGridViewFuncionarios.Columns[6].HeaderCell.Value = "Fone";
            dataGridViewFuncionarios.Columns[7].HeaderCell.Value = "Email";

        }
    }
}
