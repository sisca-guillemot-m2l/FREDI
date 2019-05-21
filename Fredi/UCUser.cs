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
using word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using SautinSoft.Document;

namespace Fredi
{
    public partial class UCUser : UserControl
    {
        public static int comptSlip = 0;
        public static string totalCostVar;
        public string pathFile;
        public static string mainPathUser = Application.ExecutablePath;
        public static int idMemberCo = 0;

        public UCUser()
        {
            InitializeComponent();
        }

        private void UCUser_Load(object sender, EventArgs e)
        {
            mainPathUser = Directory.GetParent(mainPathUser).ToString();
            mainPathUser = Directory.GetParent(mainPathUser).ToString();
            mainPathUser = Directory.GetParent(mainPathUser).ToString();
            mainPathUser = mainPathUser + @"\Resources";
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Ajouter")
            {
                getContent returnInfo = new getContent();
                MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
                conn.Server = returnInfo.getServer();
                conn.UserID = returnInfo.getId();
                conn.Password = returnInfo.getPassword();
                conn.Database = returnInfo.getDb();
                var connString = conn.ToString();
                MySqlConnection coInsert = new MySqlConnection(connString);
                coInsert.Open();
                int insertRow = Convert.ToInt32(dataGridView1.CurrentRow.Index);
                
                try
                {
                    UCHome insertId = new UCHome();
                    int insertIdSlip = insertId.returnToken();
                    string insertAll = "insert into slips (date, pattern, path, kmsTraveled, pathCost, tollCost, mealCost, accomodationCost, totalCost, idMember) values ('" + dataGridView1.Rows[insertRow].Cells[0].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[1].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[2].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[3].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[4].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[5].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[6].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[7].Value.ToString() + "', '" + dataGridView1.Rows[insertRow].Cells[8].Value.ToString() + "', '"+insertIdSlip+"')";
                    MySqlCommand exeAll = new MySqlCommand(insertAll, coInsert);
                    exeAll.ExecuteNonQuery();
                    coInsert.Close();
                    slipBindingSource1.Add(new Slip { });
                    comptSlip++;
                }
                catch
                {
                    MessageBox.Show("Mauvaise sélection :/");
                }


                
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Modifier")
            {
                UCHome getIdAgain = new UCHome();
                getContent returnInfo = new getContent();
                MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
                conn.Server = returnInfo.getServer();
                conn.UserID = returnInfo.getId();
                conn.Password = returnInfo.getPassword();
                conn.Database = returnInfo.getDb();
                var connString = conn.ToString();
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();

                int insertRow = Convert.ToInt32(dataGridView1.CurrentRow.Index);
                string updateSlip = "update slips set date = '"+dataGridView1.Rows[insertRow].Cells["date"].Value.ToString()+ "' , pattern = '" + dataGridView1.Rows[insertRow].Cells["pattern"].Value.ToString() + "' , path = '" + dataGridView1.Rows[insertRow].Cells["path"].Value.ToString() + "' , kmsTraveled = '" + dataGridView1.Rows[insertRow].Cells["kmsTraveled"].Value.ToString() + "' , pathCost = '" + dataGridView1.Rows[insertRow].Cells["pathCost"].Value.ToString() + "' , tollCost = '" + dataGridView1.Rows[insertRow].Cells["tollCost"].Value.ToString() + "' , mealCost = '" + dataGridView1.Rows[insertRow].Cells["mealCost"].Value.ToString() + "' , accomodationCost = '" + dataGridView1.Rows[insertRow].Cells["accommodationCost"].Value.ToString() + "' , totalCost = '" + dataGridView1.Rows[insertRow].Cells["totalCost"].Value.ToString() + "' where id = '"+dataGridView1.Rows[insertRow].Cells["Id"].Value.ToString()+"'";
                MySqlCommand updateSlipDB = new MySqlCommand(updateSlip, connection);
                updateSlipDB.ExecuteNonQuery();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                slipBindingSource1.RemoveCurrent();
            }
        }
        public void getDataSlip(int tokenALO)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection getSlip = new MySqlConnection(connString);
            getSlip.Open();

            try
            {
                string getInfo = "SELECT * FROM slips WHERE idMember = '" + tokenALO + "'";
                MySqlDataAdapter coInfo = new MySqlDataAdapter(getInfo, getSlip);
                DataTable getDt = new DataTable();
                coInfo.Fill(getDt);
                string ouech = getDt.Rows[0][0].ToString();


                foreach (DataRow dt in getDt.Rows)
                {
                    comptSlip++;
                    slipBindingSource1.Add(new Slip
                    {
                        Id = Convert.ToInt32(dt["id"]),
                        SlipDate = dt["date"].ToString(),
                        SlipPattern = dt["pattern"].ToString(),
                        SlipPath = dt["path"].ToString(),
                        SlipKilometers = Convert.ToInt32(dt["kmsTraveled"]),
                        PathCost = Convert.ToInt32(dt["pathCost"]),
                        TollCost = Convert.ToInt32(dt["tollCost"]),
                        MealCost = Convert.ToInt32(dt["mealCost"]),
                        AccommodationCost = Convert.ToInt32(dt["accomodationCost"]),
                        TotalCost = Convert.ToInt32(dt["totalCost"]),
                    });
                }

                slipBindingSource1.Add(new Slip { });
            }
            catch
            {
                slipBindingSource1.Add(new Slip { });
                MessageBox.Show("Aucun bordereau n'a encore été completé");
            }

            getSlip.Close();
        }

