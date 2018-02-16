namespace KLINIKAWinApp
{
    partial class WinAppTerapija
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
            this.terapijagGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vrstaTerapijeLabel = new System.Windows.Forms.Label();
            this.garancijaGroupBox = new System.Windows.Forms.GroupBox();
            this.daRadioButton = new System.Windows.Forms.RadioButton();
            this.neRadioButton = new System.Windows.Forms.RadioButton();
            this.datumPropisivanjaTerapijeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.blokiranaTerapijaGroupBox = new System.Windows.Forms.GroupBox();
            this.daBlokRadioButton = new System.Windows.Forms.RadioButton();
            this.neBlokRadioButton = new System.Windows.Forms.RadioButton();
            this.dodajTerapijuButton = new System.Windows.Forms.Button();
            this.ponistiTerapijuButton = new System.Windows.Forms.Button();
            this.terapijagGroupBox.SuspendLayout();
            this.garancijaGroupBox.SuspendLayout();
            this.blokiranaTerapijaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // terapijagGroupBox
            // 
            this.terapijagGroupBox.Controls.Add(this.ponistiTerapijuButton);
            this.terapijagGroupBox.Controls.Add(this.dodajTerapijuButton);
            this.terapijagGroupBox.Controls.Add(this.blokiranaTerapijaGroupBox);
            this.terapijagGroupBox.Controls.Add(this.dateTimePicker1);
            this.terapijagGroupBox.Controls.Add(this.datumPropisivanjaTerapijeLabel);
            this.terapijagGroupBox.Controls.Add(this.garancijaGroupBox);
            this.terapijagGroupBox.Controls.Add(this.comboBox1);
            this.terapijagGroupBox.Controls.Add(this.vrstaTerapijeLabel);
            this.terapijagGroupBox.Location = new System.Drawing.Point(12, 12);
            this.terapijagGroupBox.Name = "terapijagGroupBox";
            this.terapijagGroupBox.Size = new System.Drawing.Size(427, 351);
            this.terapijagGroupBox.TabIndex = 0;
            this.terapijagGroupBox.TabStop = false;
            this.terapijagGroupBox.Text = "Terapija";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // vrstaTerapijeLabel
            // 
            this.vrstaTerapijeLabel.AutoSize = true;
            this.vrstaTerapijeLabel.Location = new System.Drawing.Point(17, 42);
            this.vrstaTerapijeLabel.Name = "vrstaTerapijeLabel";
            this.vrstaTerapijeLabel.Size = new System.Drawing.Size(41, 17);
            this.vrstaTerapijeLabel.TabIndex = 0;
            this.vrstaTerapijeLabel.Text = "Vrsta";
            // 
            // garancijaGroupBox
            // 
            this.garancijaGroupBox.Controls.Add(this.neRadioButton);
            this.garancijaGroupBox.Controls.Add(this.daRadioButton);
            this.garancijaGroupBox.Location = new System.Drawing.Point(20, 81);
            this.garancijaGroupBox.Name = "garancijaGroupBox";
            this.garancijaGroupBox.Size = new System.Drawing.Size(331, 64);
            this.garancijaGroupBox.TabIndex = 2;
            this.garancijaGroupBox.TabStop = false;
            this.garancijaGroupBox.Text = "Garancija";
            // 
            // daRadioButton
            // 
            this.daRadioButton.AutoSize = true;
            this.daRadioButton.Location = new System.Drawing.Point(95, 21);
            this.daRadioButton.Name = "daRadioButton";
            this.daRadioButton.Size = new System.Drawing.Size(48, 21);
            this.daRadioButton.TabIndex = 0;
            this.daRadioButton.TabStop = true;
            this.daRadioButton.Text = "DA";
            this.daRadioButton.UseVisualStyleBackColor = true;
            // 
            // neRadioButton
            // 
            this.neRadioButton.AutoSize = true;
            this.neRadioButton.Location = new System.Drawing.Point(183, 21);
            this.neRadioButton.Name = "neRadioButton";
            this.neRadioButton.Size = new System.Drawing.Size(48, 21);
            this.neRadioButton.TabIndex = 1;
            this.neRadioButton.TabStop = true;
            this.neRadioButton.Text = "NE";
            this.neRadioButton.UseVisualStyleBackColor = true;
            // 
            // datumPropisivanjaTerapijeLabel
            // 
            this.datumPropisivanjaTerapijeLabel.AutoSize = true;
            this.datumPropisivanjaTerapijeLabel.Location = new System.Drawing.Point(17, 162);
            this.datumPropisivanjaTerapijeLabel.Name = "datumPropisivanjaTerapijeLabel";
            this.datumPropisivanjaTerapijeLabel.Size = new System.Drawing.Size(130, 17);
            this.datumPropisivanjaTerapijeLabel.TabIndex = 3;
            this.datumPropisivanjaTerapijeLabel.Text = "Datum Propisivanja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // blokiranaTerapijaGroupBox
            // 
            this.blokiranaTerapijaGroupBox.Controls.Add(this.neBlokRadioButton);
            this.blokiranaTerapijaGroupBox.Controls.Add(this.daBlokRadioButton);
            this.blokiranaTerapijaGroupBox.Location = new System.Drawing.Point(20, 204);
            this.blokiranaTerapijaGroupBox.Name = "blokiranaTerapijaGroupBox";
            this.blokiranaTerapijaGroupBox.Size = new System.Drawing.Size(331, 71);
            this.blokiranaTerapijaGroupBox.TabIndex = 5;
            this.blokiranaTerapijaGroupBox.TabStop = false;
            this.blokiranaTerapijaGroupBox.Text = "Blokirana";
            // 
            // daBlokRadioButton
            // 
            this.daBlokRadioButton.AutoSize = true;
            this.daBlokRadioButton.Location = new System.Drawing.Point(95, 21);
            this.daBlokRadioButton.Name = "daBlokRadioButton";
            this.daBlokRadioButton.Size = new System.Drawing.Size(48, 21);
            this.daBlokRadioButton.TabIndex = 1;
            this.daBlokRadioButton.TabStop = true;
            this.daBlokRadioButton.Text = "DA";
            this.daBlokRadioButton.UseVisualStyleBackColor = true;
            // 
            // neBlokRadioButton
            // 
            this.neBlokRadioButton.AutoSize = true;
            this.neBlokRadioButton.Location = new System.Drawing.Point(183, 21);
            this.neBlokRadioButton.Name = "neBlokRadioButton";
            this.neBlokRadioButton.Size = new System.Drawing.Size(48, 21);
            this.neBlokRadioButton.TabIndex = 2;
            this.neBlokRadioButton.TabStop = true;
            this.neBlokRadioButton.Text = "NE";
            this.neBlokRadioButton.UseVisualStyleBackColor = true;
            // 
            // dodajTerapijuButton
            // 
            this.dodajTerapijuButton.Location = new System.Drawing.Point(162, 297);
            this.dodajTerapijuButton.Name = "dodajTerapijuButton";
            this.dodajTerapijuButton.Size = new System.Drawing.Size(89, 34);
            this.dodajTerapijuButton.TabIndex = 6;
            this.dodajTerapijuButton.Text = "Dodaj";
            this.dodajTerapijuButton.UseVisualStyleBackColor = true;
            // 
            // ponistiTerapijuButton
            // 
            this.ponistiTerapijuButton.Location = new System.Drawing.Point(268, 297);
            this.ponistiTerapijuButton.Name = "ponistiTerapijuButton";
            this.ponistiTerapijuButton.Size = new System.Drawing.Size(83, 34);
            this.ponistiTerapijuButton.TabIndex = 7;
            this.ponistiTerapijuButton.Text = "Ponisti";
            this.ponistiTerapijuButton.UseVisualStyleBackColor = true;
            // 
            // WinAppTerapija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 394);
            this.Controls.Add(this.terapijagGroupBox);
            this.Name = "WinAppTerapija";
            this.Text = "WinAppTerapija";
            this.terapijagGroupBox.ResumeLayout(false);
            this.terapijagGroupBox.PerformLayout();
            this.garancijaGroupBox.ResumeLayout(false);
            this.garancijaGroupBox.PerformLayout();
            this.blokiranaTerapijaGroupBox.ResumeLayout(false);
            this.blokiranaTerapijaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox terapijagGroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label vrstaTerapijeLabel;
        private System.Windows.Forms.GroupBox blokiranaTerapijaGroupBox;
        private System.Windows.Forms.RadioButton neBlokRadioButton;
        private System.Windows.Forms.RadioButton daBlokRadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label datumPropisivanjaTerapijeLabel;
        private System.Windows.Forms.GroupBox garancijaGroupBox;
        private System.Windows.Forms.RadioButton neRadioButton;
        private System.Windows.Forms.RadioButton daRadioButton;
        private System.Windows.Forms.Button ponistiTerapijuButton;
        private System.Windows.Forms.Button dodajTerapijuButton;
    }
}