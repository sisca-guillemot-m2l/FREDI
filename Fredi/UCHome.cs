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
using System.IO;

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


        public  void btnco_Click(object sender, EventArgs e)
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

                    //Envoie de mon mail en cas de premiere connexion --> A améliorer pour transmettre les infos obtenues avec le token
                    getContent getIDS = new getContent();
                    string pwdMail = getIDS.getpwdM();
                    getContent getMail = new getContent();
                    string idMail = getMail.getIdM();
                    MailMessage Msg = new MailMessage();
                    Msg.From = new MailAddress(idMail);
                    Msg.To.Add(new MailAddress("fabien.sisca@epsi.fr"));
                    Msg.Body = "Bienvenue sur l'application de la maison des ligues. Nous allons vous transmettre vos coordonnées !";
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("projetgizmofrazou@gmail.com", pwdMail);
                    client.Send(Msg);
                    MessageBox.Show("Mail envoyé !");
                    string firstCo = "update login set 1stConnexion = 'already' where email ='" + textmail.Text + "' and password = MD5('" + textpwd.Text + "')";
                    MySqlCommand Change1stCo = new MySqlCommand(firstCo, connection);
                    Change1stCo.ExecuteNonQuery();
                }
                //Recuperation du token pour créer ma session
                
                string createToken = "select id from login where email ='" + textmail.Text + "' and password = MD5('" + textpwd.Text + "')";
                MySqlDataAdapter token = new MySqlDataAdapter(createToken, connection);

                DataTable tokendt = new DataTable();
                token.Fill(tokendt);
                tokenNb = tokendt.Rows[0][0].ToString();
                tokeen = Int32.Parse(tokenNb);
                MessageBox.Show("Vous etes maintenant connecté");

                Form1 Testes = new Form1();
                string getNameForm = "select name from adherents where idLogin = '"+tokeen+"'";
                MySqlDataAdapter putNameForm = new MySqlDataAdapter(getNameForm, connection);
                DataTable NameTok = new DataTable();
                putNameForm.Fill(NameTok);
                string nameFromTok = NameTok.Rows[0][0].ToString();
                Testes.label1_TextChanged("Bonjour "+nameFromTok);

                //UCUser tst = new UCUser();
                //tst.getDataSlip(1);
            }
            else
            {
                MessageBox.Show("Mauvais mot de passe ou adresse mail");
            }

            connection.Close();
        }
        
        public int returnToken()
        {
            return tokeen;
        }

        public string returnTokenNb()
        {
            return tokenNb;
        }


    }
}
