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
                getContent returnInfo = new getContent();
                MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
                conn.Server = returnInfo.getServer();
                conn.UserID = returnInfo.getId();
                conn.Password = returnInfo.getPassword();
                conn.Database = returnInfo.getDb();
                var connString = conn.ToString();
                MySqlConnection creation = new MySqlConnection(connString);
                creation.Open();
                MySqlDataAdapter creationtest = new MySqlDataAdapter("select count(*) from adherents where numLicence ='" + Itextlicence.Text + "' and numLigue = '" + Itextligue.Text + "'", creation);
                
                DataTable dt = new DataTable();
                creationtest.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    try
                    {

                        string inscription = "insert into login (email, password, adress) values ('" + Itextmail.Text + "', MD5('" + Itextpwd.Text + "'), '"+ItextAdress.Text+"')";
                        MySqlCommand crea = new MySqlCommand(inscription, creation);
                        crea.ExecuteNonQuery();
                    
                        string ids = "select id from login where email = '"+Itextmail.Text+"'";
                        MySqlDataAdapter searchsearch = new MySqlDataAdapter(ids, creation);
                        DataTable dtsearch = new DataTable();
                        searchsearch.Fill(dtsearch);
                        idsafe = dtsearch.Rows[0][0].ToString();
                        int testparse = Int32.Parse(idsafe);
                        string majId = "update adherents set idLogin ='"+idsafe+ "' where numLicence ='" + Itextlicence.Text + "' and numLigue = '" + Itextligue.Text + "'";
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
                creation.Close();
            }
        }
        
    }
}
