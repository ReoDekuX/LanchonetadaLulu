using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchonetadaLulu.Model
{
    internal class Funcionarios
    {
        private static int id_Fun;
        private static string nome_Fun;
        private static string fone_Fun;
        private static string email_Fun;

        public static int Id_Fun { get => id_Fun; set => id_Fun = value; }
        public static string Nome_Fun { get => nome_Fun; set => nome_Fun = value; }
        public static string Fone_Fun { get => fone_Fun; set => fone_Fun = value; }
        public static string Email_Fun { get => email_Fun; set => email_Fun = value; }
    }
}
