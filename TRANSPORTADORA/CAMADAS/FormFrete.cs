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
    public partial class FormFrete : Form
    {
        public FormFrete()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDTransportadora.Text = cmbTransportadora.SelectedValue.ToString();
        }

        private void cmbCor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGCaminhoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int idFrete = Convert.ToInt32(txtID.Text);
            CAMADAS.DAL.Frete dalFrete = new CAMADAS.DAL.Frete();
            dalFrete.Delete(idFrete);

            limparcontrole();

            DGFrete.DataSource = "";
            DGFrete.DataSource = dalFrete.Select();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Frete frete = new CAMADAS.MODEL.Frete();

            frete.id = Convert.ToInt32(txtID.Text);
            frete.produto = txtProduto.Text;
            frete.localPartida = txtLocalPartida.Text;
            frete.localEntrega = txtLocalEntrega.Text;
            frete.data = Convert.ToDateTime(DTData.Text);
            frete.valor = Convert.ToSingle(txtValor.Text);
            frete.transportadora = Convert.ToInt32(txtIDTransportadora.Text);
            frete.motorista = Convert.ToInt32(txtIDMotorista.Text);

            CAMADAS.DAL.Frete dalFrete = new CAMADAS.DAL.Frete();
            dalFrete.Update(frete);

            limparcontrole();

            DGFrete.DataSource = "";
            DGFrete.DataSource = dalFrete.Select();
        }

        public void limparcontrole()
        {
            txtID.Text = "-1";
            txtProduto.Text = "";
            txtLocalPartida.Text = "";
            txtLocalEntrega.Text = "";
            DTData.Text = "";
            txtValor.Text = "";
            cmbMotorista.Text = "";
            txtIDMotorista.Text = "";
            txtIDTransportadora.Text = "";
            cmbTransportadora.Text = "";
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != "" && txtLocalEntrega.Text != "" && txtLocalPartida.Text != "" && txtLocalEntrega.Text != "" && DTData.Text != "" && txtValor.Text != "" && txtIDTransportadora.Text != "" && txtIDMotorista.Text != "")
            {
                CAMADAS.MODEL.Frete frete = new CAMADAS.MODEL.Frete();

                frete.produto = txtProduto.Text;
                frete.localPartida = txtLocalPartida.Text;
                frete.localEntrega = txtLocalEntrega.Text;
                frete.data = Convert.ToDateTime(DTData.Text);
                frete.valor = Convert.ToSingle(txtValor.Text);
                frete.transportadora = Convert.ToInt32(txtIDTransportadora.Text);
                frete.motorista = Convert.ToInt32(txtIDMotorista.Text);

                CAMADAS.DAL.Frete dalFrete = new CAMADAS.DAL.Frete();
                dalFrete.Inserir(frete);

                limparcontrole();

                DGFrete.DataSource = "";
                DGFrete.DataSource = dalFrete.Select();
                
            }

            else
            {
                MessageBox.Show("TODOS OS ITENS DEVEM SER PREENCHIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormFrete_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Motorista dalMotorista = new CAMADAS.DAL.Motorista();
            CAMADAS.DAL.Transportadora dalTransportadora = new CAMADAS.DAL.Transportadora();
            CAMADAS.DAL.Frete dalFrete = new CAMADAS.DAL.Frete();
            DGFrete.DataSource = "";
            DGFrete.DataSource = dalFrete.Select();

            //COMBOBOX 
            cmbMotorista.DisplayMember = "nome";
            cmbMotorista.ValueMember = "id";
            cmbMotorista.DataSource = dalMotorista.Select();

            cmbTransportadora.DisplayMember = "nomeTransportadora";
            cmbTransportadora.ValueMember = "id";
            cmbTransportadora.DataSource = dalTransportadora.Select();
        }

        private void txtIDMotorista_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbMotorista_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtIDMotorista.Text = cmbMotorista.SelectedValue.ToString();            
        }

        private void txtCaminhão_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DGFrete_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = DGFrete.SelectedRows[0].Cells["id"].Value.ToString();
            txtProduto.Text = DGFrete.SelectedRows[0].Cells["produto"].Value.ToString();
            txtLocalPartida.Text = DGFrete.SelectedRows[0].Cells["localEntrega"].Value.ToString();
            txtLocalEntrega.Text = DGFrete.SelectedRows[0].Cells["localPartida"].Value.ToString();
            DTData.Text = DGFrete.SelectedRows[0].Cells["data"].Value.ToString();
            /*txtValor.Text = DGFrete.SelectedRows[0].Cells["valorFrete"].Value.ToString();
            txtIDTransportadora.Text = DGFrete.SelectedRows[0].Cells["transportadoraFK"].Value.ToString();
            txtIDMotorista.Text = DGFrete.SelectedRows[0].Cells["motoristaFK"].Value.ToString();*/

        }
    }
}
