using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchonetadaLulu.Model
{
    internal class Conexao
    {
        public static string Conectar() {

            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\giovanni.rvieira\source\repos\LanchonetadaLulu\LanchonetadaLulu\Dados\Lachonetebd.mdf;Integrated Security=True";
        }
    }
}
