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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nOVO_TRANSPORTADORADataSet1 = new TRANSPORTADORA.NOVO_TRANSPORTADORADataSet1();
            this.corBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corTableAdapter = new TRANSPORTADORA.NOVO_TRANSPORTADORADataSet1TableAdapters.CorTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOVO_TRANSPORTADORADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.corBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(185, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // nOVO_TRANSPORTADORADataSet1
            // 
            this.nOVO_TRANSPORTADORADataSet1.DataSetName = "NOVO_TRANSPORTADORADataSet1";
            this.nOVO_TRANSPORTADORADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corBindingSource
            // 
            this.corBindingSource.DataMember = "Cor";
            this.corBindingSource.DataSource = this.nOVO_TRANSPORTADORADataSet1;
            // 
            // corTableAdapter
            // 
            this.corTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRelatorios";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOVO_TRANSPORTADORADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NOVO_TRANSPORTADORADataSet1 nOVO_TRANSPORTADORADataSet1;
        private System.Windows.Forms.BindingSource corBindingSource;
        private NOVO_TRANSPORTADORADataSet1TableAdapters.CorTableAdapter corTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
    }
}