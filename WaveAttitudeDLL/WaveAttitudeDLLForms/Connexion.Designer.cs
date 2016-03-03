namespace WaveAttitudeDLLForms
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.m_connexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomCompte = new System.Windows.Forms.TextBox();
            this.motdepasseCompte = new System.Windows.Forms.TextBox();
            this.m_compteinexistant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_connexion
            // 
            this.m_connexion.Location = new System.Drawing.Point(138, 95);
            this.m_connexion.Name = "m_connexion";
            this.m_connexion.Size = new System.Drawing.Size(141, 40);
            this.m_connexion.TabIndex = 0;
            this.m_connexion.Text = "Connexion";
            this.m_connexion.UseVisualStyleBackColor = true;
            this.m_connexion.Click += new System.EventHandler(this.m_connexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe    ";
            // 
            // nomCompte
            // 
            this.nomCompte.Location = new System.Drawing.Point(138, 43);
            this.nomCompte.Name = "nomCompte";
            this.nomCompte.Size = new System.Drawing.Size(141, 20);
            this.nomCompte.TabIndex = 4;
            this.nomCompte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomCompte_KeyPress);
            // 
            // motdepasseCompte
            // 
            this.motdepasseCompte.Location = new System.Drawing.Point(138, 69);
            this.motdepasseCompte.Name = "motdepasseCompte";
            this.motdepasseCompte.Size = new System.Drawing.Size(141, 20);
            this.motdepasseCompte.TabIndex = 5;
            this.motdepasseCompte.UseSystemPasswordChar = true;
            this.motdepasseCompte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.motdepasseCompte_KeyPress);
            // 
            // m_compteinexistant
            // 
            this.m_compteinexistant.Location = new System.Drawing.Point(138, 141);
            this.m_compteinexistant.Name = "m_compteinexistant";
            this.m_compteinexistant.Size = new System.Drawing.Size(141, 40);
            this.m_compteinexistant.TabIndex = 6;
            this.m_compteinexistant.Text = "Pas de compte ?!";
            this.m_compteinexistant.UseVisualStyleBackColor = true;
            this.m_compteinexistant.Click += new System.EventHandler(this.m_compteinexistant_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 322);
            this.Controls.Add(this.m_compteinexistant);
            this.Controls.Add(this.nomCompte);
            this.Controls.Add(this.motdepasseCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_connexion);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_connexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomCompte;
        private System.Windows.Forms.TextBox motdepasseCompte;
        private System.Windows.Forms.Button m_compteinexistant;
    }
}

