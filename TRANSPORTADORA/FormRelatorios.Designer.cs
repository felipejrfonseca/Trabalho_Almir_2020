namespace TRANSPORTADORA
{
    partial class FormRelatorios
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
            this.GBRelatorio = new System.Windows.Forms.GroupBox();
            this.RBCombustivel = new System.Windows.Forms.RadioButton();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.RBFretes = new System.Windows.Forms.RadioButton();
            this.GBRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBRelatorio
            // 
            this.GBRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GBRelatorio.Controls.Add(this.RBCombustivel);
            this.GBRelatorio.Controls.Add(this.BtnFiltrar);
            this.GBRelatorio.Controls.Add(this.RBFretes);
            this.GBRelatorio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBRelatorio.ForeColor = System.Drawing.Color.White;
            this.GBRelatorio.Location = new System.Drawing.Point(214, 168);
            this.GBRelatorio.Name = "GBRelatorio";
            this.GBRelatorio.Size = new System.Drawing.Size(499, 125);
            this.GBRelatorio.TabIndex = 28;
            this.GBRelatorio.TabStop = false;
            this.GBRelatorio.Text = "RELATÓRIOS:";
            // 
            // RBCombustivel
            // 
            this.RBCombustivel.AutoSize = true;
            this.RBCombustivel.Location = new System.Drawing.Point(149, 31);
            this.RBCombustivel.Name = "RBCombustivel";
            this.RBCombustivel.Size = new System.Drawing.Size(103, 18);
            this.RBCombustivel.TabIndex = 30;
            this.RBCombustivel.Text = "COMBUSTÍVEL";
            this.RBCombustivel.UseVisualStyleBackColor = true;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BtnFiltrar.Location = new System.Drawing.Point(205, 75);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(88, 38);
            this.BtnFiltrar.TabIndex = 27;
            this.BtnFiltrar.Text = "GERAR";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // RBFretes
            // 
            this.RBFretes.AutoSize = true;
            this.RBFretes.Location = new System.Drawing.Point(275, 31);
            this.RBFretes.Name = "RBFretes";
            this.RBFretes.Size = new System.Drawing.Size(57, 18);
            this.RBFretes.TabIndex = 29;
            this.RBFretes.Text = "FRETE";
            this.RBFretes.UseVisualStyleBackColor = true;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.GBRelatorio);
            this.Name = "FormRelatorios";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            this.GBRelatorio.ResumeLayout(false);
            this.GBRelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBRelatorio;
        private System.Windows.Forms.RadioButton RBCombustivel;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.RadioButton RBFretes;
    }
}