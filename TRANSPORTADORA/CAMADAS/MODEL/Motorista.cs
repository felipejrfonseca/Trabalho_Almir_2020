using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA.CAMADAS.MODEL
{
    public class Motorista
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public DateTime validadeCnh { get; set; }
        public float salario { get; set; }        
    }
}
