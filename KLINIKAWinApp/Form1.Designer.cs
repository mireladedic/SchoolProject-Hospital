namespace KLINIKAWinApp
{
    partial class Registracija
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
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.buttonPonisti = new System.Windows.Forms.Button();
            this.prijavaGroupBox1 = new System.Windows.Forms.GroupBox();
            this.prijavaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(3, 61);
            this.labelKorisnickoIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.labelKorisnickoIme.TabIndex = 0;
            this.labelKorisnickoIme.Text = "Korisnicko ime";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(3, 129);
            this.labelLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(44, 13);
            this.labelLozinka.TabIndex = 1;
            this.labelLozinka.Text = "Lozinka";
            this.labelLozinka.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(5, 93);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(189, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(5, 155);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(189, 20);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(40, 196);
            this.buttonPrijava.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(56, 27);
            this.buttonPrijava.TabIndex = 4;
            this.buttonPrijava.Text = "Prijavi se";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.Location = new System.Drawing.Point(137, 196);
            this.buttonPonisti.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(56, 27);
            this.buttonPonisti.TabIndex = 5;
            this.buttonPonisti.Text = "Ponisti";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            this.buttonPonisti.Click += new System.EventHandler(this.buttonPonisti_Click);
            // 
            // prijavaGroupBox1
            // 
            this.prijavaGroupBox1.Controls.Add(this.passTextBox);
            this.prijavaGroupBox1.Controls.Add(this.buttonPonisti);
            this.prijavaGroupBox1.Controls.Add(this.labelKorisnickoIme);
            this.prijavaGroupBox1.Controls.Add(this.buttonPrijava);
            this.prijavaGroupBox1.Controls.Add(this.labelLozinka);
            this.prijavaGroupBox1.Controls.Add(this.usernameTextBox);
            this.prijavaGroupBox1.Location = new System.Drawing.Point(283, 25);
            this.prijavaGroupBox1.Name = "prijavaGroupBox1";
            this.prijavaGroupBox1.Size = new System.Drawing.Size(214, 246);
            this.prijavaGroupBox1.TabIndex = 6;
            this.prijavaGroupBox1.TabStop = false;
            this.prijavaGroupBox1.Text = "Prijava";
            this.prijavaGroupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 323);
            this.Controls.Add(this.prijavaGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registracija";
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.prijavaGroupBox1.ResumeLayout(false);
            this.prijavaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.GroupBox prijavaGroupBox1;
    }
}

