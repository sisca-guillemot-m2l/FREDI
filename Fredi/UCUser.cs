using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fredi
{
    public partial class UCUser : UserControl
    {
        public UCUser()
        {
            InitializeComponent();
        }

        private void UCUser_Load(object sender, EventArgs e)
        {
            int sum = 0;

            sum = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value);

            slipBindingSource1.Add(new Slip { SlipDate = new DateTime(2019, 04, 08), SlipPattern = "Compétition", SlipPath = "tokyo-Paris", SlipKilometers = 500, PathCost = 260, TollCost = 75, MealCost = 53, AccommodationCost = 168, TotalCost = sum  });
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Ajouter")
            {
                slipBindingSource1.Add(new Slip { });
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                slipBindingSource1.RemoveCurrent();
            }
        }
    }
}
