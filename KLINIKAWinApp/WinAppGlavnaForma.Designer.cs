namespace KLINIKAWinApp
{
    partial class Prijava
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
            this.components = new System.ComponentModel.Container();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.buttonPonisti = new System.Windows.Forms.Button();
            this.prijavaGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.prijavaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(4, 64);
            this.labelKorisnickoIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.labelKorisnickoIme.TabIndex = 0;
            this.labelKorisnickoIme.Text = "Korisnicko ime";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(23, 97);
            this.labelLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(44, 13);
            this.labelLozinka.TabIndex = 1;
            this.labelLozinka.Text = "Lozinka";
            this.labelLozinka.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(83, 130);
            this.buttonPrijava.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(78, 27);
            this.buttonPrijava.TabIndex = 4;
            this.buttonPrijava.Text = "Prijavi se";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPonisti.Location = new System.Drawing.Point(165, 130);
            this.buttonPonisti.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(67, 27);
            this.buttonPonisti.TabIndex = 5;
            this.buttonPonisti.Text = "Ponisti";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            this.buttonPonisti.Click += new System.EventHandler(this.buttonPonisti_Click);
            // 
            // prijavaGroupBox
            // 
            this.prijavaGroupBox.Controls.Add(this.passwordTextBox);
            this.prijavaGroupBox.Controls.Add(this.usernameTextBox);
            this.prijavaGroupBox.Controls.Add(this.buttonPonisti);
            this.prijavaGroupBox.Controls.Add(this.labelKorisnickoIme);
            this.prijavaGroupBox.Controls.Add(this.buttonPrijava);
            this.prijavaGroupBox.Controls.Add(this.labelLozinka);
            this.prijavaGroupBox.Location = new System.Drawing.Point(11, 11);
            this.prijavaGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.prijavaGroupBox.Name = "prijavaGroupBox";
            this.prijavaGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.prijavaGroupBox.Size = new System.Drawing.Size(268, 199);
            this.prijavaGroupBox.TabIndex = 7;
            this.prijavaGroupBox.TabStop = false;
            this.prijavaGroupBox.Text = "Prijava";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(83, 97);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(149, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.passwordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox_Validating);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(83, 64);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(149, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prijava
            // 
            this.AcceptButton = this.buttonPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonPonisti;
            this.ClientSize = new System.Drawing.Size(589, 218);
            this.ControlBox = false;
            this.Controls.Add(this.prijavaGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.prijavaGroupBox.ResumeLayout(false);
            this.prijavaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.GroupBox prijavaGroupBox;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

