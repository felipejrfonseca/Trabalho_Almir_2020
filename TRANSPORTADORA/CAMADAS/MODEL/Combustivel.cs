using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA.CAMADAS.MODEL
{
    public class Combustivel
    {
        public int id { get; set; }
        public int estoque { get; set; }
        public int caminhaoID { get; set; }
        public int motoristaID { get; set; }
        public int atualEstoque { get; set; }
    }
}
