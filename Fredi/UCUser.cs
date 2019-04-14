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
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection getSlip = new MySqlConnection(connString);
            getSlip.Open();
            string getInfo = "SELECT * FROM slips WHERE idMember = '1'" ;
            MySqlDataAdapter coInfo = new MySqlDataAdapter(getInfo, getSlip);
            DataTable getDt = new DataTable();
            coInfo.Fill(getDt);
            string ouech = getDt.Rows[0][0].ToString();

            sum = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value);

            


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


            getSlip.Close();
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
