namespace VWFCalc
{
    partial class KonfigDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelMinText = new System.Windows.Forms.Panel();
            this.labelMinLengthConf = new System.Windows.Forms.Label();
            this.panelBackcolor = new System.Windows.Forms.Panel();
            this.panelUeberlangText = new System.Windows.Forms.Panel();
            this.labelUeberlangText = new System.Windows.Forms.Label();
            this.panelCritText = new System.Windows.Forms.Panel();
            this.panelNormalText = new System.Windows.Forms.Panel();
            this.labelBackcolor = new System.Windows.Forms.Label();
            this.labelCritText = new System.Windows.Forms.Label();
            this.labelNormalText = new System.Windows.Forms.Label();
            this.labelSprache = new System.Windows.Forms.Label();
            this.comboBoxSprache = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxSonstiges = new System.Windows.Forms.GroupBox();
            this.textBoxIgnorechars = new System.Windows.Forms.TextBox();
            this.labelIgnoreChars = new System.Windows.Forms.Label();
            this.checkBoxIgnoreSpace = new System.Windows.Forms.CheckBox();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxSonstiges.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelMinText);
            this.groupBoxColors.Controls.Add(this.labelMinLengthConf);
            this.groupBoxColors.Controls.Add(this.panelBackcolor);
            this.groupBoxColors.Controls.Add(this.panelUeberlangText);
            this.groupBoxColors.Controls.Add(this.labelUeberlangText);
            this.groupBoxColors.Controls.Add(this.panelCritText);
            this.groupBoxColors.Controls.Add(this.panelNormalText);
            this.groupBoxColors.Controls.Add(this.labelBackcolor);
            this.groupBoxColors.Controls.Add(this.labelCritText);
            this.groupBoxColors.Controls.Add(this.labelNormalText);
            this.groupBoxColors.Location = new System.Drawing.Point(12, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(229, 160);
            this.groupBoxColors.TabIndex = 0;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Farben";
            // 
            // panelMinText
            // 
            this.panelMinText.Location = new System.Drawing.Point(169, 100);
            this.panelMinText.Name = "panelMinText";
            this.panelMinText.Size = new System.Drawing.Size(30, 20);
            this.panelMinText.TabIndex = 4;
            this.panelMinText.Click += new System.EventHandler(this.panelMinText_Click);
            // 
            // labelMinLengthConf
            // 
            this.labelMinLengthConf.AutoSize = true;
            this.labelMinLengthConf.Location = new System.Drawing.Point(15, 105);
            this.labelMinLengthConf.Name = "labelMinLengthConf";
            this.labelMinLengthConf.Size = new System.Drawing.Size(110, 13);
            this.labelMinLengthConf.TabIndex = 5;
            this.labelMinLengthConf.Text = "Textfarbe Unterlänge:";
            // 
            // panelBackcolor
            // 
            this.panelBackcolor.Location = new System.Drawing.Point(169, 125);
            this.panelBackcolor.Name = "panelBackcolor";
            this.panelBackcolor.Size = new System.Drawing.Size(30, 20);
            this.panelBackcolor.TabIndex = 2;
            this.panelBackcolor.Click += new System.EventHandler(this.panelBackcolor_Click);
            // 
            // panelUeberlangText
            // 
            this.panelUeberlangText.Location = new System.Drawing.Point(169, 50);
            this.panelUeberlangText.Name = "panelUeberlangText";
            this.panelUeberlangText.Size = new System.Drawing.Size(30, 20);
            this.panelUeberlangText.TabIndex = 2;
            this.panelUeberlangText.Click += new System.EventHandler(this.panelUeberlangText_Click);
            // 
            // labelUeberlangText
            // 
            this.labelUeberlangText.AutoSize = true;
            this.labelUeberlangText.Location = new System.Drawing.Point(15, 55);
            this.labelUeberlangText.Name = "labelUeberlangText";
            this.labelUeberlangText.Size = new System.Drawing.Size(104, 13);
            this.labelUeberlangText.TabIndex = 2;
            this.labelUeberlangText.Text = "Textfarbe Überlänge";
            // 
            // panelCritText
            // 
            this.panelCritText.Location = new System.Drawing.Point(169, 75);
            this.panelCritText.Name = "panelCritText";
            this.panelCritText.Size = new System.Drawing.Size(30, 20);
            this.panelCritText.TabIndex = 2;
            this.panelCritText.Click += new System.EventHandler(this.panelCritText_Click);
            // 
            // panelNormalText
            // 
            this.panelNormalText.Location = new System.Drawing.Point(169, 25);
            this.panelNormalText.Name = "panelNormalText";
            this.panelNormalText.Size = new System.Drawing.Size(30, 20);
            this.panelNormalText.TabIndex = 1;
            this.panelNormalText.Click += new System.EventHandler(this.panelNormalText_Click);
            // 
            // labelBackcolor
            // 
            this.labelBackcolor.AutoSize = true;
            this.labelBackcolor.Location = new System.Drawing.Point(15, 130);
            this.labelBackcolor.Name = "labelBackcolor";
            this.labelBackcolor.Size = new System.Drawing.Size(127, 13);
            this.labelBackcolor.TabIndex = 3;
            this.labelBackcolor.Text = "Hintergrundfarbe Textfeld";
            // 
            // labelCritText
            // 
            this.labelCritText.AutoSize = true;
            this.labelCritText.Location = new System.Drawing.Point(15, 80);
            this.labelCritText.Name = "labelCritText";
            this.labelCritText.Size = new System.Drawing.Size(127, 13);
            this.labelCritText.TabIndex = 1;
            this.labelCritText.Text = "Textfarbe kritische Länge";
            // 
            // labelNormalText
            // 
            this.labelNormalText.AutoSize = true;
            this.labelNormalText.Location = new System.Drawing.Point(15, 30);
            this.labelNormalText.Name = "labelNormalText";
            this.labelNormalText.Size = new System.Drawing.Size(119, 13);
            this.labelNormalText.TabIndex = 0;
            this.labelNormalText.Text = "Textfarbe normaler Text";
            // 
            // labelSprache
            // 
            this.labelSprache.AutoSize = true;
            this.labelSprache.Location = new System.Drawing.Point(15, 127);
            this.labelSprache.Name = "labelSprache";
            this.labelSprache.Size = new System.Drawing.Size(47, 13);
            this.labelSprache.TabIndex = 1;
            this.labelSprache.Text = "Sprache";
            // 
            // comboBoxSprache
            // 
            this.comboBoxSprache.FormattingEnabled = true;
            this.comboBoxSprache.Items.AddRange(new object[] {
            "Deutsch",
            "English"});
            this.comboBoxSprache.Location = new System.Drawing.Point(68, 122);
            this.comboBoxSprache.Name = "comboBoxSprache";
            this.comboBoxSprache.Size = new System.Drawing.Size(146, 21);
            this.comboBoxSprache.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(401, 197);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(320, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxSonstiges
            // 
            this.groupBoxSonstiges.Controls.Add(this.textBoxIgnorechars);
            this.groupBoxSonstiges.Controls.Add(this.labelIgnoreChars);
            this.groupBoxSonstiges.Controls.Add(this.checkBoxIgnoreSpace);
            this.groupBoxSonstiges.Controls.Add(this.comboBoxSprache);
            this.groupBoxSonstiges.Controls.Add(this.labelSprache);
            this.groupBoxSonstiges.Location = new System.Drawing.Point(247, 17);
            this.groupBoxSonstiges.Name = "groupBoxSonstiges";
            this.groupBoxSonstiges.Size = new System.Drawing.Size(229, 155);
            this.groupBoxSonstiges.TabIndex = 5;
            this.groupBoxSonstiges.TabStop = false;
            this.groupBoxSonstiges.Text = "Sonstiges";
            // 
            // textBoxIgnorechars
            // 
            this.textBoxIgnorechars.Location = new System.Drawing.Point(18, 81);
            this.textBoxIgnorechars.Name = "textBoxIgnorechars";
            this.textBoxIgnorechars.Size = new System.Drawing.Size(196, 20);
            this.textBoxIgnorechars.TabIndex = 3;
            // 
            // labelIgnoreChars
            // 
            this.labelIgnoreChars.AutoSize = true;
            this.labelIgnoreChars.Location = new System.Drawing.Point(15, 65);
            this.labelIgnoreChars.Name = "labelIgnoreChars";
            this.labelIgnoreChars.Size = new System.Drawing.Size(155, 13);
            this.labelIgnoreChars.TabIndex = 2;
            this.labelIgnoreChars.Text = "Zu ignorierende Zeilenanfänge:";
            // 
            // checkBoxIgnoreSpace
            // 
            this.checkBoxIgnoreSpace.AutoSize = true;
            this.checkBoxIgnoreSpace.Location = new System.Drawing.Point(18, 30);
            this.checkBoxIgnoreSpace.Name = "checkBoxIgnoreSpace";
            this.checkBoxIgnoreSpace.Size = new System.Drawing.Size(199, 17);
            this.checkBoxIgnoreSpace.TabIndex = 1;
            this.checkBoxIgnoreSpace.Text = "Ignoriere Leerzeichen an Zeilenende";
            this.checkBoxIgnoreSpace.UseVisualStyleBackColor = true;
            // 
            // KonfigDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 235);
            this.Controls.Add(this.groupBoxSonstiges);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KonfigDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfiguration";
            this.Shown += new System.EventHandler(this.KonfigDlg_Shown);
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.groupBoxSonstiges.ResumeLayout(false);
            this.groupBoxSonstiges.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelUeberlangText;
        private System.Windows.Forms.Label labelCritText;
        private System.Windows.Forms.Label labelNormalText;
        private System.Windows.Forms.Label labelBackcolor;
        private System.Windows.Forms.Panel panelBackcolor;
        private System.Windows.Forms.Panel panelUeberlangText;
        private System.Windows.Forms.Panel panelCritText;
        private System.Windows.Forms.Panel panelNormalText;
        private System.Windows.Forms.Label labelSprache;
        private System.Windows.Forms.ComboBox comboBoxSprache;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxSonstiges;
        private System.Windows.Forms.CheckBox checkBoxIgnoreSpace;
        private System.Windows.Forms.TextBox textBoxIgnorechars;
        private System.Windows.Forms.Label labelIgnoreChars;
        private System.Windows.Forms.Panel panelMinText;
        private System.Windows.Forms.Label labelMinLengthConf;
    }
}