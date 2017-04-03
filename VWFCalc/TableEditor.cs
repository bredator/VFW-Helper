using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VWFCalc.Properties;

namespace VWFCalc
{
    public partial class TableEditor : Form
    {
        private DataTable table;

        private string strTablefilepath = string.Empty;

        public TableEditor()
        {
            InitializeComponent();
        }

        public void ShowDialog(string strTablefile)
        {
            strTablefilepath = strTablefile;
            ShowDialog();
        }

        public void loadTextStrings()
        {
            if (Settings.Default.Language == "de")
            {
                buttonNeu.Text = Resources.EditorNew_DE;
                buttonLaden.Text = Resources.EditorLoad_DE;
                buttonSpeichern.Text = Resources.EditorSave_DE;
            }
            else
            {
                buttonNeu.Text = Resources.EditorNew_EN;
                buttonLaden.Text = Resources.EditorLoad_EN;
                buttonSpeichern.Text = Resources.EditorSave_EN;
            }
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Zeichen");
            table.Columns.Add("Pixelbreite");

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12f, FontStyle.Bold);

            for (int i = 0; i < 26; i++)
            {
                DataRow row = table.NewRow();
                row[0] = Convert.ToChar(65 + i);
                table.Rows.Add(row);
            }
            for (int i = 0; i < 26; i++)
            {
                DataRow row = table.NewRow();
                row[0] = Convert.ToChar(97 + i);
                table.Rows.Add(row);
            }

            int[] iUmlaute = { 196, 214, 220, 228, 246, 252, 223, 180 };
            for (int i = 0; i < iUmlaute.Length; i++)
            {
                DataRow row = table.NewRow();
                row[0] = Convert.ToChar(iUmlaute[i]);
                table.Rows.Add(row);
            }

            for (int i = 0; i < 10; i++)
            {
                DataRow row = table.NewRow();
                row[0] = Convert.ToChar(48 + i);
                table.Rows.Add(row);
            }
            for (int i = 0; i < 16; i++)
            {
                DataRow row = table.NewRow();
                row[0] = Convert.ToChar(32 + i);
                table.Rows.Add(row);
            }
            for (int i = 0; i < 7; i++)
            {
                DataRow row = table.NewRow();
                row[0] = Convert.ToChar(58 + i);
                table.Rows.Add(row);
            }
            for (int i = 0; i < 6; i++)
            {
                DataRow row = table.NewRow();
                row[0] = Convert.ToChar(91 + i);
                table.Rows.Add(row);
            }
            for (int i = 0; i < 4; i++)
            {
                DataRow row = table.NewRow();
                row[0] = Convert.ToChar(123 + i);
                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                SaveFileDialog saveDlg = new SaveFileDialog();
                DialogResult dres = saveDlg.ShowDialog();

                if (dres == DialogResult.OK)
                {
                    string[] strTable = new string[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (table.Rows[i][1].ToString() != "")
                        {
                            strTable[i] = table.Rows[i][0] + "=" + table.Rows[i][1];
                        }
                        else
                        {
                            strTable[i] = table.Rows[i][0] + "=0";
                        }
                    }
                    StreamWriter swriter = new StreamWriter(saveDlg.FileName, false, Encoding.Default);
                    for (int i = 0; i < strTable.Length; i++)
                    {
                        swriter.WriteLine(strTable[i]);
                    }
                    swriter.Close();
                }
            }
        }

        private void buttonLaden_Click(object sender, EventArgs e)
        {
            DialogResult AktuellesTableRes = DialogResult.OK;
            if (strTablefilepath != "" && Settings.Default.Language == "de")
            {
                AktuellesTableRes = MessageBox.Show("Aktuelles Table einlesen?", "Frage", MessageBoxButtons.YesNo);
            }
            else if (strTablefilepath != "" && Settings.Default.Language == "en")
            {
                AktuellesTableRes = MessageBox.Show("Load actual table?", "Question", MessageBoxButtons.YesNo);
            }
            
            if (AktuellesTableRes == DialogResult.Yes)
            {
                try
                {
                    string[] strTableEintraege = File.ReadAllLines(strTablefilepath, Encoding.Default);

                    table = new DataTable();
                    table.Columns.Add("Zeichen");
                    table.Columns.Add("Pixelbreite");

                    for (int i = 0; i < strTableEintraege.Length; i++)
                    {
                        string[] strEinzelEintrag = strTableEintraege[i].Split('=');
                        DataRow drow = table.NewRow();
                        drow[0] = strEinzelEintrag[0];
                        drow[1] = strEinzelEintrag[1];
                        table.Rows.Add(drow);
                    }
                    dataGridView1.DataSource = table;
                }
                catch (Exception)
                {
                    if (Settings.Default.Language == "de")
                    {
                        MessageBox.Show(Resources.TableLadenFehler_DE);
                    }
                    else
                    {
                        MessageBox.Show(Resources.TableLadenFehler_EN);
                    }
                }
            }
            else
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                DialogResult dres = openDlg.ShowDialog();

                if (dres == DialogResult.OK)
                {
                    try
                    {
                        string[] strTableEintraege = File.ReadAllLines(openDlg.FileName, Encoding.Default);

                        table = new DataTable();
                        table.Columns.Add("Zeichen");
                        table.Columns.Add("Pixelbreite");

                        for (int i = 0; i < strTableEintraege.Length; i++)
                        {
                            string[] strEinzelEintrag = strTableEintraege[i].Split('=');
                            DataRow drow = table.NewRow();
                            drow[0] = strEinzelEintrag[0];
                            drow[1] = strEinzelEintrag[1];
                            table.Rows.Add(drow);
                        }
                        dataGridView1.DataSource = table;
                    }
                    catch (Exception)
                    {
                        if (Settings.Default.Language == "de")
                        {
                            MessageBox.Show(Resources.TableLadenFehler_DE);
                        }
                        else
                        {
                            MessageBox.Show(Resources.TableLadenFehler_EN);
                        }
                        throw;
                    }

                }
            }
        }

        private void TableEditor_Shown(object sender, EventArgs e)
        {
            loadTextStrings();
        }
    }
}
