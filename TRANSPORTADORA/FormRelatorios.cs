using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRANSPORTADORA.CAMADAS.RELATORIOS;

namespace TRANSPORTADORA
{
    public partial class FormRelatorios : Form
    {
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if(RBCombustivel.Checked)
            {
                Relatorios.relCombustivel();
            }

            else if (RBFretes.Checked)
            {
                Relatorios.relFretes();
            }
            else
            {
                MessageBox.Show("SELECIONE O RELATÓRIO QUE DESEJA EMITIR", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
