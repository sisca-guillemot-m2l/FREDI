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
    public partial class UCAccount : UserControl
    {
        public UCAccount()
        {
            InitializeComponent();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void UCAccount_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void getInfoAccount()
        {
            /**Getting informations
            UCHome getToken = new UCHome();
            getContent coGetInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = coGetInfo.getServer();
            conn.UserID = coGetInfo.getId();
            conn.Password = coGetInfo.getPassword();
            conn.Database = coGetInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            string getName = "select name from adherents where idLogin = ('" + getToken.returnToken() + "')";
            MySqlDataAdapter putName = new MySqlDataAdapter(getName, connection);
            DataTable dtName = new DataTable();
            putName.Fill(dtName);
            textBoxName.Text = dtName.Rows[0][0].ToString();
            */
        }

        public void getNameUser(string nameUser)
        {
            UCAccount ac = new UCAccount();
            ac.textBoxName.Text = nameUser;
            MessageBox.Show(ac.textBoxName.Text);

        }

        public void textBox1_TextChanged(string nameUser)
        {
            UCAccount ac = new UCAccount();
            ac.textBoxName.Text = nameUser;
            MessageBox.Show(ac.textBoxName.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UCHome getToken = new UCHome();
            getContent coGetInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = coGetInfo.getServer();
            conn.UserID = coGetInfo.getId();
            conn.Password = coGetInfo.getPassword();
            conn.Database = coGetInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();

            string getName = "select name from adherents where idLogin = ('" + getToken.returnToken() + "')";
            MySqlDataAdapter putName = new MySqlDataAdapter(getName, connection);
            DataTable dtName = new DataTable();
            putName.Fill(dtName);
            textBoxName.Text = dtName.Rows[0][0].ToString();

            string getFName = "select firstName from adherents where idLogin = ('" + getToken.returnToken() + "')";
            MySqlDataAdapter putFName = new MySqlDataAdapter(getFName, connection);
            DataTable dtFName = new DataTable();
            putFName.Fill(dtFName);
            textBoxFName.Text = dtFName.Rows[0][0].ToString();

            string getMail = "select email from login where id = ('" + getToken.returnToken() + "')";
            MySqlDataAdapter putMail = new MySqlDataAdapter(getMail, connection);
            DataTable dtMail = new DataTable();
            putMail.Fill(dtMail);
            textBoxMail.Text = dtMail.Rows[0][0].ToString();

            string getNligue = "select numLigue from adherents where idLogin = ('" + getToken.returnToken() + "')";
            MySqlDataAdapter putNligue = new MySqlDataAdapter(getNligue, connection);
            DataTable dtNligue = new DataTable();
            putNligue.Fill(dtNligue);
            NumLigue.Text = dtNligue.Rows[0][0].ToString();

            string getNlic = "select numLicence from adherents where idLogin = ('" + getToken.returnToken() + "')";
            MySqlDataAdapter putNlic = new MySqlDataAdapter(getNlic, connection);
            DataTable dtNlic = new DataTable();
            putNlic.Fill(dtNlic);
            NumLicence.Text = dtNlic.Rows[0][0].ToString();

            string getType = "select statut from login where id = ('" + getToken.returnToken() + "')";
            MySqlDataAdapter putType = new MySqlDataAdapter(getType, connection);
            DataTable dtType = new DataTable();
            putType.Fill(dtType);

            if (dtType.Rows[0][0].ToString() == "user")
            {
                listBoxAccount.SelectedItem = "Utilisateur";
            }
            else if (dtType.Rows[0][0].ToString() == "treasure")
            {
                listBoxAccount.SelectedItem = "Trésorier";
            }
            else
            {
                listBoxAccount.SelectedItem = "Administrateur";
            }
            
        }
    }
}
