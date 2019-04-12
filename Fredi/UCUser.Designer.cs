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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.slipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slipPatternDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slipPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slipKilometersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accommodationCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.slipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slipDateDataGridViewTextBoxColumn,
            this.slipPatternDataGridViewTextBoxColumn,
            this.slipPathDataGridViewTextBoxColumn,
            this.slipKilometersDataGridViewTextBoxColumn,
            this.pathCostDataGridViewTextBoxColumn,
            this.tollCostDataGridViewTextBoxColumn,
            this.mealCostDataGridViewTextBoxColumn,
            this.accommodationCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.Ajouter,
            this.Modifier,
            this.Supprimer});
            this.dataGridView1.DataSource = this.slipBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // slipDateDataGridViewTextBoxColumn
            // 
            this.slipDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.slipDateDataGridViewTextBoxColumn.DataPropertyName = "SlipDate";
            this.slipDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.slipDateDataGridViewTextBoxColumn.Name = "slipDateDataGridViewTextBoxColumn";
            this.slipDateDataGridViewTextBoxColumn.Width = 24;
            // 
            // slipPatternDataGridViewTextBoxColumn
            // 
            this.slipPatternDataGridViewTextBoxColumn.DataPropertyName = "SlipPattern";
            this.slipPatternDataGridViewTextBoxColumn.HeaderText = "Motif";
            this.slipPatternDataGridViewTextBoxColumn.Name = "slipPatternDataGridViewTextBoxColumn";
            // 
            // slipPathDataGridViewTextBoxColumn
            // 
            this.slipPathDataGridViewTextBoxColumn.DataPropertyName = "SlipPath";
            this.slipPathDataGridViewTextBoxColumn.HeaderText = "Trajet";
            this.slipPathDataGridViewTextBoxColumn.Name = "slipPathDataGridViewTextBoxColumn";
            this.slipPathDataGridViewTextBoxColumn.Width = 150;
            // 
            // slipKilometersDataGridViewTextBoxColumn
            // 
            this.slipKilometersDataGridViewTextBoxColumn.DataPropertyName = "SlipKilometers";
            this.slipKilometersDataGridViewTextBoxColumn.HeaderText = "Kms parcourus";
            this.slipKilometersDataGridViewTextBoxColumn.Name = "slipKilometersDataGridViewTextBoxColumn";
            this.slipKilometersDataGridViewTextBoxColumn.Width = 75;
            // 
            // pathCostDataGridViewTextBoxColumn
            // 
            this.pathCostDataGridViewTextBoxColumn.DataPropertyName = "PathCost";
            this.pathCostDataGridViewTextBoxColumn.HeaderText = "Cout trajet";
            this.pathCostDataGridViewTextBoxColumn.Name = "pathCostDataGridViewTextBoxColumn";
            this.pathCostDataGridViewTextBoxColumn.Width = 70;
            // 
            // tollCostDataGridViewTextBoxColumn
            // 
            this.tollCostDataGridViewTextBoxColumn.DataPropertyName = "TollCost";
            this.tollCostDataGridViewTextBoxColumn.HeaderText = "Cout péage";
            this.tollCostDataGridViewTextBoxColumn.Name = "tollCostDataGridViewTextBoxColumn";
            this.tollCostDataGridViewTextBoxColumn.Width = 70;
            // 
            // mealCostDataGridViewTextBoxColumn
            // 
            this.mealCostDataGridViewTextBoxColumn.DataPropertyName = "MealCost";
            this.mealCostDataGridViewTextBoxColumn.HeaderText = "Cout repas";
            this.mealCostDataGridViewTextBoxColumn.Name = "mealCostDataGridViewTextBoxColumn";
            this.mealCostDataGridViewTextBoxColumn.Width = 70;
            // 
            // accommodationCostDataGridViewTextBoxColumn
            // 
            this.accommodationCostDataGridViewTextBoxColumn.DataPropertyName = "AccommodationCost";
            this.accommodationCostDataGridViewTextBoxColumn.HeaderText = "Cout hebergement";
            this.accommodationCostDataGridViewTextBoxColumn.Name = "accommodationCostDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Width = 70;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn slipDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slipPatternDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slipPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slipKilometersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accommodationCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Ajouter;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}
