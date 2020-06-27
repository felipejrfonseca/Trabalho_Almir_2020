namespace TRANSPORTADORA.CAMADAS
{
    partial class FormTransportadora
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
            this.txtTransportadora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGTransportadora = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GbBuscar = new System.Windows.Forms.GroupBox();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.RBNome = new System.Windows.Forms.RadioButton();
            this.RBId = new System.Windows.Forms.RadioButton();
            this.LBFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGTransportadora)).BeginInit();
            this.GbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTransportadora
            // 
            this.txtTransportadora.Location = new System.Drawing.Point(339, 94);
            this.txtTransportadora.Name = "txtTransportadora";
            this.txtTransportadora.Size = new System.Drawing.Size(335, 20);
            this.txtTransportadora.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(176, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "TRANSPORTADORA:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(339, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(71, 20);
            this.txtID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // DGTransportadora
            // 
            this.DGTransportadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTransportadora.Location = new System.Drawing.Point(12, 268);
            this.DGTransportadora.Name = "DGTransportadora";
            this.DGTransportadora.Size = new System.Drawing.Size(884, 262);
            this.DGTransportadora.TabIndex = 20;
            this.DGTransportadora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTransportadora_CellContentClick);
            this.DGTransportadora.DoubleClick += new System.EventHandler(this.DGTransportadora_DoubleClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(19, 156);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(88, 38);
            this.BtnExcluir.TabIndex = 19;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(19, 90);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(88, 38);
            this.BtnEditar.TabIndex = 18;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.Location = new System.Drawing.Point(19, 24);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(88, 38);
            this.BtnInserir.TabIndex = 17;
            this.BtnInserir.Text = "INSERIR";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(19, 216);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(88, 38);
            this.BtnBuscar.TabIndex = 25;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GbBuscar
            // 
            this.GbBuscar.Controls.Add(this.LBFiltro);
            this.GbBuscar.Controls.Add(this.RBId);
            this.GbBuscar.Controls.Add(this.BtnFiltrar);
            this.GbBuscar.Controls.Add(this.RBNome);
            this.GbBuscar.Controls.Add(this.TxtFiltro);
            this.GbBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBuscar.ForeColor = System.Drawing.Color.White;
            this.GbBuscar.Location = new System.Drawing.Point(191, 129);
            this.GbBuscar.Name = "GbBuscar";
            this.GbBuscar.Size = new System.Drawing.Size(573, 125);
            this.GbBuscar.TabIndex = 26;
            this.GbBuscar.TabStop = false;
            this.GbBuscar.Text = "FILTRO:";
            this.GbBuscar.Visible = false;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(27, 68);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(394, 20);
            this.TxtFiltro.TabIndex = 27;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BtnFiltrar.Location = new System.Drawing.Point(467, 58);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(88, 38);
            this.BtnFiltrar.TabIndex = 27;
            this.BtnFiltrar.Text = "FILTRAR";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // RBNome
            // 
            this.RBNome.AutoSize = true;
            this.RBNome.Location = new System.Drawing.Point(71, 19);
            this.RBNome.Name = "RBNome";
            this.RBNome.Size = new System.Drawing.Size(56, 18);
            this.RBNome.TabIndex = 29;
            this.RBNome.Text = "NOME";
            this.RBNome.UseVisualStyleBackColor = true;
            this.RBNome.CheckedChanged += new System.EventHandler(this.RBNome_CheckedChanged);
            // 
            // RBId
            // 
            this.RBId.AutoSize = true;
            this.RBId.Location = new System.Drawing.Point(30, 19);
            this.RBId.Name = "RBId";
            this.RBId.Size = new System.Drawing.Size(35, 18);
            this.RBId.TabIndex = 30;
            this.RBId.Text = "ID";
            this.RBId.UseVisualStyleBackColor = true;
            this.RBId.CheckedChanged += new System.EventHandler(this.RBId_CheckedChanged);
            // 
            // LBFiltro
            // 
            this.LBFiltro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFiltro.Location = new System.Drawing.Point(27, 49);
            this.LBFiltro.Name = "LBFiltro";
            this.LBFiltro.Size = new System.Drawing.Size(334, 16);
            this.LBFiltro.TabIndex = 31;
            // 
            // FormTransportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.GbBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtTransportadora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGTransportadora);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnInserir);
            this.Name = "FormTransportadora";
            this.Text = "Transportadora";
            this.Load += new System.EventHandler(this.FormTransportadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTransportadora)).EndInit();
            this.GbBuscar.ResumeLayout(false);
            this.GbBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransportadora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGTransportadora;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GbBuscar;
        private System.Windows.Forms.Label LBFiltro;
        private System.Windows.Forms.RadioButton RBId;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.RadioButton RBNome;
        private System.Windows.Forms.TextBox TxtFiltro;
    }
}