using System;
using System.Windows.Forms;

namespace VWFCalc
{
    public partial class KonfigDlg : Form
    {
        public KonfigDlg()
        {
            InitializeComponent();
        }

        private void KonfigDlg_Shown(object sender, EventArgs e)
        {
            panelNormalText.BackColor = Properties.Settings.Default.ColorNormalText;
            panelCritText.BackColor = Properties.Settings.Default.ColorCritText;
            panelUeberlangText.BackColor = Properties.Settings.Default.ColorUeberlangText;
            panelBackcolor.BackColor = Properties.Settings.Default.ColorBackground;
            panelMinText.BackColor = Properties.Settings.Default.ColorMinText;

            checkBoxIgnoreSpace.Checked = Properties.Settings.Default.IgnoreSpaceAtEnd;
            textBoxIgnorechars.Text = Properties.Settings.Default.IgnoreCharBegins;
            
            loadTextStrings();
        }

        public void loadTextStrings()
        {
            if (Properties.Settings.Default.Language == "de")
            {
                labelBackcolor.Text = Properties.Resources.KonfigBackcol_DE;
                labelCritText.Text = Properties.Resources.KonfigCritText_DE;
                labelNormalText.Text = Properties.Resources.KonfigNormText_DE;
                labelUeberlangText.Text = Properties.Resources.KonfigMaxText_DE;
                groupBoxColors.Text = Properties.Resources.KonfigFarben_DE;
                labelSprache.Text = Properties.Resources.Sprache_DE;
                groupBoxSonstiges.Text = Properties.Resources.KonfigSonstiges_DE;
                checkBoxIgnoreSpace.Text = Properties.Resources.KonfigIgnoreSpace_DE;
                labelIgnoreChars.Text = Properties.Resources.KonfigIgnoreZeilenbeginn_DE;
                labelMinLengthConf.Text = Properties.Resources.MinZeilenlaenge_DE;

                Text = Properties.Resources.Konfiguration_DE;
                comboBoxSprache.SelectedIndex = 0;
            }
            else
            {
                labelBackcolor.Text = Properties.Resources.KonfigBackcol_EN;
                labelCritText.Text = Properties.Resources.KonfigCritText_EN;
                labelNormalText.Text = Properties.Resources.KonfigNormText_EN;
                labelUeberlangText.Text = Properties.Resources.KonfigMaxText_EN;
                groupBoxColors.Text = Properties.Resources.KonfigFarben_EN;
                labelSprache.Text = Properties.Resources.Sprache_EN;
                groupBoxSonstiges.Text = Properties.Resources.KonfigSonstiges_EN;
                checkBoxIgnoreSpace.Text = Properties.Resources.KonfigIgnoreSpace_EN;
                labelIgnoreChars.Text = Properties.Resources.KonfigIgnoreZeilenbeginn_EN;
                labelMinLengthConf.Text = Properties.Resources.MinZeilenlaenge_EN;

                Text = Properties.Resources.Konfiguration_EN;
                comboBoxSprache.SelectedIndex = 1;
            }
        }

        private void panelNormalText_Click(object sender, EventArgs e)
        {
            PanelClick((Panel)sender);
        }

        private void panelUeberlangText_Click(object sender, EventArgs e)
        {
            PanelClick((Panel)sender);
        }

        private void panelCritText_Click(object sender, EventArgs e)
        {
            PanelClick((Panel)sender);
        }

        private void panelBackcolor_Click(object sender, EventArgs e)
        {
            PanelClick((Panel)sender);
        }
        
        private void panelMinText_Click(object sender, EventArgs e)
        {
            PanelClick((Panel)sender);
        }

        private void PanelClick(Panel senderPanel)
        {
            ColorDialog colorDlg = new ColorDialog();
            DialogResult dres = colorDlg.ShowDialog();

            if (dres == DialogResult.OK)
            {
                senderPanel.BackColor = colorDlg.Color;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColorNormalText = panelNormalText.BackColor;
            Properties.Settings.Default.ColorUeberlangText = panelUeberlangText.BackColor;
            Properties.Settings.Default.ColorCritText = panelCritText.BackColor;
            Properties.Settings.Default.ColorBackground = panelBackcolor.BackColor;
            Properties.Settings.Default.ColorMinText = panelMinText.BackColor;

            if (comboBoxSprache.SelectedIndex == 0)
            {
                Properties.Settings.Default.Language = "de";
            }
            else
            {
                Properties.Settings.Default.Language = "en";
            }

            Properties.Settings.Default.IgnoreSpaceAtEnd = checkBoxIgnoreSpace.Checked;
            Properties.Settings.Default.IgnoreCharBegins = textBoxIgnorechars.Text;

            Properties.Settings.Default.Save();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        
    }
}
