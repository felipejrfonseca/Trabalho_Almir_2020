using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA.CAMADAS.MODEL
{
    public class Caminhao
    {
        public int id { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public int cor { get; set; }
        public int motorista { get; set; }
    }
}
