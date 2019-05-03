using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;


namespace Fredi
{
    public partial class Form1 : Form
    {
        public string toto;


        public Form1()
        {
            InitializeComponent();
            panel1.Height = label2.Height;
            ucHome1.BringToFront();
            panel1.Height = label2.Height;
            panel1.Top = label2.Top;

            

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
                connection.Close();
            }

            catch
            {
                MessageBox.Show("Vous n'avez pas accès à internet, veuillez relancer l'application une fois connecté");
                this.Close();
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = button1.Height;
            panel1.Top = button1.Top;
            UCHome getToken = new UCHome();
            
            ucAccount1.getData(getToken.returnToken());
            ucAccount1.BringToFront();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Height = button2.Height;
            panel1.Top = button2.Top;
            UCHome getToken = new UCHome();
            if(button2.Text == "Gestion des bordereaux")
            {
                ucUser1.getDataSlip(getToken.returnToken());
                ucUser1.BringToFront();
            }
            else if(button2.Text == "Adhérents")
            {
                ucTreasure2.allTreasurePart();
                ucTreasure2.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Height = button3.Height;
            panel1.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Height = button4.Height;
            panel1.Top = button4.Top;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Height = button5.Height;
            panel1.Top = button5.Top;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Height = button6.Height;
            panel1.Top = button6.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Height = button7.Height;
            panel1.Top = button7.Top;
            ucHome1.BringToFront();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Se déconnecter et quitter")
            {
                this.Close();
            }
            else
            {
                panel1.Height = button8.Height;
                panel1.Top = button8.Top;
                ucInscription1.BringToFront();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Height = label2.Height;
            panel1.Top = label2.Top;
            ucHome1.BringToFront();
        }

        public void label1_TextChanged(string nameLabel)
        {

            Form1 fc = (Form1)Application.OpenForms["form1"];
            if (fc != null)
            {
                fc.AccountName.Text = nameLabel;
            }
        }

        public void showbutton(string tok, string statut)
        {
            Form1 fc = (Form1)Application.OpenForms["form1"];
            if (fc != null)
            {
                if (tok != "0")
                {

                    fc.button1.Visible = true;
                    fc.button2.Visible = true;
                    fc.button3.Visible = true;
                    fc.button4.Visible = true;
                    fc.button5.Visible = true;
                    fc.button6.Visible = true;
                    fc.button7.Visible = false;
                    fc.button8.Text = "Se déconnecter et quitter";
                    if (statut == "user")
                    {
                        fc.button1.Text = "Mon compte";
                        fc.button2.Text = "Gestion des bordereaux";
                    }
                    else if (statut == "treasure")
                    {
                        fc.button1.Text = "Compte trésorier";
                        fc.button2.Text = "Adhérents";
                    }
                }
            }

            
        }
    }
}