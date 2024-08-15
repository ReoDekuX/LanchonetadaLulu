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
    public partial class TelaCadastroFuncionario : Form
    {
        public TelaCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Funcionarios.Nome_Fun = tbx_nomeFun.Text;
            Funcionarios.Fone_Fun = tbx_foneFun.Text;
            Funcionarios.Email_Fun = tbx_emailFun.Text;

            ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
            controllerFuncionarios.CadastrarFuncionarios();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
