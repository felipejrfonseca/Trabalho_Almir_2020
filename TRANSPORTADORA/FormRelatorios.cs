using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: esta linha de código carrega dados na tabela 'nOVO_TRANSPORTADORADataSet1.Cor'. Você pode movê-la ou removê-la conforme necessário.
            this.corTableAdapter.Fill(this.nOVO_TRANSPORTADORADataSet1.Cor);

        }
    }
}
