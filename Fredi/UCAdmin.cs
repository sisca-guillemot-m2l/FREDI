using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Fredi
{
    public partial class UCAdmin : UserControl
    {
        private string pathFileAdmin;
        public UCAdmin()
        {
            InitializeComponent();
        }


        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("numLicence");
            dt.Columns.Add("name");
            dt.Columns.Add("firstName");
            dt.Columns.Add("numLigue");
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                /**string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    //dt.Columns.Add(header);
                }*/
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < 4; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }

            return dt;
        }
        private void saveImportDataToDatabase(DataTable importData)
        {
            string connect = "server = localhost; database = M2L_DB; uid = root; password=";
            MySqlConnection lop = new MySqlConnection(connect);
            lop.Open();

            foreach (DataRow dr in importData.Rows)
            {
                MySqlCommand cmd = new MySqlCommand("insert into adherents (numLicence, name, firstName, numLigue) values (@numLicence, @name, @firstName, @numLigue)", lop);
                cmd.Parameters.AddWithValue("@numLicence", dr["numLicence"]);
                cmd.Parameters.AddWithValue("@name", dr["name"]);
                cmd.Parameters.AddWithValue("@firstName", dr["firstName"]);
                cmd.Parameters.AddWithValue("@numLigue", dr["numLigue"]);
                cmd.ExecuteNonQuery();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "CSV|*.csv" })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pathFileAdmin = ofd.FileName;
                }

            DataTable importData = ConvertCSVtoDataTable(pathFileAdmin);
            saveImportDataToDatabase(importData);
        }

        private void UCAdmin_Load(object sender, EventArgs e)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection selectRate = new MySqlConnection(connString);
            selectRate.Open();
            string getRate = "select rate from pricing";
            MySqlDataAdapter ratePricing = new MySqlDataAdapter(getRate,selectRate);
            DataTable dtRate = new DataTable();
            ratePricing.Fill(dtRate);
            string putRate = dtRate.Rows[0][0].ToString();
            textBox1.Text = putRate + "€";
            selectRate.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection selectRate = new MySqlConnection(connString);
            selectRate.Open();

            string update = "update pricing set rate ='"+textBox1.Text+"'";
            MySqlCommand updateRate = new MySqlCommand(update, selectRate);
            updateRate.ExecuteNonQuery();
            MessageBox.Show("work");
            selectRate.Close();
        }
    }
}
