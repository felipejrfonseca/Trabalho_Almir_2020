using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA.CAMADAS.MODEL
{
    public class Conexao
    {
        public static string getConexao()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=NOVO_TRANSPORTADORA;Integrated Security=True";
        }
    }
}
