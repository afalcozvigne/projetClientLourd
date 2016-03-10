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
            this.waveattitudeDataSet = new WaveAttitudeDLLForms.waveattitudeDataSet();
            this.personnelTableAdapter = new WaveAttitudeDLLForms.waveattitudeDataSetTableAdapters.personnelTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(37, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 86);
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
            this.personnelBindingSource.DataSource = this.waveattitudeDataSet;
            // 
            // waveattitudeDataSet
            // 
            this.waveattitudeDataSet.DataSetName = "waveattitudeDataSet";
            this.waveattitudeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnelTableAdapter
            // 
            this.personnelTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "id_personnel",
            "nom_personnel",
            "prenom_personnel",
            "age_personnel"});
            this.comboBox1.Location = new System.Drawing.Point(37, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(626, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste du personnel";
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personnel";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveattitudeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private waveattitudeDataSet waveattitudeDataSet;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private waveattitudeDataSetTableAdapters.personnelTableAdapter personnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenompersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agepersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}