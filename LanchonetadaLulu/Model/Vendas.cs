using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchonetadaLulu.Model
{
    internal class Vendas
    {
        private static int id_Venda;
        private static int id_Cli;
        private static int id_Prod;
        private static int id_Fun;
        private static string data_Venda;
        private static float valorTotal_Venda;

        public static int Id_Venda { get => id_Venda; set => id_Venda = value; }
        public static int Id_Cli { get => id_Cli; set => id_Cli = value; }
        public static int Id_Prod { get => id_Prod; set => id_Prod = value; }
        public static int Id_Fun { get => id_Fun; set => id_Fun = value; }
        public static string Data_Venda { get => data_Venda; set => data_Venda = value; }
        public static float ValorTotal_Venda { get => valorTotal_Venda; set => valorTotal_Venda = value; }
    }
}