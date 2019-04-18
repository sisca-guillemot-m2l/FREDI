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
    public partial class UCInscription : UserControl
    {
        private static string idsafe = null;

        public UCInscription()
        {
            InitializeComponent();
        }

        private void btnco_Click(object sender, EventArgs e)
        {
            if (Itextpwd.Text != Itextconfirm.Text)
            {
                MessageBox.Show("Mots de passes différents");
            }
            else
            {
                MySqlConnection creation = new MySqlConnection("database=M2L_DB; server=localhost; user id=root; pwd=");
                creation.Open();
                MySqlDataAdapter creationtest = new MySqlDataAdapter("select count(*) from adherents where numLicence ='" + Itextlicence.Text + "' and numLigue = '" + Itextligue.Text + "'", creation);
                
                DataTable dt = new DataTable();
                creationtest.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //try
                    //{

                        string inscription = "insert into login (email, password) values ('" + Itextmail.Text + "', MD5('" + Itextpwd.Text + "'))";
                        MySqlCommand crea = new MySqlCommand(inscription, creation);
                        crea.ExecuteNonQuery();
                    
                        string ids = "select id from login where email = '"+Itextmail.Text+"'";
                        MessageBox.Show("1");
                        MySqlDataAdapter searchsearch = new MySqlDataAdapter(ids, creation);
                        MessageBox.Show("2");
                        DataTable dtsearch = new DataTable();
                        MessageBox.Show("3");
                        searchsearch.Fill(dtsearch);
                        MessageBox.Show("4");
                        idsafe = dtsearch.Rows[0][0].ToString();
                        MessageBox.Show("5");
                        int testparse = Int32.Parse(idsafe);
                        MessageBox.Show("6");
                        string majId = "update adherents set idLogin ='"+idsafe+ "' where numLicence ='" + Itextlicence.Text + "' and numLigue = '" + Itextligue.Text + "'";
                        MessageBox.Show("7");
                        MySqlCommand putLogin = new MySqlCommand(majId, creation);
                        MessageBox.Show("8");
                        putLogin.ExecuteNonQuery();
                                            
                        MessageBox.Show("Working");
                    /**}
                    catch
                    {
                         MessageBox.Show("Un compte existe déjà avec cet email.");
                    }*/
                }
                
                else
                {
                    MessageBox.Show("rip");
                }
            }
        }

        private void UCInscription_Load(object sender, EventArgs e)
        {

        }
    }
}
