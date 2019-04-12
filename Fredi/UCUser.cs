using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            MySqlConnection allo = new MySqlConnection("database=M2L_DB; server=localhost; user id=root; pwd=");
            allo.Open();
            string getInfo = "SELECT * FROM slips WHERE idMember = '1'" ;
            MySqlDataAdapter coInfo = new MySqlDataAdapter(getInfo, allo);
            DataTable getDt = new DataTable();
            coInfo.Fill(getDt);
            string ouech = getDt.Rows[0][0].ToString();

            sum = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value);

            //slipBindingSource1.Add(new Slip { SlipDate = new DateTime(2019, 04, 08), SlipPattern = "Compétition", SlipPath = "tokyo-Paris", SlipKilometers = 500, PathCost = 260, TollCost = 75, MealCost = 53, AccommodationCost = 168, TotalCost = sum  });


            foreach( DataRow dt in getDt.Rows)
            {
                    slipBindingSource1.Add(new Slip { SlipDate = DateTime.Parse(dt["date"].ToString()) ,
                    SlipPattern = dt["pattern"].ToString(),
                    SlipPath = dt["path"].ToString(),
                    SlipKilometers = Convert.ToInt32(dt["kmsTraveled"]),
                    PathCost = Convert.ToInt32(dt["pathCost"]),
                    TollCost = Convert.ToInt32(dt["tollCost"]),
                    MealCost = Convert.ToInt32(dt["mealCost"]),
                    AccommodationCost = Convert.ToInt32(dt["accomodationCost"]),
                    TotalCost = Convert.ToInt32(dt["totalCost"]), });
            }
            


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
