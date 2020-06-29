using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA.CAMADAS.RELATORIOS
{
    public class Relatorios
    {
        public static void relCombustivel()
        {
            CAMADAS.BLL.Combustivel bllCombustivel = new CAMADAS.BLL.Combustivel();
            List<CAMADAS.MODEL.Combustivel> lstcombustivel = new List<CAMADAS.MODEL.Combustivel>();
            lstcombustivel = bllCombustivel.Select();

            string folder = Funcoes.Pasta();
            string arquivo = folder + @"\RelCombustivel.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                             "content='text/html; charset=utf-8'/>");
                sw.WriteLine("</head>");
                
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>RELATÓRIO DE ENTRADAS E SAIDAS DE COMBUSTIVEL<h1>");
                sw.WriteLine("<hr align = 'left'border: '5px' / >");                
                
                sw.WriteLine("<table>");                
                sw.WriteLine("<tr>");
                sw.WriteLine("<th align='rignt' width '150px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt' width '150px'>");
                sw.WriteLine("ENTRA/SAÍDA");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt' width '150px'>");
                sw.WriteLine("ID CAMINHÃO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt' width '150px'>");
                sw.WriteLine("ID MOTORISTA");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");


                foreach(CAMADAS.MODEL.Combustivel combustivel in lstcombustivel)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='rignt' width '150px'>");
                    sw.WriteLine(combustivel.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width '150px'>");
                    sw.WriteLine(combustivel.estoque);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width '150px'>");
                    sw.WriteLine(combustivel.caminhaoID);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width '150px'>");
                    sw.WriteLine(combustivel.motoristaID);
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                }


                sw.WriteLine("</table>");
                sw.WriteLine("<hr align = 'left'border: '5px' / >");
                sw.WriteLine("<h1>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}

