using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA.CAMADAS
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Cor dalCor = new CAMADAS.DAL.Cor();
            DGCor.DataSource = "";
            DGCor.DataSource = dalCor.Select();
        }

        private void BtnCor_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cor cor = new CAMADAS.MODEL.Cor();

            cor.cor = txtCor.Text;

            CAMADAS.DAL.Cor dalCor = new CAMADAS.DAL.Cor();
            dalCor.Inserir(cor);

            DGCor.DataSource = "";
            DGCor.DataSource = dalCor.Select();
        }
    }
}
