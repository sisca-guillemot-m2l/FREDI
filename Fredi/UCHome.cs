﻿using System;
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
        public string nameFromTok;

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
                    Msg.To.Add(new MailAddress(textmail.Text));
                    Msg.Subject = "Coordonnées compte M2L";
                    Msg.Body = "Bienvenue sur l'application de la maison des ligues. Vos coordonnées sont les suivantes : -Adresse mail : '"+textmail.Text+"'  -Mot de passe: '"+textpwd.Text+"'";
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
                try
                    {
                    Form1 Testes = new Form1();
                    string getNameForm = "select name from adherents where idLogin = '" + tokeen + "'";
                    MySqlDataAdapter putNameForm = new MySqlDataAdapter(getNameForm, connection);
                    DataTable NameTok = new DataTable();
                    putNameForm.Fill(NameTok);
                    nameFromTok = NameTok.Rows[0][0].ToString();
                    Testes.label1_TextChanged("Bonjour " + nameFromTok);
                }
                catch
                {

                }
                try
                {
                    string getStatutForm = "select statut from login where id = '" + tokeen + "'";
                    MySqlDataAdapter putStatut = new MySqlDataAdapter(getStatutForm, connection);
                    DataTable Statut = new DataTable();
                    putStatut.Fill(Statut);
                    string statutFromTok = Statut.Rows[0][0].ToString();
                    
                    Form1 aal = new Form1();
                    aal.showbutton(nameFromTok, statutFromTok);
                }
                catch
                {

                }
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

        private void label5_Click(object sender, EventArgs e)
        {
            try
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
                string pswStock = generatorPwd();

                getContent getIDS = new getContent();
                string pwdMail = getIDS.getpwdM();
                getContent getMail = new getContent();
                string idMail = getMail.getIdM();
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress(idMail);
                Msg.To.Add(new MailAddress(textmail.Text));
                Msg.Subject = "Nouveau mot de passe";
                Msg.Body = "Vous avez demandé un changement de mot de passe.\n Celui ci a été modifié et remplacé par le suivant : " + pswStock + "";
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("projetgizmofrazou@gmail.com", pwdMail);
                client.Send(Msg);
                MessageBox.Show("Mail envoyé !");

                string pdwforgot = "update login set password = MD5('" + pswStock + "') where email = '" + textmail.Text + "'";
                MySqlCommand changepwd = new MySqlCommand(pdwforgot, connection);
                changepwd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Le message ne s'est pas envoyé, veuillez selectionner une adresse valide !");
            }
        }

        private string generatorPwd()
        {
            int minLength = 8;
            int maxLength = 12;

            string charAvailable = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            StringBuilder password = new StringBuilder();
            Random rdm = new Random();

            int passwordLength = rdm.Next(minLength, maxLength + 1);

            while (passwordLength-- > 0)
            {
                password.Append(charAvailable[rdm.Next(charAvailable.Length)]);
            }
            return password.ToString();
        }
    }
}
