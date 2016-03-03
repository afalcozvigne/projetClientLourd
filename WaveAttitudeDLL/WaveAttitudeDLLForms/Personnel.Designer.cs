namespace WaveAttitudeDLLForms
{
    partial class Personnel
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
            this.idpersonnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompersonnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenompersonnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agepersonnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waveattitudeDataSet1 = new WaveAttitudeDLLForms.waveattitudeDataSet1();
            this.personnelTableAdapter = new WaveAttitudeDLLForms.waveattitudeDataSet1TableAdapters.personnelTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpersonnelDataGridViewTextBoxColumn,
            this.nompersonnelDataGridViewTextBoxColumn,
            this.prenompersonnelDataGridViewTextBoxColumn,
            this.agepersonnelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personnelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(168, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpersonnelDataGridViewTextBoxColumn
            // 
            this.idpersonnelDataGridViewTextBoxColumn.DataPropertyName = "id_personnel";
            this.idpersonnelDataGridViewTextBoxColumn.HeaderText = "id_personnel";
            this.idpersonnelDataGridViewTextBoxColumn.Name = "idpersonnelDataGridViewTextBoxColumn";
            // 
            // nompersonnelDataGridViewTextBoxColumn
            // 
            this.nompersonnelDataGridViewTextBoxColumn.DataPropertyName = "nom_personnel";
            this.nompersonnelDataGridViewTextBoxColumn.HeaderText = "nom_personnel";
            this.nompersonnelDataGridViewTextBoxColumn.Name = "nompersonnelDataGridViewTextBoxColumn";
            // 
            // prenompersonnelDataGridViewTextBoxColumn
            // 
            this.prenompersonnelDataGridViewTextBoxColumn.DataPropertyName = "prenom_personnel";
            this.prenompersonnelDataGridViewTextBoxColumn.HeaderText = "prenom_personnel";
            this.prenompersonnelDataGridViewTextBoxColumn.Name = "prenompersonnelDataGridViewTextBoxColumn";
            // 
            // agepersonnelDataGridViewTextBoxColumn
            // 
            this.agepersonnelDataGridViewTextBoxColumn.DataPropertyName = "age_personnel";
            this.agepersonnelDataGridViewTextBoxColumn.HeaderText = "age_personnel";
            this.agepersonnelDataGridViewTextBoxColumn.Name = "agepersonnelDataGridViewTextBoxColumn";
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "personnel";
            this.personnelBindingSource.DataSource = this.waveattitudeDataSet1;
            // 
            // waveattitudeDataSet1
            // 
            this.waveattitudeDataSet1.DataSetName = "waveattitudeDataSet1";
            this.waveattitudeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnelTableAdapter
            // 
            this.personnelTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retour Accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personnel";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private waveattitudeDataSet1 waveattitudeDataSet1;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private waveattitudeDataSet1TableAdapters.personnelTableAdapter personnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenompersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agepersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}