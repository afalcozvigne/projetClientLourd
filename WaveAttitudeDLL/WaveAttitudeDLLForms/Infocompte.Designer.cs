namespace WaveAttitudeDLLForms
{
    partial class Infocompte
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
            this.waveattitudeDataSet = new WaveAttitudeDLLForms.waveattitudeDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new WaveAttitudeDLLForms.waveattitudeDataSetTableAdapters.utilisateurTableAdapter();
            this.idutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motdepasseutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idutilisateurDataGridViewTextBoxColumn,
            this.nomutilisateurDataGridViewTextBoxColumn,
            this.motdepasseutilisateurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilisateurBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // waveattitudeDataSet
            // 
            this.waveattitudeDataSet.DataSetName = "waveattitudeDataSet";
            this.waveattitudeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.waveattitudeDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // idutilisateurDataGridViewTextBoxColumn
            // 
            this.idutilisateurDataGridViewTextBoxColumn.DataPropertyName = "id_utilisateur";
            this.idutilisateurDataGridViewTextBoxColumn.HeaderText = "id_utilisateur";
            this.idutilisateurDataGridViewTextBoxColumn.Name = "idutilisateurDataGridViewTextBoxColumn";
            // 
            // nomutilisateurDataGridViewTextBoxColumn
            // 
            this.nomutilisateurDataGridViewTextBoxColumn.DataPropertyName = "nom_utilisateur";
            this.nomutilisateurDataGridViewTextBoxColumn.HeaderText = "nom_utilisateur";
            this.nomutilisateurDataGridViewTextBoxColumn.Name = "nomutilisateurDataGridViewTextBoxColumn";
            // 
            // motdepasseutilisateurDataGridViewTextBoxColumn
            // 
            this.motdepasseutilisateurDataGridViewTextBoxColumn.DataPropertyName = "motdepasse_utilisateur";
            this.motdepasseutilisateurDataGridViewTextBoxColumn.HeaderText = "motdepasse_utilisateur";
            this.motdepasseutilisateurDataGridViewTextBoxColumn.Name = "motdepasseutilisateurDataGridViewTextBoxColumn";
            // 
            // Infocompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Infocompte";
            this.Text = "Infocompte";
            this.Load += new System.EventHandler(this.Infocompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private waveattitudeDataSet waveattitudeDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private waveattitudeDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idutilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomutilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motdepasseutilisateurDataGridViewTextBoxColumn;
    }
}