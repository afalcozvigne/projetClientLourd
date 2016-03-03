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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.idPersonnel = new System.Windows.Forms.Label();
            this.nomPersonnel = new System.Windows.Forms.Label();
            this.prenomPersonnel = new System.Windows.Forms.Label();
            this.agePersonnel = new System.Windows.Forms.Label();
            this.textBoxAgePersonnel = new System.Windows.Forms.TextBox();
            this.textBoxPrenomPersonnel = new System.Windows.Forms.TextBox();
            this.textBoxNomPersonnel = new System.Windows.Forms.TextBox();
            this.textBoxIdPersonnel = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
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
            this.button1.Location = new System.Drawing.Point(813, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retour Accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste du personnel";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nouveau";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Rechercher";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(741, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Annuler";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // idPersonnel
            // 
            this.idPersonnel.AutoSize = true;
            this.idPersonnel.Location = new System.Drawing.Point(526, 101);
            this.idPersonnel.Name = "idPersonnel";
            this.idPersonnel.Size = new System.Drawing.Size(79, 13);
            this.idPersonnel.TabIndex = 6;
            this.idPersonnel.Text = "id du personnel";
            // 
            // nomPersonnel
            // 
            this.nomPersonnel.AutoSize = true;
            this.nomPersonnel.Location = new System.Drawing.Point(526, 119);
            this.nomPersonnel.Name = "nomPersonnel";
            this.nomPersonnel.Size = new System.Drawing.Size(91, 13);
            this.nomPersonnel.TabIndex = 7;
            this.nomPersonnel.Text = "nom du personnel";
            // 
            // prenomPersonnel
            // 
            this.prenomPersonnel.AutoSize = true;
            this.prenomPersonnel.Location = new System.Drawing.Point(526, 141);
            this.prenomPersonnel.Name = "prenomPersonnel";
            this.prenomPersonnel.Size = new System.Drawing.Size(106, 13);
            this.prenomPersonnel.TabIndex = 8;
            this.prenomPersonnel.Text = "prenom du personnel";
            // 
            // agePersonnel
            // 
            this.agePersonnel.AutoSize = true;
            this.agePersonnel.Location = new System.Drawing.Point(526, 166);
            this.agePersonnel.Name = "agePersonnel";
            this.agePersonnel.Size = new System.Drawing.Size(90, 13);
            this.agePersonnel.TabIndex = 9;
            this.agePersonnel.Text = "Age du personnel";
            // 
            // textBoxAgePersonnel
            // 
            this.textBoxAgePersonnel.Location = new System.Drawing.Point(646, 163);
            this.textBoxAgePersonnel.Name = "textBoxAgePersonnel";
            this.textBoxAgePersonnel.Size = new System.Drawing.Size(89, 20);
            this.textBoxAgePersonnel.TabIndex = 10;
            // 
            // textBoxPrenomPersonnel
            // 
            this.textBoxPrenomPersonnel.Location = new System.Drawing.Point(646, 138);
            this.textBoxPrenomPersonnel.Name = "textBoxPrenomPersonnel";
            this.textBoxPrenomPersonnel.Size = new System.Drawing.Size(89, 20);
            this.textBoxPrenomPersonnel.TabIndex = 11;
            // 
            // textBoxNomPersonnel
            // 
            this.textBoxNomPersonnel.Location = new System.Drawing.Point(646, 116);
            this.textBoxNomPersonnel.Name = "textBoxNomPersonnel";
            this.textBoxNomPersonnel.Size = new System.Drawing.Size(89, 20);
            this.textBoxNomPersonnel.TabIndex = 12;
            // 
            // textBoxIdPersonnel
            // 
            this.textBoxIdPersonnel.Location = new System.Drawing.Point(646, 94);
            this.textBoxIdPersonnel.Name = "textBoxIdPersonnel";
            this.textBoxIdPersonnel.Size = new System.Drawing.Size(89, 20);
            this.textBoxIdPersonnel.TabIndex = 13;
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 322);
            this.Controls.Add(this.textBoxIdPersonnel);
            this.Controls.Add(this.textBoxNomPersonnel);
            this.Controls.Add(this.textBoxPrenomPersonnel);
            this.Controls.Add(this.textBoxAgePersonnel);
            this.Controls.Add(this.agePersonnel);
            this.Controls.Add(this.prenomPersonnel);
            this.Controls.Add(this.nomPersonnel);
            this.Controls.Add(this.idPersonnel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personnel";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label idPersonnel;
        private System.Windows.Forms.Label nomPersonnel;
        private System.Windows.Forms.Label prenomPersonnel;
        private System.Windows.Forms.Label agePersonnel;
        private System.Windows.Forms.TextBox textBoxAgePersonnel;
        private System.Windows.Forms.TextBox textBoxPrenomPersonnel;
        private System.Windows.Forms.TextBox textBoxNomPersonnel;
        private System.Windows.Forms.TextBox textBoxIdPersonnel;
    }
}