using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchonetadaLulu.Model
{
    internal class Clientes
    {
        private static int id_Cli;
        private static string nome_Cli;
        private static string fone_Cli;
        private static string cpf_Cli;

        public static int Id_Cli { get => id_Cli; set => id_Cli = value; }
        public static string Nome_Cli { get => nome_Cli; set => nome_Cli = value; }
        public static string Fone_Cli { get => fone_Cli; set => fone_Cli = value; }
        public static string Cpf_Cli { get => cpf_Cli; set => cpf_Cli = value; }
    }
}
