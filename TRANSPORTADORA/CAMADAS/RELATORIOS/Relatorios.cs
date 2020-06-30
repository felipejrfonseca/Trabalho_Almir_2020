using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            string arquivo = folder + @"\RelCombustivel_" + DateTime.Now.ToShortDateString().Replace("/","_") + "_" + DateTime.Now.ToLongTimeString().Replace(":","_") + ".html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " + "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>"); sw.WriteLine("</head>");

                sw.WriteLine("<body>");
                sw.WriteLine("<h1>RELATÓRIO DE ENTRADAS E SAIDAS DE COMBUSTIVEL<h1>");
                sw.WriteLine("<hr / >");

                sw.WriteLine("<table>");
                sw.WriteLine("<table class='table table-striped'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("ENTRA/SAÍDA");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("PLACA");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("NOME MOTORISTA");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");

                int entrada = 0;
                int saida = 0;

                foreach (CAMADAS.MODEL.Combustivel combustivel in lstcombustivel)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='rignt' width ='15px'>");
                    sw.WriteLine(combustivel.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='60px'>");
                    sw.WriteLine(combustivel.estoque);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='60px'>");
                    sw.WriteLine(combustivel.placaCaminhao);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='200px'>");
                    sw.WriteLine(combustivel.nomeMotorista);
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");

                    if (combustivel.estoque > 0)
                    {
                        entrada += combustivel.estoque;
                    }

                    else
                    {
                        saida -= combustivel.estoque;
                    }
                }    
                
                sw.WriteLine("</table>");
                sw.WriteLine("<h3>Total de Entradas de Combustivel: " + entrada.ToString() + "<br>");
                sw.WriteLine("Total de saídas de Combustivel: " + saida.ToString() + "</h3>");
                sw.WriteLine("<hr />");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);
        }

        public static void relFretes()
        {
            CAMADAS.BLL.Frete bllFrete = new CAMADAS.BLL.Frete();
            List<CAMADAS.MODEL.Frete> lstFrete = new List<CAMADAS.MODEL.Frete>();
            lstFrete = bllFrete.Select();

            string folder = Funcoes.Pasta();
            string arquivo = folder + @"\RelFrete_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " + "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>"); sw.WriteLine("</head>");

                sw.WriteLine("<body>");
                sw.WriteLine("<h1>RELATÓRIO DE FRETES<h1>");
                sw.WriteLine("<hr / >");

                sw.WriteLine("<table>");
                sw.WriteLine("<table class='table table-striped'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("PRODUTO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("LOCAL DE PARTIDA");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("LOCAL DE ENTREGA");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("VALOR");
                sw.WriteLine("</th>"); sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("TRANSPORTADORA");
                sw.WriteLine("</th>"); sw.WriteLine("<th align='rignt'>");
                sw.WriteLine("MOTORISTA");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");

                float total = 0;
                
                foreach (CAMADAS.MODEL.Frete frete in lstFrete)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='rignt' width ='40px'>");
                    sw.WriteLine(frete.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='100px'>");
                    sw.WriteLine(frete.produto);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='80px'>");
                    sw.WriteLine(frete.localPartida);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='80px'>");
                    sw.WriteLine(frete.localEntrega);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='50px'>");
                    sw.WriteLine(string.Format("{0:C2}", frete.valor));
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='50px'>");
                    sw.WriteLine(frete.nomeTransportadora);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='rignt' width ='100px'>");
                    sw.WriteLine(frete.nomeMotorista);
                    sw.WriteLine("</td>");                 
                    sw.WriteLine("</tr>");
                    total += frete.valor;                    
                }

                sw.WriteLine("</table>");                
                sw.WriteLine("Total de Fretes R$:" + string.Format("{0:#.#,00}", total + "</h3>"));
                sw.WriteLine("<hr />");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}


                   