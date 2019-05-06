using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Fredi
{
    public partial class FormPDFUser : Form
    {
        public FormPDFUser()
        {
            InitializeComponent();
        }
        public static void databaseFilePut(string varFilePath)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connec = new MySqlConnection(connString);
            connec.Open();
            UCHome getTokTri = new UCHome();
            UCTreasure getTokMember = new UCTreasure();
            string requeteStatut = "select statut from login where id = '" + getTokTri.returnToken() + "'";
            MySqlDataAdapter getStatut = new MySqlDataAdapter(requeteStatut, connec);
            DataTable dbStatut = new DataTable();
            getStatut.Fill(dbStatut);
            string statutGot = dbStatut.Rows[0][0].ToString();
            MessageBox.Show(statutGot);

            if (statutGot == "user")
            {
                byte[] file;
                using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }
                using (var varConnection = connec)
                using (var sqlWrite = new MySqlCommand(@"update login set pdfNotSigned = @File where id = '" + getTokTri.returnToken() + "'", varConnection))
                {
                    sqlWrite.Parameters.Add("@File", MySqlDbType.VarBinary, file.Length).Value = file;
                    sqlWrite.ExecuteNonQuery();
                }
                connec.Close();
            }
            else if(statutGot == "treasure")
            {
                byte[] file;
                using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        file = reader.ReadBytes((int)stream.Length);
                    }
                }
                using (var varConnection = connec)
                using (var sqlWrite = new MySqlCommand(@"update login set pdfNotSigned = @File where id = '" + getTokMember.getIdMember() + "'", varConnection))
                {
                    sqlWrite.Parameters.Add("@File", MySqlDbType.VarBinary, file.Length).Value = file;
                    sqlWrite.ExecuteNonQuery();
                }
                connec.Close();
            }
            
        }

        private void FormPDFUser_Load(object sender, EventArgs e)
        {
            axAcroPDF1.src = @"c:\users\Fabien\Desktop\Allo.pdf";
            databaseFilePut(@"c:\users\Fabien\Desktop\Allo.pdf");
        }
        
    }
}
