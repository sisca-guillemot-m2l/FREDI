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
using System.IO;

namespace Fredi
{
    public partial class UCTreasure : UserControl
    {
        public static string pathFile;
        public static string idUser;
        public UCTreasure()
        {
            InitializeComponent();
        }

        private void UCTreasure_Load(object sender, EventArgs e)
        {

        }

        public void allTreasurePart()
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            UCHome getNum = new UCHome();
            string getNumTreasure = "select numLigue from adherents where idLogin = '" + getNum.returnToken() + "'";
            MySqlCommand recupNum = new MySqlCommand(getNumTreasure, connection);
            recupNum.ExecuteNonQuery();
            MySqlDataAdapter alop = new MySqlDataAdapter(getNumTreasure, connection);
            DataTable stocknum = new DataTable();
            alop.Fill(stocknum);
            string numGot = stocknum.Rows[0][0].ToString();
            string sqlQuery = "select firstName from adherents where numLigue = '" + numGot + "' ";
            MySqlCommand sqlcom = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader sdr = sqlcom.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (sdr.Read())
            {
                autotext.Add(sdr.GetString(0));
            }
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = autotext;
            sdr.Close();
            connection.Close();
            connection.Open();
            string sqlQuery2 = "select name from adherents where numLigue = '" + numGot + "' ";
            MySqlCommand sqlcom2 = new MySqlCommand(sqlQuery2, connection);
            MySqlDataReader sdr2 = sqlcom2.ExecuteReader();
            AutoCompleteStringCollection autotext2 = new AutoCompleteStringCollection();
            while (sdr2.Read())
            {
                autotext2.Add(sdr2.GetString(0));
            }
            textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteCustomSource = autotext2;
            sdr2.Close();
            connection.Close();


            connection.Open();
            string sqlQuery3 = "select numLicence from adherents where numLigue = '" + numGot + "' ";
            MySqlCommand sqlcom3 = new MySqlCommand(sqlQuery3, connection);
            MySqlDataReader sdr3 = sqlcom3.ExecuteReader();
            AutoCompleteStringCollection autotext3 = new AutoCompleteStringCollection();
            while (sdr3.Read())
            {
                autotext3.Add(sdr3.GetString(0));
            }
            textBox3.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox3.AutoCompleteCustomSource = autotext3;
            sdr3.Close();
            connection.Close();
            connection.Open();

            string pelo = "SELECT * FROM login JOIN adherents ON  login.statut = 'user' WHERE  adherents.numLigue = '" + numGot + "' AND login.id = adherents.idLogin";

            MySqlCommand sqlCommand = new MySqlCommand(pelo, connection);
            MySqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                //listView1.Items.Add(dr["email"].ToString());
                //listView1.Items.Add(dr["id"].ToString());
                ListViewItem item = new ListViewItem(dr["firstName"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["numLicence"].ToString());
                listView1.Items.Add(item);

            }
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            try
            {


                string select = "select idLogin from adherents where firstName = '" + textBox1.Text + "' and name = '" + textBox2.Text + "' and numLicence = '" + textBox3.Text + "'";
                MySqlDataAdapter getID = new MySqlDataAdapter(select, connection);
                DataTable idDt = new DataTable();
                getID.Fill(idDt);
                idUser = idDt.Rows[0][0].ToString();
                if (idDt.Rows[0][0].ToString() != null)
                {
                    try
                    {
                        string getInfo = "SELECT * FROM slips WHERE idMember = '" + idDt.Rows[0][0] + "'";
                        MySqlDataAdapter coInfo = new MySqlDataAdapter(getInfo, connection);
                        DataTable getDt = new DataTable();
                        coInfo.Fill(getDt);
                        string ouech = getDt.Rows[0][0].ToString();
                      
                        foreach (DataRow dt in getDt.Rows)
                        {
                            
                                slipBindingSource1.Add(new Slip
                                {
                                        Id = Convert.ToInt32(dt["Id"]),
                                        SlipDate = dt["date"].ToString(),
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

                            
                    }
                    catch
                    {
                        MessageBox.Show("Aucun bordereau n'a encore été completé par l'utilisateur");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner un utilisateur valide.");
                }
            }
            catch
            {
                MessageBox.Show("Veuillez renseigner un utilisateur valide.");
            }
          
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            int insertRow = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Valider")
            {
                try
                {
                    dataGridView1.Rows[insertRow].Cells["Validate"].Value = "0";
                    string updateValidated = "update slips set Validated = 'True' where id = '" + dataGridView1.Rows[insertRow].Cells["Id"].Value.ToString() + "'";
                    MySqlCommand putUpdateValid = new MySqlCommand(updateValidated, connection);
                    putUpdateValid.ExecuteNonQuery();

                }
                catch
                {
                    MessageBox.Show("Un soucis est survenu lors de la validation");
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Modifier")
            {
                try
                {
                MessageBox.Show(dataGridView1.Rows[insertRow].Cells["Id"].Value.ToString());
                MessageBox.Show(insertRow.ToString());
                MessageBox.Show(dataGridView1.Rows[insertRow].Cells["date"].Value.ToString());
                string updateSlip = "update slips set date = '" + dataGridView1.Rows[insertRow].Cells["date"].Value.ToString() + "' , pattern = '" + dataGridView1.Rows[insertRow].Cells["pattern"].Value.ToString() + "' , path = '" + dataGridView1.Rows[insertRow].Cells["path"].Value.ToString() + "' , kmsTraveled = '" + dataGridView1.Rows[insertRow].Cells["kmsTraveled"].Value.ToString() + "' , pathCost = '" + dataGridView1.Rows[insertRow].Cells["pathCost"].Value.ToString() + "' , tollCost = '" + dataGridView1.Rows[insertRow].Cells["tollCost"].Value.ToString() + "' , mealCost = '" + dataGridView1.Rows[insertRow].Cells["mealCost"].Value.ToString() + "' , accomodationCost = '" + dataGridView1.Rows[insertRow].Cells["accommodationCost"].Value.ToString() + "' , totalCost = '" + dataGridView1.Rows[insertRow].Cells["totalCost"].Value.ToString() + "' where id = '" + dataGridView1.Rows[insertRow].Cells["Id"].Value.ToString() + "'";
                    MySqlCommand updateSlipDB = new MySqlCommand(updateSlip, connection);
                    updateSlipDB.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Modifications impossibles");
                }
            }
            connection.Close();
        }

        public static void databaseFileRead(string varID, string varPathToNewLocation)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            using (var varConnection = connection)
            using (var sqlQuery = new MySqlCommand("SELECT pdfSigned FROM login WHERE id = '" + varID + "'", varConnection))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Où souhaitez vous le télécharger ?");

            using (FolderBrowserDialog ofd = new FolderBrowserDialog() { })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pathFile = ofd.SelectedPath;
                    
                }
            MessageBox.Show(pathFile);
            string pathpath = pathFile + @"\testtest.pdf";
            MessageBox.Show(pathpath);
            databaseFileRead( idUser , pathpath);
        }
    }
}
