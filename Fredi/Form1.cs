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

            getContent returnInfo = new getContent();

            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);

            try
            {
                connection.Open();
                connection.Close();
            }

            catch
            {
                MessageBox.Show("Vous n'avez pas accès à internet, veuillez relancer l'application une fois connecté");
                Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = button1.Height;
            panel1.Top = button1.Top;
            ucAccount1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Height = button2.Height;
            panel1.Top = button2.Top;
            ucUser1.BringToFront();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucUser1_Load(object sender, EventArgs e)
        {

        }

        private void ucHome1_Load(object sender, EventArgs e)
        {




        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public void changeaccount()
        {
            UCHome tok = new UCHome();
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection search = new MySqlConnection(connString);
            search.Open();
            MessageBox.Show(tok.returnToken().ToString());
            MySqlDataAdapter searchToken = new MySqlDataAdapter("select email from login where id = '" + tok.returnToken() + "'", search);
            DataTable geToken = new DataTable();
            searchToken.Fill(geToken);
            try
            {
                toto = geToken.Rows[0][0].ToString();
                AccountName.Text = tok.returnToken().ToString();

            }
            catch
            {
                MessageBox.Show("Fail");
            }
            search.Close();
        }

        public void label1_TextChanged(string test12)
        {

            Form1 fc = (Form1)Application.OpenForms["form1"];
            MessageBox.Show("fab" + fc.AccountName.Text);
            if (fc != null)
            {
                fc.AccountName.Text = test12;
            }
        }

    }
}