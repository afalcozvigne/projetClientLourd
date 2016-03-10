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
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waveattitudeDataSet = new WaveAttitudeDLLForms.waveattitudeDataSet();
            this.utilisateurTableAdapter = new WaveAttitudeDLLForms.waveattitudeDataSetTableAdapters.utilisateurTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.utilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motdepasseutilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.waveattitudeDataSet;
            // 
            // waveattitudeDataSet
            // 
            this.waveattitudeDataSet.DataSetName = "waveattitudeDataSet";
            this.waveattitudeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idutilisateurDataGridViewTextBoxColumn,
            this.nomutilisateurDataGridViewTextBoxColumn,
            this.motdepasseutilisateurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilisateurBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 78);
            this.dataGridView1.TabIndex = 0;
            // 
            // utilisateurBindingSource1
            // 
            this.utilisateurBindingSource1.DataMember = "utilisateur";
            this.utilisateurBindingSource1.DataSource = this.waveattitudeDataSet;
            // 
            // idutilisateurDataGridViewTextBoxColumn
            // 
            this.idutilisateurDataGridViewTextBoxColumn.DataPropertyName = "id_utilisateur";
            this.idutilisateurDataGridViewTextBoxColumn.HeaderText = "id_utilisateur";
            this.idutilisateurDataGridViewTextBoxColumn.Name = "idutilisateurDataGridViewTextBoxColumn";
            this.idutilisateurDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomutilisateurDataGridViewTextBoxColumn
            // 
            this.nomutilisateurDataGridViewTextBoxColumn.DataPropertyName = "nom_utilisateur";
            this.nomutilisateurDataGridViewTextBoxColumn.HeaderText = "nom_utilisateur";
            this.nomutilisateurDataGridViewTextBoxColumn.Name = "nomutilisateurDataGridViewTextBoxColumn";
            this.nomutilisateurDataGridViewTextBoxColumn.Width = 150;
            // 
            // motdepasseutilisateurDataGridViewTextBoxColumn
            // 
            this.motdepasseutilisateurDataGridViewTextBoxColumn.DataPropertyName = "motdepasse_utilisateur";
            this.motdepasseutilisateurDataGridViewTextBoxColumn.HeaderText = "motdepasse_utilisateur";
            this.motdepasseutilisateurDataGridViewTextBoxColumn.Name = "motdepasseutilisateurDataGridViewTextBoxColumn";
            this.motdepasseutilisateurDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retour Accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Infocompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Infocompte";
            this.Text = "Infocompte";
            this.Load += new System.EventHandler(this.Infocompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private waveattitudeDataSet waveattitudeDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private waveattitudeDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.BindingSource utilisateurBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn motdepasseutilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomutilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idutilisateurDataGridViewTextBoxColumn;
    }
}