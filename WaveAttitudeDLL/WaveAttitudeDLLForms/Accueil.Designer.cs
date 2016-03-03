namespace WaveAttitudeDLLForms
{
    partial class Accueil
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
            this.m_personnalisation = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_compte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_personnalisation
            // 
            this.m_personnalisation.Location = new System.Drawing.Point(12, 55);
            this.m_personnalisation.Name = "m_personnalisation";
            this.m_personnalisation.Size = new System.Drawing.Size(156, 57);
            this.m_personnalisation.TabIndex = 0;
            this.m_personnalisation.Text = "Personnalisation";
            this.m_personnalisation.UseVisualStyleBackColor = true;
            this.m_personnalisation.Click += new System.EventHandler(this.m_personnalisation_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(736, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Liste du Personnel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(736, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Accueil de Wave Attitude";
            // 
            // m_compte
            // 
            this.m_compte.Location = new System.Drawing.Point(769, 9);
            this.m_compte.Name = "m_compte";
            this.m_compte.Size = new System.Drawing.Size(123, 23);
            this.m_compte.TabIndex = 6;
            this.m_compte.Text = "Info de mon Compte";
            this.m_compte.UseVisualStyleBackColor = true;
            this.m_compte.Click += new System.EventHandler(this.m_compte_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 322);
            this.Controls.Add(this.m_compte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_personnalisation);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_personnalisation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_compte;
    }
}