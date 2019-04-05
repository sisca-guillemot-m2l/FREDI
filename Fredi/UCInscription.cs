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
                    try
                    {

                        string inscription = "insert into login (email, password) values ('" + Itextmail.Text + "', MD5('" + Itextpwd.Text + "'))";
                        MySqlCommand test = new MySqlCommand(inscription, creation);
                        test.ExecuteNonQuery();
                    
                        string ids = "select id from login where email = '"+Itextmail.Text+"'";
                        MessageBox.Show(ids);
                        MySqlDataAdapter searchsearch = new MySqlDataAdapter(ids, creation);
                        DataTable dtsearch = new DataTable();
                        searchsearch.Fill(dtsearch);
                        idsafe = dtsearch.Rows[0][0].ToString();
                        int testparse = Int32.Parse(idsafe);
                        string majId = "insert into adherents (idLogin) values ('"+idsafe+"')";
                        MySqlCommand putLogin = new MySqlCommand(majId, creation);
                        putLogin.ExecuteNonQuery();
                                            
                        MessageBox.Show("Working");
                    }
                    catch
                    {
                         MessageBox.Show("Un compte existe déjà avec cet email.");
                    }
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
