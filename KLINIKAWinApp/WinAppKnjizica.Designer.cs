namespace KLINIKAWinApp
{
    partial class WinAppKnjizica
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
            this.knjizicaGroupBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.datumKnjizicaLabel = new System.Windows.Forms.Label();
            this.vaziKnjizicaLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.knjizicaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // knjizicaGroupBox
            // 
            this.knjizicaGroupBox.Controls.Add(this.dateTimePicker2);
            this.knjizicaGroupBox.Controls.Add(this.dateTimePicker1);
            this.knjizicaGroupBox.Controls.Add(this.maskedTextBox1);
            this.knjizicaGroupBox.Controls.Add(this.vaziKnjizicaLabel);
            this.knjizicaGroupBox.Controls.Add(this.datumKnjizicaLabel);
            this.knjizicaGroupBox.Controls.Add(this.idLabel);
            this.knjizicaGroupBox.Location = new System.Drawing.Point(13, 13);
            this.knjizicaGroupBox.Name = "knjizicaGroupBox";
            this.knjizicaGroupBox.Size = new System.Drawing.Size(360, 149);
            this.knjizicaGroupBox.TabIndex = 0;
            this.knjizicaGroupBox.TabStop = false;
            this.knjizicaGroupBox.Text = "Knjizica";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(94, 44);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 17);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ld_";
            // 
            // datumKnjizicaLabel
            // 
            this.datumKnjizicaLabel.AutoSize = true;
            this.datumKnjizicaLabel.Location = new System.Drawing.Point(6, 73);
            this.datumKnjizicaLabel.Name = "datumKnjizicaLabel";
            this.datumKnjizicaLabel.Size = new System.Drawing.Size(115, 17);
            this.datumKnjizicaLabel.TabIndex = 1;
            this.datumKnjizicaLabel.Text = "datum_izdavanja";
            // 
            // vaziKnjizicaLabel
            // 
            this.vaziKnjizicaLabel.AutoSize = true;
            this.vaziKnjizicaLabel.Location = new System.Drawing.Point(33, 105);
            this.vaziKnjizicaLabel.Name = "vaziKnjizicaLabel";
            this.vaziKnjizicaLabel.Size = new System.Drawing.Size(88, 17);
            this.vaziKnjizicaLabel.TabIndex = 2;
            this.vaziKnjizicaLabel.Text = "do_kad_vazi";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(128, 44);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(201, 22);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(128, 102);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // WinAppKnjizica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 176);
            this.Controls.Add(this.knjizicaGroupBox);
            this.Name = "WinAppKnjizica";
            this.Text = "WinAppKnjizica";
            this.knjizicaGroupBox.ResumeLayout(false);
            this.knjizicaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox knjizicaGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label vaziKnjizicaLabel;
        private System.Windows.Forms.Label datumKnjizicaLabel;
        private System.Windows.Forms.Label idLabel;
    }
}