namespace Fredi
{
    partial class UCTreasure
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumLicence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.slipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.slipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmsTraveled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accommodationCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Valider = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Prenom,
            this.Nom,
            this.NumLicence});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1288, 177);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 5;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 342;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 342;
            // 
            // NumLicence
            // 
            this.NumLicence.Text = "Numéro de licence";
            this.NumLicence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumLicence.Width = 342;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(374, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numéro de licence";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(693, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 22);
            this.textBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(996, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Obtenir bordereau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Validate,
            this.date,
            this.pattern,
            this.path,
            this.kmsTraveled,
            this.pathCost,
            this.tollCost,
            this.mealCost,
            this.accommodationCost,
            this.totalCost,
            this.Modifier,
            this.Valider});
            this.dataGridView1.DataSource = this.slipBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 262);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // slipBindingSource1
            // 
            this.slipBindingSource1.DataSource = typeof(Fredi.Slip);
            // 
            // slipBindingSource
            // 
            this.slipBindingSource.DataSource = typeof(Fredi.Slip);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            // 
            // Validate
            // 
            this.Validate.DataPropertyName = "Validate";
            this.Validate.HeaderText = "";
            this.Validate.Name = "Validate";
            this.Validate.Width = 25;
            // 
            // date
            // 
            this.date.DataPropertyName = "SlipDate";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 80;
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
            this.path.Width = 135;
            // 
            // kmsTraveled
            // 
            this.kmsTraveled.DataPropertyName = "SlipKilometers";
            this.kmsTraveled.HeaderText = "Kms parcourus";
            this.kmsTraveled.Name = "kmsTraveled";
            this.kmsTraveled.Width = 70;
            // 
            // pathCost
            // 
            this.pathCost.DataPropertyName = "PathCost";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.pathCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.pathCost.HeaderText = "Cout trajet";
            this.pathCost.Name = "pathCost";
            this.pathCost.Width = 70;
            // 
            // tollCost
            // 
            this.tollCost.DataPropertyName = "TollCost";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.tollCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.tollCost.HeaderText = "Cout péage";
            this.tollCost.Name = "tollCost";
            this.tollCost.Width = 75;
            // 
            // mealCost
            // 
            this.mealCost.DataPropertyName = "MealCost";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.mealCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.mealCost.HeaderText = "Cout repas";
            this.mealCost.Name = "mealCost";
            this.mealCost.Width = 75;
            // 
            // accommodationCost
            // 
            this.accommodationCost.DataPropertyName = "AccommodationCost";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.accommodationCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.accommodationCost.HeaderText = "Cout hébergement";
            this.accommodationCost.Name = "accommodationCost";
            this.accommodationCost.Width = 110;
            // 
            // totalCost
            // 
            this.totalCost.DataPropertyName = "TotalCost";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.totalCost.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalCost.HeaderText = "Cout total";
            this.totalCost.Name = "totalCost";
            this.totalCost.Width = 75;
            // 
            // Modifier
            // 
            this.Modifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Width = 64;
            // 
            // Valider
            // 
            this.Valider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Valider.HeaderText = "Valider";
            this.Valider.Name = "Valider";
            this.Valider.Width = 58;
            // 
            // UCTreasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Name = "UCTreasure";
            this.Size = new System.Drawing.Size(1288, 861);
            this.Load += new System.EventHandler(this.UCTreasure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource slipBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader NumLicence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource slipBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validate;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmsTraveled;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn accommodationCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Valider;
    }
}
