using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA.CAMADAS.MODEL
{
    public class Frete
    {
        public int id { get; set; }
        public string produto { get; set; }
        public string localPartida { get; set; }
        public string localEntrega { get; set; }
        public DateTime data { get; set; }
        public float valor { get; set; }
        public int transportadora { get; set; }
        public int caminhao { get; set; }
        public int motorista { get; set; }
    }
}
