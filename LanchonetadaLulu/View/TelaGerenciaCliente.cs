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
using Microsoft.Identity.Client.NativeInterop;

namespace LanchonetadaLulu.View
{
    public partial class TelaGerenciaCliente : Form
    {
        public TelaGerenciaCliente()
        {
            InitializeComponent();
        }

        private void btn_BuscarClienteCodigo_Click(object sender, EventArgs e)
        {
            Clientes.Id_Cli = Convert.ToInt32(tbx_CdigoCliente.Text);
            ControllerClientes controllerClientes = new ControllerClientes();
            controllerClientes.VisualizarCodigoClientes();

            tbx_CodigoClienteVer.Text = Convert.ToString(Clientes.Id_Cli);
            tbx_NomeClienteVer.Text = Clientes.Nome_Cli;
            tbx_CPFClienteVer.Text = Clientes.Cpf_Cli;
            tbx_foneClienteVer.Text = Clientes.Fone_Cli;

        }

        private void btn_AlterarCliente_Click(object sender, EventArgs e)
        {
            if (tbx_CdigoCliente.Text == "")
            {
                MessageBox.Show("Digite o Código do Cliente");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar as informações do Cliente: " + tbx_NomeClienteVer.Text + " ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);


                if (resposta == DialogResult.Yes)
                {
                    Clientes.Id_Cli = Convert.ToInt32(tbx_CdigoCliente.Text);
                    Clientes.Nome_Cli = tbx_NomeClienteVer.Text;
                    Clientes.Fone_Cli = tbx_foneClienteVer.Text;
                    Clientes.Cpf_Cli = tbx_CPFClienteVer.Text;

                    ControllerClientes controllerClientes = new ControllerClientes();
                    controllerClientes.AlterarClientes();

                    tbx_CodigoClienteVer.Text = "";
                    tbx_NomeClienteVer.Text = "";
                    tbx_foneClienteVer.Text = "";
                    tbx_CPFClienteVer.Text = "";

                }
                else
                {
                    tbx_CodigoClienteVer.Text = "";
                    tbx_NomeClienteVer.Text = "";
                    tbx_foneClienteVer.Text = "";
                    tbx_CPFClienteVer.Text = "";
                    tbx_CdigoCliente.Focus();
                }
            }

        }

        private void btn_ExcluirCliente_Click(object sender, EventArgs e)
        {
            if (tbx_CdigoCliente.Text == "")
            {
                MessageBox.Show("Digite o Código do Cliente");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja exluir as informações do Cliente: " + tbx_NomeClienteVer.Text + " ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);


                if (resposta == DialogResult.Yes)
                {
                    Clientes.Id_Cli = Convert.ToInt32(tbx_CdigoCliente.Text);


                    ControllerClientes controllerClientes = new ControllerClientes();
                    controllerClientes.DeletarClientes();

                    tbx_CodigoClienteVer.Text = "";
                    tbx_NomeClienteVer.Text = "";
                    tbx_foneClienteVer.Text = "";
                    tbx_CPFClienteVer.Text = "";

                }
                else
                {
                    tbx_CodigoClienteVer.Text = "";
                    tbx_NomeClienteVer.Text = "";
                    tbx_foneClienteVer.Text = "";
                    tbx_CPFClienteVer.Text = "";
                    tbx_CdigoCliente.Focus();
                }
            }
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            Clientes.Nome_Cli = tbx_NomeCliente.Text;
            dataGridViewClientes.DataSource = ControllerClientes.VisualizarNomeCliente();
            dataGridViewClientes.Columns[0].Visible = false;
            dataGridViewClientes.Columns[1].Visible = false;
            dataGridViewClientes.Columns[2].Visible = false;
            dataGridViewClientes.Columns[3].Visible = false;
            dataGridViewClientes.Columns[4].HeaderCell.Value = "Código";
            dataGridViewClientes.Columns[5].HeaderCell.Value = "Cliente";
            dataGridViewClientes.Columns[6].HeaderCell.Value = "Fone";
            dataGridViewClientes.Columns[7].HeaderCell.Value = "CPF";
            //dataGridViewClientes.Columns[7].Visible = false;
        }
    }
}
