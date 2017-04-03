namespace VWFCalc
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelMaxLength = new System.Windows.Forms.Label();
            this.textBoxLaenge = new System.Windows.Forms.TextBox();
            this.buttonTextdatei = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.labelTextdatei = new System.Windows.Forms.Label();
            this.labelTable = new System.Windows.Forms.Label();
            this.textBoxPixelBetween = new System.Windows.Forms.TextBox();
            this.labelPixelBetween = new System.Windows.Forms.Label();
            this.textBoxCritLaenge = new System.Windows.Forms.TextBox();
            this.labelCritLength = new System.Windows.Forms.Label();
            this.textBoxMarkierteLaenge = new System.Windows.Forms.TextBox();
            this.labelPixelcount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektSpeichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zusatzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGoUp = new System.Windows.Forms.Button();
            this.buttonGoDown = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxMinZeilenlaenge = new System.Windows.Forms.TextBox();
            this.labelMinLength = new System.Windows.Forms.Label();
            this.labelIgnoreGroups = new System.Windows.Forms.Label();
            this.textBoxIgnoreGroups = new System.Windows.Forms.TextBox();
            this.checkBoxShowLeerzeilen = new System.Windows.Forms.CheckBox();
            this.buttonSaveTextDocument = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaxLength
            // 
            this.labelMaxLength.AutoSize = true;
            this.labelMaxLength.Location = new System.Drawing.Point(648, 163);
            this.labelMaxLength.Name = "labelMaxLength";
            this.labelMaxLength.Size = new System.Drawing.Size(154, 13);
            this.labelMaxLength.TabIndex = 4;
            this.labelMaxLength.Text = "Maximale Zeilenlänge in Pixeln:";
            // 
            // textBoxLaenge
            // 
            this.textBoxLaenge.Location = new System.Drawing.Point(808, 160);
            this.textBoxLaenge.Name = "textBoxLaenge";
            this.textBoxLaenge.Size = new System.Drawing.Size(49, 20);
            this.textBoxLaenge.TabIndex = 2;
            this.textBoxLaenge.Text = "0";
            // 
            // buttonTextdatei
            // 
            this.buttonTextdatei.Location = new System.Drawing.Point(594, 38);
            this.buttonTextdatei.Name = "buttonTextdatei";
            this.buttonTextdatei.Size = new System.Drawing.Size(102, 23);
            this.buttonTextdatei.TabIndex = 0;
            this.buttonTextdatei.Text = "Textdatei laden";
            this.buttonTextdatei.UseVisualStyleBackColor = true;
            this.buttonTextdatei.Click += new System.EventHandler(this.buttonTextdatei_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.Location = new System.Drawing.Point(594, 96);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(102, 23);
            this.buttonTable.TabIndex = 1;
            this.buttonTable.Text = "Table laden";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Location = new System.Drawing.Point(594, 524);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(102, 23);
            this.buttonAnzeigen.TabIndex = 5;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // labelTextdatei
            // 
            this.labelTextdatei.AutoSize = true;
            this.labelTextdatei.Location = new System.Drawing.Point(600, 68);
            this.labelTextdatei.Name = "labelTextdatei";
            this.labelTextdatei.Size = new System.Drawing.Size(0, 13);
            this.labelTextdatei.TabIndex = 9;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(600, 127);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(0, 13);
            this.labelTable.TabIndex = 10;
            // 
            // textBoxPixelBetween
            // 
            this.textBoxPixelBetween.Location = new System.Drawing.Point(808, 238);
            this.textBoxPixelBetween.Name = "textBoxPixelBetween";
            this.textBoxPixelBetween.Size = new System.Drawing.Size(49, 20);
            this.textBoxPixelBetween.TabIndex = 4;
            this.textBoxPixelBetween.Text = "0";
            // 
            // labelPixelBetween
            // 
            this.labelPixelBetween.AutoSize = true;
            this.labelPixelBetween.Location = new System.Drawing.Point(648, 241);
            this.labelPixelBetween.Name = "labelPixelBetween";
            this.labelPixelBetween.Size = new System.Drawing.Size(139, 13);
            this.labelPixelBetween.TabIndex = 13;
            this.labelPixelBetween.Text = "Pixel zwischen Buchstaben:";
            // 
            // textBoxCritLaenge
            // 
            this.textBoxCritLaenge.Location = new System.Drawing.Point(808, 186);
            this.textBoxCritLaenge.Name = "textBoxCritLaenge";
            this.textBoxCritLaenge.Size = new System.Drawing.Size(49, 20);
            this.textBoxCritLaenge.TabIndex = 3;
            this.textBoxCritLaenge.Text = "0";
            // 
            // labelCritLength
            // 
            this.labelCritLength.AutoSize = true;
            this.labelCritLength.Location = new System.Drawing.Point(648, 189);
            this.labelCritLength.Name = "labelCritLength";
            this.labelCritLength.Size = new System.Drawing.Size(108, 13);
            this.labelCritLength.TabIndex = 16;
            this.labelCritLength.Text = "Kritische Zeilenlänge:";
            // 
            // textBoxMarkierteLaenge
            // 
            this.textBoxMarkierteLaenge.Location = new System.Drawing.Point(754, 587);
            this.textBoxMarkierteLaenge.Name = "textBoxMarkierteLaenge";
            this.textBoxMarkierteLaenge.Size = new System.Drawing.Size(49, 20);
            this.textBoxMarkierteLaenge.TabIndex = 19;
            this.textBoxMarkierteLaenge.Text = "0";
            this.textBoxMarkierteLaenge.Visible = false;
            // 
            // labelPixelcount
            // 
            this.labelPixelcount.AutoSize = true;
            this.labelPixelcount.Location = new System.Drawing.Point(600, 590);
            this.labelPixelcount.Name = "labelPixelcount";
            this.labelPixelcount.Size = new System.Drawing.Size(124, 13);
            this.labelPixelcount.TabIndex = 18;
            this.labelPixelcount.Text = "Pixelzahl markierter Text:";
            this.labelPixelcount.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(580, 569);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.zusatzToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektÖffnenToolStripMenuItem,
            this.projektSpeichernToolStripMenuItem,
            this.projektSpeichernUnterToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // projektÖffnenToolStripMenuItem
            // 
            this.projektÖffnenToolStripMenuItem.Name = "projektÖffnenToolStripMenuItem";
            this.projektÖffnenToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.projektÖffnenToolStripMenuItem.Text = "Projekt öffnen";
            this.projektÖffnenToolStripMenuItem.Click += new System.EventHandler(this.projektÖffnenToolStripMenuItem_Click);
            // 
            // projektSpeichernToolStripMenuItem
            // 
            this.projektSpeichernToolStripMenuItem.Name = "projektSpeichernToolStripMenuItem";
            this.projektSpeichernToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.projektSpeichernToolStripMenuItem.Text = "Projekt speichern";
            this.projektSpeichernToolStripMenuItem.Click += new System.EventHandler(this.projektSpeichernToolStripMenuItem_Click);
            // 
            // projektSpeichernUnterToolStripMenuItem
            // 
            this.projektSpeichernUnterToolStripMenuItem.Name = "projektSpeichernUnterToolStripMenuItem";
            this.projektSpeichernUnterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.projektSpeichernUnterToolStripMenuItem.Text = "Projekt speichern unter...";
            this.projektSpeichernUnterToolStripMenuItem.Click += new System.EventHandler(this.projektSpeichernUnterToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // zusatzToolStripMenuItem
            // 
            this.zusatzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableEditorToolStripMenuItem,
            this.konfigurationToolStripMenuItem});
            this.zusatzToolStripMenuItem.Name = "zusatzToolStripMenuItem";
            this.zusatzToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.zusatzToolStripMenuItem.Text = "&Werkzeuge";
            // 
            // tableEditorToolStripMenuItem
            // 
            this.tableEditorToolStripMenuItem.Name = "tableEditorToolStripMenuItem";
            this.tableEditorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.tableEditorToolStripMenuItem.Text = "Table-Editor";
            this.tableEditorToolStripMenuItem.Click += new System.EventHandler(this.tableEditorToolStripMenuItem_Click);
            // 
            // konfigurationToolStripMenuItem
            // 
            this.konfigurationToolStripMenuItem.Name = "konfigurationToolStripMenuItem";
            this.konfigurationToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.konfigurationToolStripMenuItem.Text = "Konfiguration";
            this.konfigurationToolStripMenuItem.Click += new System.EventHandler(this.konfigurationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // buttonGoUp
            // 
            this.buttonGoUp.Image = global::VWFCalc.Properties.Resources.go_up;
            this.buttonGoUp.Location = new System.Drawing.Point(594, 171);
            this.buttonGoUp.Name = "buttonGoUp";
            this.buttonGoUp.Size = new System.Drawing.Size(35, 35);
            this.buttonGoUp.TabIndex = 6;
            this.toolTip1.SetToolTip(this.buttonGoUp, "Vorherige fehlerhafte Zeile");
            this.buttonGoUp.UseVisualStyleBackColor = true;
            this.buttonGoUp.Click += new System.EventHandler(this.buttonGoUp_Click);
            // 
            // buttonGoDown
            // 
            this.buttonGoDown.Image = global::VWFCalc.Properties.Resources.go_down;
            this.buttonGoDown.Location = new System.Drawing.Point(594, 212);
            this.buttonGoDown.Name = "buttonGoDown";
            this.buttonGoDown.Size = new System.Drawing.Size(35, 35);
            this.buttonGoDown.TabIndex = 7;
            this.toolTip1.SetToolTip(this.buttonGoDown, "Nächste fehlerhafte Zeile");
            this.buttonGoDown.UseVisualStyleBackColor = true;
            this.buttonGoDown.Click += new System.EventHandler(this.buttonGoDown_Click);
            // 
            // textBoxMinZeilenlaenge
            // 
            this.textBoxMinZeilenlaenge.Location = new System.Drawing.Point(808, 212);
            this.textBoxMinZeilenlaenge.Name = "textBoxMinZeilenlaenge";
            this.textBoxMinZeilenlaenge.Size = new System.Drawing.Size(49, 20);
            this.textBoxMinZeilenlaenge.TabIndex = 27;
            this.textBoxMinZeilenlaenge.Text = "0";
            // 
            // labelMinLength
            // 
            this.labelMinLength.AutoSize = true;
            this.labelMinLength.Location = new System.Drawing.Point(648, 215);
            this.labelMinLength.Name = "labelMinLength";
            this.labelMinLength.Size = new System.Drawing.Size(109, 13);
            this.labelMinLength.TabIndex = 28;
            this.labelMinLength.Text = "Minimale Zeilenlänge:";
            // 
            // labelIgnoreGroups
            // 
            this.labelIgnoreGroups.AutoEllipsis = true;
            this.labelIgnoreGroups.Location = new System.Drawing.Point(591, 296);
            this.labelIgnoreGroups.Name = "labelIgnoreGroups";
            this.labelIgnoreGroups.Size = new System.Drawing.Size(296, 35);
            this.labelIgnoreGroups.TabIndex = 30;
            this.labelIgnoreGroups.Text = "Bei Textlängenermittlung zu ignorierende Zeichengruppen (eine pro Zeile):";
            // 
            // textBoxIgnoreGroups
            // 
            this.textBoxIgnoreGroups.Location = new System.Drawing.Point(594, 334);
            this.textBoxIgnoreGroups.Multiline = true;
            this.textBoxIgnoreGroups.Name = "textBoxIgnoreGroups";
            this.textBoxIgnoreGroups.Size = new System.Drawing.Size(263, 157);
            this.textBoxIgnoreGroups.TabIndex = 29;
            // 
            // checkBoxShowLeerzeilen
            // 
            this.checkBoxShowLeerzeilen.AutoSize = true;
            this.checkBoxShowLeerzeilen.Location = new System.Drawing.Point(594, 497);
            this.checkBoxShowLeerzeilen.Name = "checkBoxShowLeerzeilen";
            this.checkBoxShowLeerzeilen.Size = new System.Drawing.Size(129, 17);
            this.checkBoxShowLeerzeilen.TabIndex = 31;
            this.checkBoxShowLeerzeilen.Text = "Leerzeilen einblenden";
            this.checkBoxShowLeerzeilen.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTextDocument
            // 
            this.buttonSaveTextDocument.Location = new System.Drawing.Point(755, 524);
            this.buttonSaveTextDocument.Name = "buttonSaveTextDocument";
            this.buttonSaveTextDocument.Size = new System.Drawing.Size(102, 23);
            this.buttonSaveTextDocument.TabIndex = 32;
            this.buttonSaveTextDocument.Text = "Speichern";
            this.buttonSaveTextDocument.UseVisualStyleBackColor = true;
            this.buttonSaveTextDocument.Click += new System.EventHandler(this.buttonSaveTextDocument_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 612);
            this.Controls.Add(this.buttonSaveTextDocument);
            this.Controls.Add(this.checkBoxShowLeerzeilen);
            this.Controls.Add(this.labelIgnoreGroups);
            this.Controls.Add(this.textBoxIgnoreGroups);
            this.Controls.Add(this.textBoxMinZeilenlaenge);
            this.Controls.Add(this.labelMinLength);
            this.Controls.Add(this.buttonGoDown);
            this.Controls.Add(this.buttonGoUp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxMarkierteLaenge);
            this.Controls.Add(this.labelPixelcount);
            this.Controls.Add(this.textBoxCritLaenge);
            this.Controls.Add(this.labelCritLength);
            this.Controls.Add(this.textBoxPixelBetween);
            this.Controls.Add(this.labelPixelBetween);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.labelTextdatei);
            this.Controls.Add(this.buttonAnzeigen);
            this.Controls.Add(this.buttonTable);
            this.Controls.Add(this.buttonTextdatei);
            this.Controls.Add(this.textBoxLaenge);
            this.Controls.Add(this.labelMaxLength);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VWF Helpertool";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelMaxLength;
        private System.Windows.Forms.TextBox textBoxLaenge;
        private System.Windows.Forms.Button buttonTextdatei;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.Label labelTextdatei;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.TextBox textBoxPixelBetween;
        private System.Windows.Forms.Label labelPixelBetween;
        private System.Windows.Forms.TextBox textBoxCritLaenge;
        private System.Windows.Forms.Label labelCritLength;
        private System.Windows.Forms.TextBox textBoxMarkierteLaenge;
        private System.Windows.Forms.Label labelPixelcount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektSpeichernUnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zusatzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button buttonGoUp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonGoDown;
        private System.Windows.Forms.TextBox textBoxMinZeilenlaenge;
        private System.Windows.Forms.Label labelMinLength;
        private System.Windows.Forms.Label labelIgnoreGroups;
        private System.Windows.Forms.TextBox textBoxIgnoreGroups;
        private System.Windows.Forms.CheckBox checkBoxShowLeerzeilen;
        private System.Windows.Forms.Button buttonSaveTextDocument;
    }
}

