using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VWFCalc
{
    public partial class Form1 : Form
    {
        private string[] strFileInput;
        private string[] strTableInput;
        private int iMaxZeilenlaenge;
        private int iCritZeilenlaenge;
        private int iPixelsBetween;
        private int iMinZeilenlaenge;

        private string strActualProjectFile = "";
        private projectFile actualProject;
        private string strSaveLocation;

        private DataTable tableTbl;
        private DataTable tableText;
        private List<textzeile> listTextzeilen; 

        public Form1()
        {
            InitializeComponent();

            //2 Spalten in das Table einfügen
            tableTbl = new DataTable();
            tableText = new DataTable();
            listTextzeilen = new List<textzeile>();
            tableTbl.CaseSensitive = true;
            tableTbl.Columns.Add("zeichen");
            tableTbl.Columns.Add("laenge");

            tableText.Columns.Add("laenge", typeof(int));
            tableText.Columns.Add("text");
            tableText.Columns.Add("id", typeof(int));
            tableText.Columns["laenge"].ReadOnly = true;

            LoadInterfaceSettings();
        }

        private void LoadInterfaceSettings()
        {
            dataGridView1.BackColor = Properties.Settings.Default.ColorBackground;

            if (Properties.Settings.Default.Language == "de")
            {
                buttonTextdatei.Text = Properties.Resources.TextdateiLaden_DE;
                buttonTable.Text = Properties.Resources.TableLaden_DE;
                labelMaxLength.Text = Properties.Resources.MaxZeilenlaenge_DE;
                labelCritLength.Text = Properties.Resources.CritZeilenlaenge_DE;
                labelPixelBetween.Text = Properties.Resources.PixelBetween_DE;
                buttonAnzeigen.Text = Properties.Resources.Anzeigen_DE;
                labelPixelcount.Text = Properties.Resources.PixelzahlMarkiert_DE;
                tableEditorToolStripMenuItem.Text = Properties.Resources.TableEditor_DE;
                konfigurationToolStripMenuItem.Text = Properties.Resources.Konfiguration_DE;
                infoToolStripMenuItem.Text = Properties.Resources.Info_DE;
                beendenToolStripMenuItem.Text = Properties.Resources.Beenden_DE;
                dateiToolStripMenuItem.Text = Properties.Resources.Datei_DE;
                projektÖffnenToolStripMenuItem.Text = Properties.Resources.ProjektLaden_DE;
                projektSpeichernToolStripMenuItem.Text = Properties.Resources.ProjektSpeichern_DE;
                projektSpeichernUnterToolStripMenuItem.Text = Properties.Resources.ProjektSpeichernAls_DE;
                zusatzToolStripMenuItem.Text = Properties.Resources.Werkzeuge_DE;
                labelMinLength.Text = Properties.Resources.MinZeilenlaenge_DE;
                labelIgnoreGroups.Text = Properties.Resources.IgnoriereZeichengruppen_DE;
                checkBoxShowLeerzeilen.Text = Properties.Resources.LeerzeilenZeigen_DE;
                buttonSaveTextDocument.Text = Properties.Resources.SpeichereTextdatei_DE;
            }
            else
            {
                buttonTextdatei.Text = Properties.Resources.TextdateiLaden_EN;
                buttonTable.Text = Properties.Resources.TableLaden_EN;
                labelMaxLength.Text = Properties.Resources.MaxZeilenlaenge_EN;
                labelCritLength.Text = Properties.Resources.CritZeilenlaenge_EN;
                labelPixelBetween.Text = Properties.Resources.PixelBetween_EN;
                buttonAnzeigen.Text = Properties.Resources.Anzeigen_EN;
                labelPixelcount.Text = Properties.Resources.PixelzahlMarkiert_EN;
                tableEditorToolStripMenuItem.Text = Properties.Resources.TableEditor_EN;
                konfigurationToolStripMenuItem.Text = Properties.Resources.Konfiguration_EN;
                infoToolStripMenuItem.Text = Properties.Resources.Info_EN;
                beendenToolStripMenuItem.Text = Properties.Resources.Beenden_EN; 
                dateiToolStripMenuItem.Text = Properties.Resources.Datei_EN;
                projektÖffnenToolStripMenuItem.Text = Properties.Resources.ProjektLaden_EN;
                projektSpeichernToolStripMenuItem.Text = Properties.Resources.ProjektSpeichern_EN;
                projektSpeichernUnterToolStripMenuItem.Text = Properties.Resources.ProjektSpeichernAls_EN;
                zusatzToolStripMenuItem.Text = Properties.Resources.Werkzeuge_EN;
                labelMinLength.Text = Properties.Resources.MinZeilenlaenge_EN;
                labelIgnoreGroups.Text = Properties.Resources.IgnoriereZeichengruppen_EN;
                checkBoxShowLeerzeilen.Text = Properties.Resources.LeerzeilenZeigen_EN;
                buttonSaveTextDocument.Text = Properties.Resources.SpeichereTextdatei_EN;
            }
        }

        private void buttonTextdatei_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            DialogResult dres = openDlg.ShowDialog();

            if (dres == DialogResult.OK)
            {
                labelTextdatei.Text = openDlg.FileName;
            }
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            DialogResult dres = openDlg.ShowDialog();

            if (dres == DialogResult.OK)
            {
                labelTable.Text = openDlg.FileName;
                
            }
        }

        private int GetZeilenlaenge(string strZeile, bool bIsSelection)
        {
            int iZeilenlaenge = 0;
            if (Properties.Settings.Default.IgnoreSpaceAtEnd && !bIsSelection)
            {
                strZeile = strZeile.TrimEnd(' ');
            }
            List<string> ListIgnoreLinechars;
            string[] strIgnorechars = Properties.Settings.Default.IgnoreCharBegins.Split(' ');
            
            ListIgnoreLinechars = new List<string>(strIgnorechars);

            //Bereinige strZeile um die zu ignorierenden Zeichengruppen:
            for (int i = 0; i < actualProject.ListIgnoreGroups.Count; i++)
            {
                strZeile = strZeile.Replace(actualProject.ListIgnoreGroups[i], "");
            }

            foreach (char chr in strZeile)
            {
                if (!ListIgnoreLinechars.Contains(strZeile[0].ToString()))
                {
                    DataRow[] selRow;
                    if (chr == 39)
                    {
                        selRow = tableTbl.Select("zeichen = '" + chr + "''");
                    }
                    else
                    {
                        selRow = tableTbl.Select("zeichen = '" + chr + "'");
                    }
                    try
                    {
                        iZeilenlaenge += int.Parse(selRow[0][1].ToString());
                        iZeilenlaenge += int.Parse(textBoxPixelBetween.Text);
                    }
                    catch (Exception ex)
                    {

                    }                    
                }
            }
            return iZeilenlaenge;
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            if (File.Exists(labelTextdatei.Text) && File.Exists(labelTable.Text))
            {
                strFileInput = File.ReadAllLines(labelTextdatei.Text, Encoding.Default);
                strTableInput = File.ReadAllLines(labelTable.Text, Encoding.Default);
                tableTbl.Clear();
                for (int i = 0; i < strTableInput.Length; i++)
                {
                    DataRow drow = tableTbl.NewRow();
                    string[] strTblEntry = strTableInput[i].Split('=');
                    drow[0] = strTblEntry[0];
                    drow[1] = strTblEntry[1];
                    tableTbl.Rows.Add(drow);
                }

                if (strFileInput.Length != 0 && strTableInput.Length != 0 && textBoxLaenge.Text.Length != 0)
                {
                    int.TryParse(textBoxLaenge.Text, out iMaxZeilenlaenge);
                    int.TryParse(textBoxCritLaenge.Text, out iCritZeilenlaenge);
                    int.TryParse(textBoxPixelBetween.Text, out iPixelsBetween);
                    int.TryParse(textBoxMinZeilenlaenge.Text, out iMinZeilenlaenge);

                    actualProject = MakeProject();

                    listTextzeilen = MakeTextzeilen(strFileInput);

                    ShowResultsInDataGrid();
                }
            }
        }

        private projectFile MakeProject()
        {
            projectFile proj = new projectFile();
            proj.ICritZeilenlaenge = iCritZeilenlaenge;
            proj.IMaxZeilenlaenge = iMaxZeilenlaenge;
            proj.IPixelsBetweenChars = iPixelsBetween;
            proj.IMinZeilenlaenge = iMinZeilenlaenge;

            proj.StrTableLocation = labelTable.Text;
            proj.StrTextdateiLocation = labelTextdatei.Text;

            for (int i = 0; i < textBoxIgnoreGroups.Lines.Length; i++)
            {
                proj.ListIgnoreGroups.Add(textBoxIgnoreGroups.Lines[i]);
            }

            proj.BShowEmptyLines = checkBoxShowLeerzeilen.Checked;
            proj.TextEncoding = helpers.GetEncoding(labelTextdatei.Text);
            
            return proj;
        }

        private void ShowResultsInDataGrid()
        {
            tableText.Clear();
            for (int i = 0; i < listTextzeilen.Count; i++)
            {
                if (listTextzeilen[i].ILength == 0 && !actualProject.BShowEmptyLines)
                {
                    
                }
                else
                {
                    DataRow row = tableText.NewRow();
                    row["laenge"] = listTextzeilen[i].ILength;
                    row["text"] = listTextzeilen[i].StrText;
                    row["id"] = listTextzeilen[i].IId;
                    tableText.Rows.Add(row);
                }
            }
            
            tableText.Columns["text"].Caption = "Text";

            dataGridView1.DataSource = tableText;
            dataGridView1.Columns[2].Visible = false;
            if (dataGridView1.Columns.Contains("laenge"))
            {
                dataGridView1.Columns["laenge"].Width = 80;
            }
            
            ColorDataGrid();
        }

        /// <summary>
        /// Speichert das aktuelle DataTable (den Text) über das bisherige Textfile
        /// </summary>
        /// <param name="strFilename"></param>
        private void SaveTextfile(string strFilename)
        {
            for (int i = 0; i < tableText.Rows.Count; i++)
            {
                for (int j = 0; j < listTextzeilen.Count; j++)
                {
                    if ((int) tableText.Rows[i][2] == listTextzeilen[j].IId)
                    {
                        listTextzeilen[j].StrText = tableText.Rows[i][1].ToString();
                    }
                }
            }
            StreamWriter swriter = new StreamWriter(strFilename, false, actualProject.TextEncoding);
            for (int i = 0; i < listTextzeilen.Count; i++)
            {
                swriter.WriteLine(listTextzeilen[i].StrText);
                swriter.Flush();
            }
            swriter.Close();
        }

        /// <summary>
        /// Färbt das DataGrid entsprechend der Vorgaben ein
        /// </summary>
        private void ColorDataGrid()
        {
            for (int i = 0; i < tableText.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.ColorBackground;
                if (((int)tableText.Rows[i][0]) >= iCritZeilenlaenge && ((int)tableText.Rows[i][0]) != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.ColorCritText;
                }
                if (((int)tableText.Rows[i][0]) > iMaxZeilenlaenge && ((int)tableText.Rows[i][0]) != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.ColorUeberlangText;
                }
                if (((int)tableText.Rows[i][0]) < iMinZeilenlaenge && ((int)tableText.Rows[i][0]) != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.ColorMinText;
                }
            }
        }

        /// <summary>
        /// Erstellt Textzeilen-Objekte aus dem Textfile. Ermittelt auch gleich die Zeilenlänge.
        /// </summary>
        /// <param name="strFInput"></param>
        /// <returns></returns>
        private List<textzeile> MakeTextzeilen(string[] strFInput)
        {
            List<textzeile> liste = new List<textzeile>();
            for (int i = 0; i < strFInput.Length; i++)
            {
                textzeile txt = new textzeile();
                txt.StrText = strFInput[i];
                txt.ILength = GetZeilenlaenge(txt.StrText, false);
                txt.IId = i;
                liste.Add(txt);
            }

            return liste;
        }

        #region Menustrip-Items

        private void tableEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableEditor tableEdit = new TableEditor();
            tableEdit.ShowDialog(labelTable.Text);
        }

        private void konfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KonfigDlg configDlg = new KonfigDlg();
            configDlg.ShowDialog();

            LoadInterfaceSettings();
            
            //buttonAnzeigen_Click(this, null);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abBox = new AboutBox();
            abBox.ShowDialog();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void buttonGoUp_Click(object sender, EventArgs e)
        {
            int i = getNextCritInDataGrid(Suchreihenfolge.hoch);

            if (i != int.MaxValue)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = i;
                dataGridView1.Rows[i].Cells[0].Selected = true;
            }
        }

        private void buttonGoDown_Click(object sender, EventArgs e)
        {
            int i = getNextCritInDataGrid(Suchreihenfolge.runter);

            if (i != int.MaxValue)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = i;
                dataGridView1.Rows[i].Cells[0].Selected = true;
            }
        }

        private void projektÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "VWF-Projekte (*.vwfproj)|*.vwfproj";
            DialogResult dres = fileDlg.ShowDialog();
            if (dres == DialogResult.OK)
            {
                try
                {
                    actualProject = OpenProjekt(fileDlg.FileName);
                    LadeProjekt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Laden des Projekts. Handelt es sich um eine gültige Projektdatei?", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void projektSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(strSaveLocation))
            {
                projektSpeichernUnterToolStripMenuItem_Click(this, null);
            }
            else
            {
                SaveProjekt(strSaveLocation, actualProject);
            }
        }

        private void projektSpeichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.AddExtension = true;
            saveDlg.DefaultExt = ".vwfproj";
            saveDlg.Filter = "VWF-Projekte (*.vwfproj)|*.vwfproj";
            DialogResult dres = saveDlg.ShowDialog();
            if (dres == DialogResult.OK)
            {
                strSaveLocation = saveDlg.FileName;
                SaveProjekt(strSaveLocation, actualProject);
            }
        }

        private projectFile OpenProjekt(string strFilename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(projectFile));
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            projectFile proj = (projectFile)serializer.Deserialize(stream);
            stream.Dispose();

            for (int i = 0; i < proj.ListIgnoreGroups.Count; i++)
            {
                proj.ListIgnoreGroups[i] = ReReplaceXmlChars(proj.ListIgnoreGroups[i]);
            }

            return proj;
        }

        private void LadeProjekt()
        {
            labelTextdatei.Text = actualProject.StrTextdateiLocation;
            labelTable.Text = actualProject.StrTableLocation;

            textBoxCritLaenge.Text = actualProject.ICritZeilenlaenge.ToString();
            textBoxLaenge.Text = actualProject.IMaxZeilenlaenge.ToString();
            textBoxPixelBetween.Text = actualProject.IPixelsBetweenChars.ToString();
            textBoxMinZeilenlaenge.Text = actualProject.IMinZeilenlaenge.ToString();

            textBoxIgnoreGroups.Lines = actualProject.ListIgnoreGroups.ToArray();
            checkBoxShowLeerzeilen.Checked = actualProject.BShowEmptyLines;

            buttonAnzeigen_Click(this, null);
        }

        private void SaveProjekt(string strFilename, projectFile proj)
        {
            if (File.Exists(strFilename))
            {
                File.Delete(strFilename);
            }

            for (int i = 0; i < proj.ListIgnoreGroups.Count; i++)
            {
                proj.ListIgnoreGroups[i] = ReplaceXmlChars(proj.ListIgnoreGroups[i]);
            }

            FileStream stream = new FileStream(strFilename, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(projectFile));
            serializer.Serialize(stream, proj);
            stream.Close();
        }

        public int getNextCritInDataGrid(Suchreihenfolge such)
        {
            try
            {
                if (such == Suchreihenfolge.runter)
                {
                    for (int i = dataGridView1.SelectedCells[0].RowIndex + 1; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Properties.Settings.Default.ColorUeberlangText)
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    for (int i = dataGridView1.SelectedCells[0].RowIndex - 1; i > 0; i--)
                    {
                        if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Properties.Settings.Default.ColorUeberlangText)
                        {
                            return i;
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }

            return int.MaxValue;
        }

        private void buttonSaveTextDocument_Click(object sender, EventArgs e)
        {
            //string strFilename = Path.GetDirectoryName(actualProject.StrTextdateiLocation) + "\\testtext.txt";
            //SaveTextfile(strFilename);

            try
            {
                SaveTextfile(actualProject.StrTextdateiLocation);
            }
            catch (Exception)
            {
                
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ActualizeLengths(e.RowIndex);
        }

        private void ActualizeLengths(int iRowIndex)
        {
            tableText.Columns["laenge"].ReadOnly = false;
            tableText.Rows[iRowIndex][0] = GetZeilenlaenge(tableText.Rows[iRowIndex][1].ToString(), false);
            tableText.Columns["laenge"].ReadOnly = true;

            ColorDataGrid();
        }

        private string ReplaceXmlChars(string str)
        {
            
			//Sonderzeichen
			str = str.Replace("&", "&#38;");
			str = str.Replace("<", "&#60;");
            str = str.Replace(">", "&#62;");
            str = str.Replace("µ", "&#181;");
            str = str.Replace("'", "&#8242;");
            str = str.Replace('"'.ToString(), "&#34;");
			str = str.Replace("§", "&#167;");
			
			//Umlaute(Deutsch)
            str = str.Replace("Ä", "&#196;");
            str = str.Replace("ä", "&#228;");
            str = str.Replace("Ö", "&#214;");
            str = str.Replace("ö", "&#246;");
            str = str.Replace("Ü", "&#220;");
            str = str.Replace("ü", "&#252;");
            str = str.Replace("ß", "&#223;");
            
			//Währungen
			str = str.Replace("€", "&#8364;");
			str = str.Replace("£", "&#163;");
			str = str.Replace("¥", "&#165;");
			
            return str;
        }

        private string ReReplaceXmlChars(string str)
        {
			//Sonderzeichen
            str = str.Replace("&#38;", "&");
			str = str.Replace("&#60;", "<");
            str = str.Replace("&#62;", ">");
            str = str.Replace("&#181;", "µ");
            str = str.Replace("&#8242;", "'");
            str = str.Replace("&#34;", '"'.ToString());
			str = str.Replace("&#167;", "§");
			
			//Umlaute(Deutsch)
            str = str.Replace("&#196;", "Ä");
            str = str.Replace("&#228;", "ä");
            str = str.Replace("&#214;", "Ö");
            str = str.Replace("&#246;", "ö");
            str = str.Replace("&#220;", "Ü");
            str = str.Replace("&#252;", "ü");
            str = str.Replace("&#223;", "ß");

			//Währungen
			str = str.Replace("&#8364;", "€");
			str = str.Replace("&#163;", "£");
			str = str.Replace("&#165;", "¥");
			
            return str;
        }
    }
}
