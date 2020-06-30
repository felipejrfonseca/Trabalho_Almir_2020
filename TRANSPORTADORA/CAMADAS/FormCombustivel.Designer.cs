namespace TRANSPORTADORA.CAMADAS
{
    partial class FormCombustivel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdCaminhao = new System.Windows.Forms.TextBox();
            this.txtIdMotorista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMotorista = new System.Windows.Forms.ComboBox();
            this.cmbCaminhao = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RBEntrada = new System.Windows.Forms.RadioButton();
            this.RBSaida = new System.Windows.Forms.RadioButton();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGCombustivel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGCombustivel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCaminhao
            // 
            this.txtIdCaminhao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdCaminhao.Location = new System.Drawing.Point(840, 46);
            this.txtIdCaminhao.Name = "txtIdCaminhao";
            this.txtIdCaminhao.Size = new System.Drawing.Size(40, 20);
            this.txtIdCaminhao.TabIndex = 58;
            this.txtIdCaminhao.Visible = false;
            // 
            // txtIdMotorista
            // 
            this.txtIdMotorista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdMotorista.Location = new System.Drawing.Point(840, 72);
            this.txtIdMotorista.Name = "txtIdMotorista";
            this.txtIdMotorista.Size = new System.Drawing.Size(40, 20);
            this.txtIdMotorista.TabIndex = 57;
            this.txtIdMotorista.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(199, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "MOTORISTA:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "CAMINHÃO:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbMotorista
            // 
            this.cmbMotorista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbMotorista.DisplayMember = "id";
            this.cmbMotorista.FormattingEnabled = true;
            this.cmbMotorista.Location = new System.Drawing.Point(307, 115);
            this.cmbMotorista.Name = "cmbMotorista";
            this.cmbMotorista.Size = new System.Drawing.Size(201, 21);
            this.cmbMotorista.TabIndex = 47;
            this.cmbMotorista.ValueMember = "id";
            this.cmbMotorista.SelectedIndexChanged += new System.EventHandler(this.cmbMotorista_SelectedIndexChanged);
            // 
            // cmbCaminhao
            // 
            this.cmbCaminhao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCaminhao.DisplayMember = "id";
            this.cmbCaminhao.FormattingEnabled = true;
            this.cmbCaminhao.Location = new System.Drawing.Point(307, 73);
            this.cmbCaminhao.Name = "cmbCaminhao";
            this.cmbCaminhao.Size = new System.Drawing.Size(201, 21);
            this.cmbCaminhao.TabIndex = 46;
            this.cmbCaminhao.ValueMember = "id";
            this.cmbCaminhao.SelectedIndexChanged += new System.EventHandler(this.cmbCaminhao_SelectedIndexChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantidade.Location = new System.Drawing.Point(307, 158);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(106, 20);
            this.txtQuantidade.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "QUANTIDADE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(307, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(106, 20);
            this.txtID.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(19, 98);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(88, 38);
            this.BtnExcluir.TabIndex = 50;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.Location = new System.Drawing.Point(19, 32);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(88, 38);
            this.BtnInserir.TabIndex = 48;
            this.BtnInserir.Text = "INSERIR";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(415, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Litros.";
            // 
            // RBEntrada
            // 
            this.RBEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RBEntrada.AutoSize = true;
            this.RBEntrada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBEntrada.ForeColor = System.Drawing.Color.White;
            this.RBEntrada.Location = new System.Drawing.Point(279, 205);
            this.RBEntrada.Name = "RBEntrada";
            this.RBEntrada.Size = new System.Drawing.Size(75, 20);
            this.RBEntrada.TabIndex = 60;
            this.RBEntrada.TabStop = true;
            this.RBEntrada.Text = "Entrada";
            this.RBEntrada.UseVisualStyleBackColor = true;
            // 
            // RBSaida
            // 
            this.RBSaida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RBSaida.AutoSize = true;
            this.RBSaida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSaida.ForeColor = System.Drawing.Color.White;
            this.RBSaida.Location = new System.Drawing.Point(391, 205);
            this.RBSaida.Name = "RBSaida";
            this.RBSaida.Size = new System.Drawing.Size(63, 20);
            this.RBSaida.TabIndex = 61;
            this.RBSaida.TabStop = true;
            this.RBSaida.Text = "Saída";
            this.RBSaida.UseVisualStyleBackColor = true;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(790, 242);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(106, 20);
            this.txtEstoque.TabIndex = 62;
            this.txtEstoque.TextChanged += new System.EventHandler(this.txtEstoque_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(697, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "ESTOQUE:";
            // 
            // DGCombustivel
            // 
            this.DGCombustivel.AllowUserToAddRows = false;
            this.DGCombustivel.AllowUserToDeleteRows = false;
            this.DGCombustivel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DGCombustivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCombustivel.Location = new System.Drawing.Point(12, 268);
            this.DGCombustivel.Name = "DGCombustivel";
            this.DGCombustivel.ReadOnly = true;
            this.DGCombustivel.Size = new System.Drawing.Size(884, 262);
            this.DGCombustivel.TabIndex = 51;
            this.DGCombustivel.DoubleClick += new System.EventHandler(this.DGCombustivel_DoubleClick);
            // 
            // FormCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RBSaida);
            this.Controls.Add(this.RBEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCaminhao);
            this.Controls.Add(this.txtIdMotorista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMotorista);
            this.Controls.Add(this.cmbCaminhao);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGCombustivel);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnInserir);
            this.Name = "FormCombustivel";
            this.Text = "Combustível";
            this.Load += new System.EventHandler(this.FormCombustivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCombustivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCaminhao;
        private System.Windows.Forms.TextBox txtIdMotorista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMotorista;
        private System.Windows.Forms.ComboBox cmbCaminhao;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RBEntrada;
        private System.Windows.Forms.RadioButton RBSaida;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn atualEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DGCombustivel;
    }
}