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
using System.IO;
using word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Fredi
{
    public partial class UCTreasure : UserControl
    {
        public static string pathFile;
        public static string idUser;
        public static int comptSlip = 0;
        public static string totalCostVar;
        public static string totalCostVarBis;
        public int comptValidate = 0;
        public int comptValidateBis = 0;
        public static string mainPath = Application.ExecutablePath;
        
        public UCTreasure()
        {
            InitializeComponent();
        }

        private void UCTreasure_Load(object sender, EventArgs e)
        {
            mainPath = Directory.GetParent(mainPath).ToString();
            mainPath = Directory.GetParent(mainPath).ToString();
            mainPath = mainPath + @"\Resources";
        }

        public void allTreasurePart()
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
            UCHome getNum = new UCHome();
            string getNumTreasure = "select numLigue from adherents where idLogin = '" + getNum.returnToken() + "'";
            MySqlCommand recupNum = new MySqlCommand(getNumTreasure, connection);
            recupNum.ExecuteNonQuery();
            MySqlDataAdapter alop = new MySqlDataAdapter(getNumTreasure, connection);
            DataTable stocknum = new DataTable();
            alop.Fill(stocknum);
            string numGot = stocknum.Rows[0][0].ToString();
            string sqlQuery = "select firstName from adherents where numLigue = '" + numGot + "' ";
            MySqlCommand sqlcom = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader sdr = sqlcom.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (sdr.Read())
            {
                autotext.Add(sdr.GetString(0));
            }
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = autotext;
            sdr.Close();
            connection.Close();
            connection.Open();
            string sqlQuery2 = "select name from adherents where numLigue = '" + numGot + "' ";
            MySqlCommand sqlcom2 = new MySqlCommand(sqlQuery2, connection);
            MySqlDataReader sdr2 = sqlcom2.ExecuteReader();
            AutoCompleteStringCollection autotext2 = new AutoCompleteStringCollection();
            while (sdr2.Read())
            {
                autotext2.Add(sdr2.GetString(0));
            }
            textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteCustomSource = autotext2;
            sdr2.Close();
            connection.Close();


            connection.Open();
            string sqlQuery3 = "select numLicence from adherents where numLigue = '" + numGot + "' ";
            MySqlCommand sqlcom3 = new MySqlCommand(sqlQuery3, connection);
            MySqlDataReader sdr3 = sqlcom3.ExecuteReader();
            AutoCompleteStringCollection autotext3 = new AutoCompleteStringCollection();
            while (sdr3.Read())
            {
                autotext3.Add(sdr3.GetString(0));
            }
            textBox3.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox3.AutoCompleteCustomSource = autotext3;
            sdr3.Close();
            connection.Close();
            connection.Open();

            string rqtSelect = "SELECT * FROM login JOIN adherents ON  login.statut = 'user' WHERE  adherents.numLigue = '" + numGot + "' AND login.id = adherents.idLogin";

            MySqlCommand sqlCommand = new MySqlCommand(rqtSelect, connection);
            MySqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["firstName"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["numLicence"].ToString());
                listView1.Items.Add(item);

            }
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            getContent returnInfo = new getContent();
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = returnInfo.getServer();
            conn.UserID = returnInfo.getId();
            conn.Password = returnInfo.getPassword();
            conn.Database = returnInfo.getDb();
            var connString = conn.ToString();
            MySqlConnection connection = new MySqlConnection(connString);
            connection.Open();
            try
            {


                string select = "select idLogin from adherents where firstName = '" + textBox1.Text + "' and name = '" + textBox2.Text + "' and numLicence = '" + textBox3.Text + "'";
                MySqlDataAdapter getID = new MySqlDataAdapter(select, connection);
                DataTable idDt = new DataTable();
                getID.Fill(idDt);
                idUser = idDt.Rows[0][0].ToString();
                if (idDt.Rows[0][0].ToString() != null)
                {
                    try
                    {
                        string getInfo = "SELECT * FROM slips WHERE idMember = '" + idDt.Rows[0][0] + "'";
                        MySqlDataAdapter coInfo = new MySqlDataAdapter(getInfo, connection);
                        DataTable getDt = new DataTable();
                        coInfo.Fill(getDt);
                        string ouech = getDt.Rows[0][0].ToString();
                      
                        foreach (DataRow dt in getDt.Rows)
                        {
                            comptSlip++;
                                slipBindingSource1.Add(new Slip
                                {
                                        Id = Convert.ToInt32(dt["Id"]),
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

                            
                    }
                    catch
                    {
                        MessageBox.Show("Aucun bordereau n'a encore été completé par l'utilisateur");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner un utilisateur valide.");
                }
            }
            catch
            {
                MessageBox.Show("Veuillez renseigner un utilisateur valide.");
            }
          
            connection.Close();
        }

        public string getIdMember()
        {
            return idUser;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            int insertRow = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Valider")
            {
                try
                {
                    dataGridView1.Rows[insertRow].Cells["Validate"].Value = "0";
                    string updateValidated = "update slips set Validated = 'True' where id = '" + dataGridView1.Rows[insertRow].Cells["Id"].Value.ToString() + "'";
                    MySqlCommand putUpdateValid = new MySqlCommand(updateValidated, connection);
                    putUpdateValid.ExecuteNonQuery();

                }
                catch
                {
                    MessageBox.Show("Un soucis est survenu lors de la validation");
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Modifier")
            {
                try
                {
                string updateSlip = "update slips set date = '" + dataGridView1.Rows[insertRow].Cells["date"].Value.ToString() + "' , pattern = '" + dataGridView1.Rows[insertRow].Cells["pattern"].Value.ToString() + "' , path = '" + dataGridView1.Rows[insertRow].Cells["path"].Value.ToString() + "' , kmsTraveled = '" + dataGridView1.Rows[insertRow].Cells["kmsTraveled"].Value.ToString() + "' , pathCost = '" + dataGridView1.Rows[insertRow].Cells["pathCost"].Value.ToString() + "' , tollCost = '" + dataGridView1.Rows[insertRow].Cells["tollCost"].Value.ToString() + "' , mealCost = '" + dataGridView1.Rows[insertRow].Cells["mealCost"].Value.ToString() + "' , accomodationCost = '" + dataGridView1.Rows[insertRow].Cells["accommodationCost"].Value.ToString() + "' , totalCost = '" + dataGridView1.Rows[insertRow].Cells["totalCost"].Value.ToString() + "' where id = '" + dataGridView1.Rows[insertRow].Cells["Id"].Value.ToString() + "'";
                    MySqlCommand updateSlipDB = new MySqlCommand(updateSlip, connection);
                    updateSlipDB.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Modifications impossibles");
                }
            }
            connection.Close();
        }

        public static void databaseFileRead(string varID, string varPathToNewLocation)
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
            using (var varConnection = connection)
            using (var sqlQuery = new MySqlCommand("SELECT pdfSigned FROM login WHERE id = '" + varID + "'", varConnection))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
            }
            connection.Close();
        }
        
       

        private void button2_Click(object sender, EventArgs e)
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

            string selectValidated = "SELECT id from slips where Validated = 'true' and idMember = '"+idUser+"'";
            MySqlDataAdapter comSelect = new MySqlDataAdapter(selectValidated, connection);
            DataTable dtSelect = new DataTable();
            comSelect.Fill(dtSelect);
            foreach(DataRow dtse in dtSelect.Rows)
            {
                comptValidate++;
            }
            if (comptValidate == comptSlip)
            {
                MessageBox.Show("Où souhaitez vous le télécharger ?");

                using (FolderBrowserDialog ofd = new FolderBrowserDialog() { })
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pathFile = ofd.SelectedPath;

                    }
                string pathpath = pathFile + @"\pdfUser.pdf";
                databaseFileRead(idUser, pathpath);
            }

            else
            {
                MessageBox.Show("Tous les frais doivent être validés pour obtention du pdf signé.");
            }

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
            string getInfo = "select * from adherents where idLogin = '" + idUser + "'";
            MySqlDataAdapter exeGet = new MySqlDataAdapter(getInfo, coInsert);
            DataTable dtInfo = new DataTable();
            exeGet.Fill(dtInfo);

            word.Application wordApp = new word.Application();
            object missing = Missing.Value;
            word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

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
            myWordDoc.ExportAsFixedFormat(mainPath + @"\BordereauUser"+idUser+".pdf", word.WdExportFormat.wdExportFormatPDF);
            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Created");
            coInsert.Close();
        }


        public void CreateWordDocumentCerfa(object filename, object SaveAs)
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
            UCHome getTok = new UCHome();
            string getInfo = "select * from adherents where idLogin = '" + idUser + "'";
            MySqlDataAdapter exeGet = new MySqlDataAdapter(getInfo, coInsert);
            DataTable dtInfo = new DataTable();
            exeGet.Fill(dtInfo);

            string getTotalBis = "select sum(totalCost) from slips where idMember = '" + idUser + "'";
            MySqlDataAdapter sumTotalBis = new MySqlDataAdapter(getTotalBis, coInsert);
            DataTable sumDtBis = new DataTable();
            sumTotalBis.Fill(sumDtBis);
            totalCostVarBis = sumDtBis.Rows[0][0].ToString();
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

                this.FindAndReplace(wordApp, "<clubName>", "Nom du Club");
                this.FindAndReplace(wordApp, "<clubAdresse>", "Adresse du Club");
                this.FindAndReplace(wordApp, "<objet>", "Objet");
                this.FindAndReplace(wordApp, "<adherentName>", dtInfo.Rows[0]["name"].ToString());
                this.FindAndReplace(wordApp, "<adherentAdresse>", dtInfo.Rows[0]["firstName"].ToString());
                this.FindAndReplace(wordApp, "<prix>", totalCostVarBis + " €");
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
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
            myWordDoc.ExportAsFixedFormat(mainPath + @"\Cerfa"+idUser+".pdf", word.WdExportFormat.wdExportFormatPDF);
            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Created");
            coInsert.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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


            object save13 = mainPath + @"\datagridFill.docx";
            string template = mainPath + @"\templateBasic.docx";
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

            string getTotal = "select sum(totalCost) from slips where idMember = '" + idUser + "'";
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
            CreateWordDocument(mainPath + @"\datagridFill.docx", mainPath + @"\FileFill.docx");
            FormPDFUser Fc = new FormPDFUser();
            Fc.ShowDialog();
            coInsert.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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

            string selectValidated = "SELECT id from slips where Validated = 'true' and idMember = '" + idUser + "'";
            MySqlDataAdapter comSelect = new MySqlDataAdapter(selectValidated, connection);
            DataTable dtSelect = new DataTable();
            comSelect.Fill(dtSelect);
            foreach (DataRow dtse in dtSelect.Rows)
            {
                comptValidateBis++;
            }
            if(comptValidateBis == comptSlip)
            {
                try
                {
                    if (idUser != null)
                    {
                        CreateWordDocumentCerfa(mainPath + @"\templateCerfa.docx", mainPath + @"CerfaFill.docx");
                    }
                }
                catch
                { }
            }
            connection.Close();
        }
    }
}
