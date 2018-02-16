namespace KLINIKAWinApp
{
    partial class WinAppBolest
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
            this.BolestGroupBox = new System.Windows.Forms.GroupBox();
            this.ponistiBolestButton = new System.Windows.Forms.Button();
            this.dodajBolestButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BolestdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.vrijemeBolovanjaLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NazivBolestiLabel = new System.Windows.Forms.Label();
            this.BolestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BolestGroupBox
            // 
            this.BolestGroupBox.Controls.Add(this.ponistiBolestButton);
            this.BolestGroupBox.Controls.Add(this.dodajBolestButton);
            this.BolestGroupBox.Controls.Add(this.comboBox1);
            this.BolestGroupBox.Controls.Add(this.BolestdateTimePicker);
            this.BolestGroupBox.Controls.Add(this.label1);
            this.BolestGroupBox.Controls.Add(this.textBox3);
            this.BolestGroupBox.Controls.Add(this.OpisLabel);
            this.BolestGroupBox.Controls.Add(this.vrijemeBolovanjaLabel);
            this.BolestGroupBox.Controls.Add(this.textBox1);
            this.BolestGroupBox.Controls.Add(this.NazivBolestiLabel);
            this.BolestGroupBox.Location = new System.Drawing.Point(12, 12);
            this.BolestGroupBox.Name = "BolestGroupBox";
            this.BolestGroupBox.Size = new System.Drawing.Size(472, 258);
            this.BolestGroupBox.TabIndex = 0;
            this.BolestGroupBox.TabStop = false;
            this.BolestGroupBox.Text = "Bolest";
            // 
            // ponistiBolestButton
            // 
            this.ponistiBolestButton.Location = new System.Drawing.Point(333, 204);
            this.ponistiBolestButton.Name = "ponistiBolestButton";
            this.ponistiBolestButton.Size = new System.Drawing.Size(93, 29);
            this.ponistiBolestButton.TabIndex = 10;
            this.ponistiBolestButton.Text = "Ponisti";
            this.ponistiBolestButton.UseVisualStyleBackColor = true;
            this.ponistiBolestButton.Click += new System.EventHandler(this.ponistiBolestButton_Click);
            // 
            // dodajBolestButton
            // 
            this.dodajBolestButton.Location = new System.Drawing.Point(234, 204);
            this.dodajBolestButton.Name = "dodajBolestButton";
            this.dodajBolestButton.Size = new System.Drawing.Size(93, 29);
            this.dodajBolestButton.TabIndex = 9;
            this.dodajBolestButton.Text = "Dodaj";
            this.dodajBolestButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // BolestdateTimePicker
            // 
            this.BolestdateTimePicker.Location = new System.Drawing.Point(133, 78);
            this.BolestdateTimePicker.Name = "BolestdateTimePicker";
            this.BolestdateTimePicker.Size = new System.Drawing.Size(293, 22);
            this.BolestdateTimePicker.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vrsta Bolovanja";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(293, 22);
            this.textBox3.TabIndex = 5;
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(90, 120);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(37, 17);
            this.OpisLabel.TabIndex = 4;
            this.OpisLabel.Text = "Opis";
            // 
            // vrijemeBolovanjaLabel
            // 
            this.vrijemeBolovanjaLabel.AutoSize = true;
            this.vrijemeBolovanjaLabel.Location = new System.Drawing.Point(6, 78);
            this.vrijemeBolovanjaLabel.Name = "vrijemeBolovanjaLabel";
            this.vrijemeBolovanjaLabel.Size = new System.Drawing.Size(121, 17);
            this.vrijemeBolovanjaLabel.TabIndex = 2;
            this.vrijemeBolovanjaLabel.Text = "Vrijeme Bolovanja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 1;
            // 
            // NazivBolestiLabel
            // 
            this.NazivBolestiLabel.AutoSize = true;
            this.NazivBolestiLabel.Location = new System.Drawing.Point(84, 35);
            this.NazivBolestiLabel.Name = "NazivBolestiLabel";
            this.NazivBolestiLabel.Size = new System.Drawing.Size(43, 17);
            this.NazivBolestiLabel.TabIndex = 0;
            this.NazivBolestiLabel.Text = "Naziv";
            this.NazivBolestiLabel.Click += new System.EventHandler(this.NazivBolestiLabel_Click);
            // 
            // WinAppBolest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 283);
            this.Controls.Add(this.BolestGroupBox);
            this.Name = "WinAppBolest";
            this.Text = "WinAppBolest";
            this.Load += new System.EventHandler(this.WinAppBolest_Load);
            this.BolestGroupBox.ResumeLayout(false);
            this.BolestGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BolestGroupBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.Label vrijemeBolovanjaLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NazivBolestiLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker BolestdateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ponistiBolestButton;
        private System.Windows.Forms.Button dodajBolestButton;
    }
}