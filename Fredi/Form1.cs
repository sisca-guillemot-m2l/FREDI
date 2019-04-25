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
                Close();
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
            ucUser1.BringToFront();

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
            panel1.Height = button8.Height;
            panel1.Top = button8.Top;
            ucInscription1.BringToFront();


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

    }
}