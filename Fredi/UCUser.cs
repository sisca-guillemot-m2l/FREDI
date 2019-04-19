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
            slipBindingSource1.Add(new Slip { });
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Ajouter")
            {
                getContent returnInfo = new getContent();
                MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
                conn.Server = returnInfo.getServer();
                conn.UserID = returnInfo.getId();
                conn.Password = returnInfo.getPassword();
                conn.Database = returnInfo.getDb();
                var connString = conn.ToString();
                MySqlConnection coInsert = new MySqlConnection(connString);
                coInsert.Open();
                int insertRow = Convert.ToInt32(dataGridView1.CurrentRow.Index);
                /**
                string inserDate = "insert into slips (date) values ('" +DateTime.Parse(dataGridView1.Rows[insertRow].Cells["date"].Value.ToString()).ToShortDateString() + "')";
                string inserPattern = "insert into slips (pattern) values ('"+dataGridView1.Rows[insertRow].Cells[1].Value.ToString()+"')";
                string inserPath = "insert into slips (path) values ('" + dataGridView1.Rows[insertRow].Cells[2].Value.ToString() + "')";
                string inserKmsTraveled = "insert into slips (kmsTraveled) values ('" + dataGridView1.Rows[insertRow].Cells[3].Value.ToString() + "')";
                string inserPathCost = "insert into slips (pathCost) values ('" + dataGridView1.Rows[insertRow].Cells[4].Value.ToString() + "')";
                string inserTollCost = "insert into slips (tollCost) values ('" + dataGridView1.Rows[insertRow].Cells[5].Value.ToString() + "')";
                string inserMealCost = "insert into slips (mealCost) values ('" + dataGridView1.Rows[insertRow].Cells[6].Value.ToString() + "')";
                string inserAccomodationCost = "insert into slips (accomodationCost) values ('" + dataGridView1.Rows[insertRow].Cells[7].Value.ToString() + "')";
                string inserTotalCost = "insert into slips (totalCost) values ('" + dataGridView1.Rows[insertRow].Cells[8].Value.ToString() + "')";
                */
                
                try
                {
                    /*MySqlCommand exeDate = new MySqlCommand( inserDate, coInsert);
                    exeDate.ExecuteNonQuery();
                    MySqlCommand exePattern = new MySqlCommand(inserPattern, coInsert);
                    exePattern.ExecuteNonQuery();
                    MySqlCommand exePath = new MySqlCommand(inserPath, coInsert);
                    MySqlCommand exePathCost = new MySqlCommand(inserPathCost, coInsert);
                    MySqlCommand exeTollCost = new MySqlCommand(inserTollCost, coInsert);
                    MySqlCommand exeKmsTraveled = new MySqlCommand(inserKmsTraveled, coInsert);
                    MySqlCommand exeMealCost = new MySqlCommand(inserMealCost, coInsert);
                    MySqlCommand exeAccomodationCost = new MySqlCommand(inserAccomodationCost, coInsert);
                    MySqlCommand exeTotalCost = new MySqlCommand(inserTollCost, coInsert);



                    exePath.ExecuteNonQuery();
                    exePathCost.ExecuteNonQuery();
                    exeTollCost.ExecuteNonQuery();
                    exeKmsTraveled.ExecuteNonQuery();
                    exeMealCost.ExecuteNonQuery();
                    exeAccomodationCost.ExecuteNonQuery();
                    exeTotalCost.ExecuteNonQuery();
    */
                    UCHome insertId = new UCHome();
                    int insertIdSlip = insertId.returnToken();
                    string insertAll = "insert into slips (date, pattern, path, kmsTraveled, pathCost, tollCost, mealCost, accomodationCost, totalCost, idMember) values ('" + DateTime.Parse(dataGridView1.Rows[insertRow].Cells[0].Value.ToString()).ToShortDateString() + "', '" + dataGridView1.Rows[insertRow].Cells[1].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[2].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[3].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[4].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[5].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[6].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[7].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[8].Value.ToString() + "', '"+insertIdSlip+"')";
                    MySqlCommand exeAll = new MySqlCommand(insertAll, coInsert);
                    exeAll.ExecuteNonQuery();
                    coInsert.Close();
                    slipBindingSource1.Add(new Slip { });
                }
                catch
                {
                    MessageBox.Show("Mauvaise sélection :/");
                }


                
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                slipBindingSource1.RemoveCurrent();
            }
        }

        private void GetSlips_Click(object sender, EventArgs e)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection getSlip = new MySqlConnection(connString);
            getSlip.Open();

            try
            {
            UCHome getTokenId = new UCHome();
            int putTokenId = getTokenId.returnToken();
            string getInfo = "SELECT * FROM slips WHERE idMember = '" + putTokenId + "'";
            MessageBox.Show(getInfo);
            MySqlDataAdapter coInfo = new MySqlDataAdapter(getInfo, getSlip);
            DataTable getDt = new DataTable();
            coInfo.Fill(getDt);
            string ouech = getDt.Rows[0][0].ToString();

            //sum = Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value);
            
            foreach (DataRow dt in getDt.Rows)
            {
                slipBindingSource1.Add(new Slip
                {
                    SlipDate = DateTime.Parse(dt["date"].ToString()),
                    SlipPattern = dt["pattern"].ToString(),
                    SlipPath = dt["path"].ToString(),
                    SlipKilometers = Convert.ToInt32(dt["kmsTraveled"]),
                    PathCost = Convert.ToInt32(dt["pathCost"]),
                    TollCost = Convert.ToInt32(dt["tollCost"]),
                    MealCost = Convert.ToInt32(dt["mealCost"]),
                    AccommodationCost = Convert.ToInt32(dt["accomodationCost"]),
                    TotalCost = Convert.ToInt32(dt["totalCost"]),
                });
            }

            slipBindingSource1.Add(new Slip { });
            GetSlips.Hide();
            }
            catch
            {
                MessageBox.Show("Aucun bordereau n'a encore été completé :/");
            }

            getSlip.Close();
        }
    }
}
