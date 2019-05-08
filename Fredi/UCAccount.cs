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
            UCHome getTokenId = new UCHome();
            getContent coGetInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = coGetInfo.getServer();
            conn.UserID = coGetInfo.getId();
            conn.Password = coGetInfo.getPassword();
            conn.Database = coGetInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            string updatePwd = "update login set confirmPassword = MD5('"+ textBoxMdpC.Text+"')";
            MySqlCommand pwdConfirm = new MySqlCommand(updatePwd, connection);
            pwdConfirm.ExecuteNonQuery();
            string selectPwdConfirm = "select confirmPassword from login where id = '" + getTokenId.returnToken() + "' ";
            MySqlDataAdapter verifConfirm = new MySqlDataAdapter(selectPwdConfirm, connection);
            DataTable dtConfirm = new DataTable();
            verifConfirm.Fill(dtConfirm);
            string selectPwd = "select password from login where id = '"+ getTokenId.returnToken() +"' ";
            MySqlDataAdapter verifPwd = new MySqlDataAdapter(selectPwd, connection);
            DataTable dtVerif = new DataTable();
            verifPwd.Fill(dtVerif); 
            if (dtConfirm.Rows[0][0].ToString() == dtVerif.Rows[0][0].ToString())
            {
                string updateName = "update adherents set name = '" + textBoxName.Text + "' where idLogin = '" + getTokenId.returnToken() + "' ";
                MySqlCommand updateNameCo = new MySqlCommand(updateName, connection);
                updateNameCo.ExecuteNonQuery();

                string updateFName = "update adherents set firstName = '" + textBoxFName.Text + "' where idLogin = '" + getTokenId.returnToken() + "' ";
                MySqlCommand updateFNameCo = new MySqlCommand(updateFName, connection);
                updateFNameCo.ExecuteNonQuery();

                string updateMail = "update login set email = '" + textBoxMail.Text + "' where id = '" + getTokenId.returnToken() + "' ";
                MySqlCommand updateMailCo = new MySqlCommand(updateMail, connection);
                updateMailCo.ExecuteNonQuery();
                MessageBox.Show("Les modifications ont été apportées à votre compte.");
            }
            else
            {
            }
            connection.Close();
        }

        public void getNameUser(string nameUser)
        {
            UCAccount ac = new UCAccount();
            ac.textBoxName.Text = nameUser;

        }

        public void getData(int idToken)
        {
            try
            {
                getContent coGetInfo = new getContent();
                MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
                conn.Server = coGetInfo.getServer();
                conn.UserID = coGetInfo.getId();
                conn.Password = coGetInfo.getPassword();
                conn.Database = coGetInfo.getDb();
                var connString = conn.ToString();
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                string getUser = "select * from adherents where idLogin = '" + idToken + "'";
                MySqlDataAdapter UserArray = new MySqlDataAdapter(getUser, connection);
                DataTable dtUser = new DataTable();
                UserArray.Fill(dtUser);
                textBoxName.Text = dtUser.Rows[0]["name"].ToString();
                textBoxFName.Text = dtUser.Rows[0]["firstName"].ToString();
                
                string getLogin = "select * from login where id = '" + idToken + "'";
                MySqlDataAdapter loginArray = new MySqlDataAdapter(getLogin, connection);
                DataTable dtLogin = new DataTable();
                loginArray.Fill(dtLogin);
                textBoxMail.Text = dtLogin.Rows[0]["email"].ToString();

                NumLigue.Text = dtUser.Rows[0]["numLigue"].ToString();

                NumLicence.Text = dtUser.Rows[0]["numLicence"].ToString();

                switch (dtLogin.Rows[0]["statut"].ToString())
                {
                    case "user":
                        listBoxAccount.SelectedItem = "Utilisateur";
                        break;
                    case "treasure":
                        listBoxAccount.SelectedItem = "Trésorier";
                        break;
                       
                    default:
                        listBoxAccount.SelectedItem = "Administrateur";
                        break;
                }
                connection.Close();
            }
            catch
            {

            }
        }
    }
}
