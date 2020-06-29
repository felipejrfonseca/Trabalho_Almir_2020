using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA.CAMADAS.RELATORIOS
{
    public class Funcoes
    {
        public static string Pasta()
        {
            string folder = @"c:/RELADS";
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return folder;
        }
    }
}
