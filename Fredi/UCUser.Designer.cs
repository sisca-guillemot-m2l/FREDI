namespace Fredi
{
    partial class UCUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PathCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccommodationCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajouter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmsTraveled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.slipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.pattern,
            this.path,
            this.kmsTraveled,
            this.PathCost,
            this.tollCost,
            this.mealCost,
            this.AccommodationCost,
            this.totalCost,
            this.Ajouter,
            this.Modifier,
            this.Supprimer});
            this.dataGridView1.DataSource = this.slipBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PathCost
            // 
            this.PathCost.DataPropertyName = "PathCost";
            this.PathCost.HeaderText = "Cout trajet";
            this.PathCost.Name = "PathCost";
            // 
            // AccommodationCost
            // 
            this.AccommodationCost.DataPropertyName = "AccommodationCost";
            this.AccommodationCost.HeaderText = "Cout hébergement";
            this.AccommodationCost.Name = "AccommodationCost";
            // 
            // Ajouter
            // 
            this.Ajouter.HeaderText = "Ajouter";
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseColumnTextForButtonValue = true;
            this.Ajouter.Width = 60;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            this.Modifier.Width = 63;
            // 
            // Supprimer
            // 
            this.Supprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 79;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obtenir PDF pour impression";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Déposer bordereau signé";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(251, 603);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 37);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 601);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Oui, je dépose ce bordereau";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.DataPropertyName = "SlipDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 67;
            // 
            // pattern
            // 
            this.pattern.DataPropertyName = "SlipPattern";
            this.pattern.HeaderText = "Motif";
            this.pattern.Name = "pattern";
            // 
            // path
            // 
            this.path.DataPropertyName = "SlipPath";
            this.path.HeaderText = "Trajet";
            this.path.Name = "path";
            this.path.Width = 150;
            // 
            // kmsTraveled
            // 
            this.kmsTraveled.DataPropertyName = "SlipKilometers";
            this.kmsTraveled.HeaderText = "Kms parcourus";
            this.kmsTraveled.Name = "kmsTraveled";
            this.kmsTraveled.Width = 75;
            // 
            // tollCost
            // 
            this.tollCost.DataPropertyName = "TollCost";
            this.tollCost.HeaderText = "Cout péage";
            this.tollCost.Name = "tollCost";
            this.tollCost.Width = 70;
            // 
            // mealCost
            // 
            this.mealCost.DataPropertyName = "MealCost";
            this.mealCost.HeaderText = "Cout repas";
            this.mealCost.Name = "mealCost";
            this.mealCost.Width = 70;
            // 
            // totalCost
            // 
            this.totalCost.DataPropertyName = "TotalCost";
            this.totalCost.HeaderText = "Total";
            this.totalCost.Name = "totalCost";
            this.totalCost.Width = 70;
            // 
            // slipBindingSource1
            // 
            this.slipBindingSource1.DataSource = typeof(Fredi.Slip);
            // 
            // slipBindingSource
            // 
            this.slipBindingSource.DataSource = typeof(Fredi.Slip);
            // 
            // UCUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1162, 756);
            this.Load += new System.EventHandler(this.UCUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource slipBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource slipBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmsTraveled;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccommodationCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
        private System.Windows.Forms.DataGridViewButtonColumn Ajouter;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}
