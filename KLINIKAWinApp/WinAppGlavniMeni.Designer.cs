namespace KLINIKAWinApp
{
    partial class WinAppGlavniMeni
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uposleniciTreeView = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pacijentiTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uposleniciToolStripMenuItem,
            this.ordinacijeToolStripMenuItem,
            this.pacijentiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uposleniciToolStripMenuItem
            // 
            this.uposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.uposleniciToolStripMenuItem.Name = "uposleniciToolStripMenuItem";
            this.uposleniciToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uposleniciToolStripMenuItem.Text = "Uposlenici";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.dodajToolStripMenuItem.Text = "Obrada";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.pretragaToolStripMenuItem.Text = "Pregled";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // ordinacijeToolStripMenuItem
            // 
            this.ordinacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem});
            this.ordinacijeToolStripMenuItem.Name = "ordinacijeToolStripMenuItem";
            this.ordinacijeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.ordinacijeToolStripMenuItem.Text = "Ordinacije";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listaToolStripMenuItem.Text = "Obrada";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2,
            this.pregledToolStripMenuItem1});
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.pretragaToolStripMenuItem2_Click);
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uposleniciTreeView);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 498);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uposlenici";
            // 
            // uposleniciTreeView
            // 
            this.uposleniciTreeView.Location = new System.Drawing.Point(6, 19);
            this.uposleniciTreeView.Name = "uposleniciTreeView";
            this.uposleniciTreeView.Size = new System.Drawing.Size(224, 473);
            this.uposleniciTreeView.TabIndex = 0;
            this.uposleniciTreeView.Enter += new System.EventHandler(this.refreshUposleniciView);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pacijentiTreeView);
            this.groupBox2.Location = new System.Drawing.Point(254, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 498);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacijenti";
            // 
            // pacijentiTreeView
            // 
            this.pacijentiTreeView.Location = new System.Drawing.Point(6, 19);
            this.pacijentiTreeView.Name = "pacijentiTreeView";
            this.pacijentiTreeView.Size = new System.Drawing.Size(310, 473);
            this.pacijentiTreeView.TabIndex = 0;
            // 
            // WinAppGlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WinAppGlavniMeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnaForma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinAppGlavniMeni_FormClosed);
            this.Load += new System.EventHandler(this.WinAppGlavniMeni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordinacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView uposleniciTreeView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView pacijentiTreeView;
    }
}