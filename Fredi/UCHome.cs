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
using System.Net;
using System.Net.Mail;

namespace Fredi
{
    public partial class UCHome : UserControl
    {
        string tokenNb = null;
        public static int tokeen = 0;
        public UCHome()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public void btnco_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("database=M2L_DB; server=localhost; user id=root; pwd=");
            connection.Open();
            MySqlDataAdapter logon = new MySqlDataAdapter("select count(*) from login where email ='"+textmail.Text+"' and password = MD5('"+textpwd.Text+"')" , connection);
            DataTable dt = new DataTable();
            logon.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                MySqlDataAdapter verif = new MySqlDataAdapter("select 1stConnexion from login where email ='" + textmail.Text + "' and password = MD5('" + textpwd.Text + "')", connection);
                DataTable search1st = new DataTable();
                verif.Fill(search1st);
                if (search1st.Rows[0][0].ToString() == "never")
                {
                    string firstCo = "update login set 1stConnexion = 'already' where email ='" + textmail.Text + "' and password = MD5('" + textpwd.Text + "')";
                    MySqlCommand Change1stCo = new MySqlCommand(firstCo, connection);
                    Change1stCo.ExecuteNonQuery();

                    //Envoie de mon mail en cas de premiere connexion --> A améliorer pour transmettre les infos obtenues avec le token
                    MailMessage Msg = new MailMessage();
                    Msg.From = new MailAddress("projetgizmofrazou@gmail.com");
                    Msg.To.Add(new MailAddress("fabien.6k@gmail.com"));
                    Msg.Body = "Bienvenue sur l'application de la maison des ligues. Nous allons vous transmettre vos coordonnées !";
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("projetgizmofrazou@gmail.com", "FrazouGizmo");
                    client.Send(Msg);
                    MessageBox.Show("Test");
                }
                //Recuperation du token pour créer ma session
                
                string createToken = "select id from login where email ='" + textmail.Text + "' and password = MD5('" + textpwd.Text + "')";
                MySqlDataAdapter token = new MySqlDataAdapter(createToken, connection);

                DataTable tokendt = new DataTable();
                token.Fill(tokendt);
                tokenNb = tokendt.Rows[0][0].ToString();
                tokeen = Int32.Parse(tokenNb);
                MessageBox.Show("Vous etes maintenant connecté");

                Form1 toto = new Form1();
                toto.changeaccount();
            }
            else
            {
                MessageBox.Show("Mauvais mot de passe ou adresse mail");
            }
           
        
        }
        
        public int returnToken()
        {
            return tokeen;
        }

        public string returnTokenNb()
        {
            return tokenNb;
        }

        private void textmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textpwd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UCHome_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
