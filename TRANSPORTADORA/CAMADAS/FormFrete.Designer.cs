namespace TRANSPORTADORA.CAMADAS
{
    partial class FormFrete
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTransportadora = new System.Windows.Forms.ComboBox();
            this.txtLocalPartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGFrete = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMotorista = new System.Windows.Forms.ComboBox();
            this.txtLocalEntrega = new System.Windows.Forms.TextBox();
            this.DTData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtIDMotorista = new System.Windows.Forms.TextBox();
            this.txtIDTransportadora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGFrete)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(589, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "MOTORISTA:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbTransportadora
            // 
            this.cmbTransportadora.DisplayMember = "id";
            this.cmbTransportadora.FormattingEnabled = true;
            this.cmbTransportadora.Location = new System.Drawing.Point(697, 67);
            this.cmbTransportadora.Name = "cmbTransportadora";
            this.cmbTransportadora.Size = new System.Drawing.Size(199, 21);
            this.cmbTransportadora.TabIndex = 7;
            this.cmbTransportadora.ValueMember = "id";
            this.cmbTransportadora.SelectedIndexChanged += new System.EventHandler(this.cmbMotorista_SelectedIndexChanged);
            // 
            // txtLocalPartida
            // 
            this.txtLocalPartida.Location = new System.Drawing.Point(283, 98);
            this.txtLocalPartida.Name = "txtLocalPartida";
            this.txtLocalPartida.Size = new System.Drawing.Size(236, 20);
            this.txtLocalPartida.TabIndex = 3;
            this.txtLocalPartida.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "LOCAL DE PARTIDA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(283, 67);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(236, 20);
            this.txtProduto.TabIndex = 2;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "PRODUTO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(283, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(106, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGFrete
            // 
            this.DGFrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFrete.Location = new System.Drawing.Point(12, 268);
            this.DGFrete.Name = "DGFrete";
            this.DGFrete.Size = new System.Drawing.Size(884, 262);
            this.DGFrete.TabIndex = 49;
            this.DGFrete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCaminhoes_CellContentClick);
            this.DGFrete.DoubleClick += new System.EventHandler(this.DGFrete_DoubleClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(19, 164);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(88, 38);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(19, 98);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(88, 38);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.Location = new System.Drawing.Point(19, 32);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(88, 38);
            this.BtnInserir.TabIndex = 9;
            this.BtnInserir.Text = "INSERIR";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(113, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "LOCAL DE ENTREGA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(228, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "DATA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(630, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 57;
            this.label8.Text = "VALOR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(534, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 18);
            this.label9.TabIndex = 58;
            this.label9.Text = "TRANSPORTADORA:";
            // 
            // cmbMotorista
            // 
            this.cmbMotorista.DisplayMember = "id";
            this.cmbMotorista.FormattingEnabled = true;
            this.cmbMotorista.Location = new System.Drawing.Point(697, 30);
            this.cmbMotorista.Name = "cmbMotorista";
            this.cmbMotorista.Size = new System.Drawing.Size(199, 21);
            this.cmbMotorista.TabIndex = 6;
            this.cmbMotorista.ValueMember = "id";
            this.cmbMotorista.SelectedIndexChanged += new System.EventHandler(this.cmbMotorista_SelectedIndexChanged_1);
            // 
            // txtLocalEntrega
            // 
            this.txtLocalEntrega.Location = new System.Drawing.Point(283, 135);
            this.txtLocalEntrega.Name = "txtLocalEntrega";
            this.txtLocalEntrega.Size = new System.Drawing.Size(236, 20);
            this.txtLocalEntrega.TabIndex = 4;
            // 
            // DTData
            // 
            this.DTData.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTData.Location = new System.Drawing.Point(283, 166);
            this.DTData.Name = "DTData";
            this.DTData.Size = new System.Drawing.Size(236, 22);
            this.DTData.TabIndex = 5;
            this.DTData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(697, 172);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(137, 20);
            this.txtValor.TabIndex = 8;
            // 
            // txtIDMotorista
            // 
            this.txtIDMotorista.Location = new System.Drawing.Point(711, 94);
            this.txtIDMotorista.Name = "txtIDMotorista";
            this.txtIDMotorista.Size = new System.Drawing.Size(37, 20);
            this.txtIDMotorista.TabIndex = 65;
            this.txtIDMotorista.Visible = false;
            this.txtIDMotorista.TextChanged += new System.EventHandler(this.txtIDMotorista_TextChanged);
            // 
            // txtIDTransportadora
            // 
            this.txtIDTransportadora.Location = new System.Drawing.Point(754, 94);
            this.txtIDTransportadora.Name = "txtIDTransportadora";
            this.txtIDTransportadora.Size = new System.Drawing.Size(37, 20);
            this.txtIDTransportadora.TabIndex = 67;
            this.txtIDTransportadora.Visible = false;
            // 
            // FormFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.txtIDTransportadora);
            this.Controls.Add(this.txtIDMotorista);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.DTData);
            this.Controls.Add(this.txtLocalEntrega);
            this.Controls.Add(this.cmbMotorista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTransportadora);
            this.Controls.Add(this.txtLocalPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGFrete);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnInserir);
            this.Name = "FormFrete";
            this.Text = "Frete";
            this.Load += new System.EventHandler(this.FormFrete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGFrete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTransportadora;
        private System.Windows.Forms.TextBox txtLocalPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGFrete;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMotorista;
        private System.Windows.Forms.TextBox txtLocalEntrega;
        private System.Windows.Forms.DateTimePicker DTData;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtIDMotorista;
        private System.Windows.Forms.TextBox txtIDTransportadora;
    }
}