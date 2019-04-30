namespace Fredi
{
    partial class UCHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.label2 = new System.Windows.Forms.Label();
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.btnco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(963, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenue sur l\'application de La Maison Des Ligues !";
            // 
            // Loginpanel
            // 
            this.Loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Loginpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loginpanel.Controls.Add(this.btnco);
            this.Loginpanel.Controls.Add(this.label4);
            this.Loginpanel.Controls.Add(this.pictureBox2);
            this.Loginpanel.Controls.Add(this.pictureBox1);
            this.Loginpanel.Controls.Add(this.textpwd);
            this.Loginpanel.Controls.Add(this.label3);
            this.Loginpanel.Controls.Add(this.textmail);
            this.Loginpanel.Controls.Add(this.label1);
            this.Loginpanel.Location = new System.Drawing.Point(394, 138);
            this.Loginpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(500, 624);
            this.Loginpanel.TabIndex = 2;
            // 
            // btnco
            // 
            this.btnco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnco.Location = new System.Drawing.Point(180, 416);
            this.btnco.Margin = new System.Windows.Forms.Padding(4);
            this.btnco.Name = "btnco";
            this.btnco.Size = new System.Drawing.Size(140, 64);
            this.btnco.TabIndex = 9;
            this.btnco.Text = "Se connecter";
            this.btnco.UseVisualStyleBackColor = true;
            this.btnco.Click += new System.EventHandler(this.btnco_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 108);
            this.label4.TabIndex = 8;
            this.label4.Text = "Connexion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 209);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 317);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textpwd
            // 
            this.textpwd.BackColor = System.Drawing.SystemColors.Control;
            this.textpwd.Location = new System.Drawing.Point(204, 318);
            this.textpwd.Margin = new System.Windows.Forms.Padding(4);
            this.textpwd.Name = "textpwd";
            this.textpwd.PasswordChar = '•';
            this.textpwd.Size = new System.Drawing.Size(286, 32);
            this.textpwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // textmail
            // 
            this.textmail.BackColor = System.Drawing.SystemColors.Control;
            this.textmail.Location = new System.Drawing.Point(204, 209);
            this.textmail.Margin = new System.Windows.Forms.Padding(4);
            this.textmail.Name = "textmail";
            this.textmail.Size = new System.Drawing.Size(286, 32);
            this.textmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(355, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 12);
            this.panel2.TabIndex = 3;
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Loginpanel);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1288, 777);
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textpwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnco;
        public System.Windows.Forms.TextBox textmail;
    }
}
