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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(444, 108);
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
            this.button2.Location = new System.Drawing.Point(189, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nouveau";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Annuler";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Mettre A Jour";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "id_personnel",
            "nom_personnel",
            "prenom_personnel",
            "age_personnel"});
            this.comboBox2.Location = new System.Drawing.Point(12, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 322);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}