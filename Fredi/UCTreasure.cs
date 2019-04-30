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
    public partial class UCTreasure : UserControl
    {
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
            string sqlQuery = "select firstName from adherents where numLigue = '"+numGot+"' ";
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

            string pelo = "SELECT * FROM login JOIN adherents ON  login.statut = 'user' WHERE  adherents.numLigue = '"+numGot+"' AND login.id = adherents.idLogin";

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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
