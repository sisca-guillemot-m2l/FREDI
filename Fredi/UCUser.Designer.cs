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
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmsTraveled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccommodationCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajouter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.slipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // PathCost
            // 
            this.PathCost.DataPropertyName = "PathCost";
            this.PathCost.HeaderText = "Cout trajet";
            this.PathCost.Name = "PathCost";
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
            // AccommodationCost
            // 
            this.AccommodationCost.DataPropertyName = "AccommodationCost";
            this.AccommodationCost.HeaderText = "Cout hébergement";
            this.AccommodationCost.Name = "AccommodationCost";
            // 
            // totalCost
            // 
            this.totalCost.DataPropertyName = "TotalCost";
            this.totalCost.HeaderText = "Total";
            this.totalCost.Name = "totalCost";
            this.totalCost.Width = 70;
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
            // slipBindingSource1
            // 
            this.slipBindingSource1.DataSource = typeof(Fredi.Slip);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1140, 832);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CECI EST UN TEST";
            // 
            // slipBindingSource
            // 
            this.slipBindingSource.DataSource = typeof(Fredi.Slip);
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1288, 861);
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
        private System.Windows.Forms.Label label1;
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
    }
}