        private void FindAndReplace(word.Application wordapp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object matchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordapp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref matchAllForms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        public void CreateWordDocument(object filename, object SaveAs)
        {
            UCHome tok = new UCHome();
            string tokenForPdf = tok.returnToken().ToString();
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection coInsert = new MySqlConnection(connString);
            coInsert.Open();
            UCHome getTok = new UCHome();
            string getInfo = "select * from adherents where idLogin = '" + getTok.returnToken() + "'";
            MySqlDataAdapter exeGet = new MySqlDataAdapter(getInfo, coInsert);
            DataTable dtInfo = new DataTable();
            exeGet.Fill(dtInfo);
            string price = "select rate from pricing";
            MySqlDataAdapter priceSql = new MySqlDataAdapter(price, coInsert);
            DataTable dtPrice = new DataTable();
            priceSql.Fill(dtPrice);
            string getAdress = "select adress from login where id = '"+getTok.returnToken()+"'";
            MySqlDataAdapter putAdress = new MySqlDataAdapter(getAdress, coInsert);
            DataTable dtAdress = new DataTable();
            putAdress.Fill(dtAdress);
            string infoclub = "select * from club where idClub = '"+dtInfo.Rows[0]["numLigue"].ToString()+"'";
            MySqlDataAdapter clubInfo = new MySqlDataAdapter(infoclub, coInsert);
            DataTable dtclubAdress = new DataTable();
            clubInfo.Fill(dtclubAdress);

            word.Application wordApp = new word.Application();
            object missing = Missing.Value;
            word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = true;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();
                
                this.FindAndReplace(wordApp, "<prenom>", dtInfo.Rows[0]["firstName"].ToString());
                this.FindAndReplace(wordApp, "<nom>", dtInfo.Rows[0]["name"].ToString());
                this.FindAndReplace(wordApp, "<numLicence>", dtInfo.Rows[0]["numLicence"].ToString());
                this.FindAndReplace(wordApp, "<total>", totalCostVar);
                this.FindAndReplace(wordApp, "<adresse>", dtAdress.Rows[0][0].ToString());
                this.FindAndReplace(wordApp, "<prix>", dtPrice.Rows[0][0].ToString());
                try
                {
                    this.FindAndReplace(wordApp, "<clubAdress>", dtclubAdress.Rows[0]["clubAdress"].ToString());
                }
                catch { }
                
            }

            else
            {
                MessageBox.Show("File not found");
            }
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);
            myWordDoc.ExportAsFixedFormat(mainPathUser + @"\bordereauUser"+ tokenForPdf + ".pdf", word.WdExportFormat.wdExportFormatPDF);
            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Created");
            coInsert.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection coInsert = new MySqlConnection(connString);
            coInsert.Open();
            object save13 = mainPathUser + @"\bordereauFillDataGridUser.docx";
            string template = mainPathUser + @"\templateBasic.docx";
            object missing = Missing.Value;
            word.Application wordApp = new word.Application();
            wordApp.Visible = true;
            word.Document document = wordApp.Documents.OpenNoRepairDialog(template);
            document.Activate();
            word.Table table = document.Tables[1];
            for (int a = comptSlip - 1; a >= 0; a--)
            {
                table.Cell(1, 1).Range.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
                table.Cell(1, 2).Range.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();
                table.Cell(1, 3).Range.Text = dataGridView1.Rows[a].Cells[3].Value.ToString();
                table.Cell(1, 4).Range.Text = dataGridView1.Rows[a].Cells[4].Value.ToString() + "€";
                table.Cell(1, 5).Range.Text = dataGridView1.Rows[a].Cells[5].Value.ToString() + "€";
                table.Cell(1, 6).Range.Text = dataGridView1.Rows[a].Cells[6].Value.ToString() + "€";
                table.Cell(1, 7).Range.Text = dataGridView1.Rows[a].Cells[7].Value.ToString() + "€";
                table.Cell(1, 8).Range.Text = dataGridView1.Rows[a].Cells[8].Value.ToString() + "€";
                table.Cell(1, 9).Range.Text = dataGridView1.Rows[a].Cells[9].Value.ToString() + "€";
                document.Tables[1].Rows.Add(document.Tables[1].Rows[1]);
            }
            table.Cell(1, 1).Range.Text = "Date";
            table.Cell(1, 2).Range.Text = "Motif";
            table.Cell(1, 3).Range.Text = "Trajet";
            table.Cell(1, 4).Range.Text = "Kms parcourus";
            table.Cell(1, 5).Range.Text = "Coût trajet";
            table.Cell(1, 6).Range.Text = "Péages";
            table.Cell(1, 7).Range.Text = "Repas";
            table.Cell(1, 8).Range.Text = "Hébergement";
            table.Cell(1, 9).Range.Text = "Total";
            UCHome getTok = new UCHome();
            string getTotal = "select sum(totalCost) from slips where idMember = '" + getTok.returnToken()+"'";
            MySqlDataAdapter sumTotal = new MySqlDataAdapter(getTotal, coInsert);
            DataTable sumDt = new DataTable();
            sumTotal.Fill(sumDt);
            totalCostVar = sumDt.Rows[0][0].ToString();
            document.SaveAs2(ref save13, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);
            document.Close();
            wordApp.Quit();
            CreateWordDocument(mainPathUser + @"\bordereauFillDataGridUser.docx", mainPathUser + @"\bordereauFileFillUser.docx");
            FormPDFUser Fc = new FormPDFUser();
            Fc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf"})
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pathFile = ofd.FileName;
                string file = ofd.SafeFileName;
                textBox1.Visible = true;
                button3.Visible = true;
                textBox1.Text = file;
            }
        }
        public void databaseFilePut(string varFilePath)
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

            byte[] file;
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            using (var varConnection = connec)
            using (var sqlWrite = new MySqlCommand(@"update login set pdfSigned = @File where id = '" + getTokTri.returnToken() + "'", varConnection))
            {
                sqlWrite.Parameters.Add("@File", MySqlDbType.VarBinary, file.Length).Value = file;
                sqlWrite.ExecuteNonQuery();
            }
            connec.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            databaseFilePut(pathFile);
            MessageBox.Show("Bordereau bien déposé, vous pouvez modifier celui ci en déposant un nouveau fichier jusqu'au 24 décembre inclu.");
        }
    }
}
