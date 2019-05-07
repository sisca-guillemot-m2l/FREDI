namespace Fredi
{
    partial class UCAdmin
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textAdmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import fichier CSV user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 441);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifier tarification";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarification en vigueur :";
            // 
            // textAdmin
            // 
            this.textAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAdmin.AutoSize = true;
            this.textAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdmin.Location = new System.Drawing.Point(488, 18);
            this.textAdmin.Name = "textAdmin";
            this.textAdmin.Size = new System.Drawing.Size(287, 46);
            this.textAdmin.TabIndex = 4;
            this.textAdmin.Text = "Administration";
            this.textAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "• Importer fichier CSV comprenant les informations des adhérents recensés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(485, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "• Gestion de la tarification kilométrique en vigueur";
            // 
            // UCAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "UCAdmin";
            this.Size = new System.Drawing.Size(1267, 735);
            this.Load += new System.EventHandler(this.UCAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
