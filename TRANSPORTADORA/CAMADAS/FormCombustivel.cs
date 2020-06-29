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
    public partial class FormCombustivel : Form
    {
        public FormCombustivel()
        {
            InitializeComponent();
            limparControles();
        }

        public void limparControles()
        {
            txtID.Text = "-1";
            txtIdCaminhao.Text = "";
            txtIdMotorista.Text = "";
            cmbCaminhao.Text = "";
            cmbMotorista.Text = "";
            txtQuantidade.Text = "";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private int calcularEstoque()
        {
            int estoque = 0;
            for (Int32 i = 0; i<DGCombustivel.Rows.Count; i++)
            {
                estoque += Convert.ToInt32(DGCombustivel.Rows[i].Cells[1].Value.ToString());// coluna 2
            }

            return estoque;
        }
        private void FormCombustivel_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Combustivel bllCombustivel = new CAMADAS.BLL.Combustivel();
            CAMADAS.BLL.Caminhoes bllCaminhoes = new CAMADAS.BLL.Caminhoes();
            CAMADAS.BLL.Motorista bllMotorista = new CAMADAS.BLL.Motorista();
            CAMADAS.DAL.Combustivel dalcombustivel = new CAMADAS.DAL.Combustivel();

            
            DGCombustivel.DataSource = bllCombustivel.Select();
            txtEstoque.Text = calcularEstoque().ToString();
            cmbCaminhao.DisplayMember = "placa";
            cmbCaminhao.ValueMember = "id";
            cmbCaminhao.DataSource = bllCaminhoes.Select();

            cmbMotorista.DisplayMember = "nome";
            cmbMotorista.ValueMember = "id";
            cmbMotorista.DataSource = bllMotorista.Select();
            
            limparControles();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Combustivel bllCombustivel = new CAMADAS.BLL.Combustivel();
            CAMADAS.MODEL.Combustivel combustivel = new CAMADAS.MODEL.Combustivel();
            
            if(txtIdCaminhao.Text != "" && txtIdMotorista.Text != "" && txtQuantidade.Text != "")
            {
                int estoque = Int32.Parse(txtQuantidade.Text);
                Convert.ToInt32(txtQuantidade.Text).ToString();

                if (RBEntrada.Checked)
                {                   
                    
                    if(estoque > 0)
                    {
                        combustivel.caminhaoID = Convert.ToInt32(txtIdCaminhao.Text);
                        combustivel.motoristaID = Convert.ToInt32(txtIdMotorista.Text);
                        combustivel.estoque = Convert.ToInt32(txtQuantidade.Text);
                        bllCombustivel.Insert(combustivel);

                        limparControles();

                        DGCombustivel.DataSource = "";
                        DGCombustivel.DataSource = bllCombustivel.Select();

                       
                    }
                    else 
                    {
                        MessageBox.Show("ENTRADAS NO ESTOQUE DEVEM SER POSITIVAS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else if(RBSaida.Checked)
                {
                    if(estoque > 0)
                    {
                        combustivel.caminhaoID = Convert.ToInt32(txtIdCaminhao.Text);
                        combustivel.motoristaID = Convert.ToInt32(txtIdMotorista.Text);
                        estoque = estoque * -1;                        
                        combustivel.estoque = Convert.ToInt32(estoque);
                        bllCombustivel.Insert(combustivel);

                        limparControles();

                        DGCombustivel.DataSource = "";
                        DGCombustivel.DataSource = bllCombustivel.Select();
                    }

                    else
                    {
                        MessageBox.Show("ENTRADAS NO ESTOQUE DEVEM SER POSITIVAS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("NÃO FOI SELECIONADO A OPERAÇÃO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("TODOS OS ITENS DEVEM SER PREENCHIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtEstoque.Text = calcularEstoque().ToString();
        }

        private void cmbCaminhao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdCaminhao.Text = cmbCaminhao.SelectedValue.ToString();
        }

        private void cmbMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdMotorista.Text = cmbMotorista.SelectedValue.ToString();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Combustivel bllCombustivel = new CAMADAS.BLL.Combustivel();

            if (txtID.Text != "-1")
            {
                DialogResult resp = MessageBox.Show("Deseja Excluir Realmente Lançamento de Combustivel?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int idCombustivel = Convert.ToInt32(txtID.Text);
                    bllCombustivel.Delete(idCombustivel);
                }

            }

            else
            {
                MessageBox.Show("Nenhum Frete Selecionado Para Exclusão!", "Excluir Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limparControles();

            DGCombustivel.DataSource = "";
            DGCombustivel.DataSource = bllCombustivel.Select();
        }

        private void DGCombustivel_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = DGCombustivel.SelectedRows[0].Cells["id"].Value.ToString();
            txtQuantidade.Text = DGCombustivel.SelectedRows[0].Cells["estoque"].Value.ToString();
            txtIdCaminhao.Text = DGCombustivel.SelectedRows[0].Cells["caminhaoID"].Value.ToString();
            txtIdMotorista.Text = DGCombustivel.SelectedRows[0].Cells["motoristaID"].Value.ToString();
            
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
