
namespace OkulYonetim2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDers = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDers,
            this.menuPersonel,
            this.menuOgrenci});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDers
            // 
            this.menuDers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.menuDers.Name = "menuDers";
            this.menuDers.Size = new System.Drawing.Size(42, 20);
            this.menuDers.Text = "Ders";
            // 
            // girisToolStripMenuItem
            // 
            this.girisToolStripMenuItem.Name = "girisToolStripMenuItem";
            this.girisToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.girisToolStripMenuItem.Text = "Giriş";
            this.girisToolStripMenuItem.Click += new System.EventHandler(this.girisToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // menuPersonel
            // 
            this.menuPersonel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem1,
            this.listeToolStripMenuItem1});
            this.menuPersonel.Name = "menuPersonel";
            this.menuPersonel.Size = new System.Drawing.Size(64, 20);
            this.menuPersonel.Text = "Personel";
            // 
            // girisToolStripMenuItem1
            // 
            this.girisToolStripMenuItem1.Name = "girisToolStripMenuItem1";
            this.girisToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.girisToolStripMenuItem1.Text = "Giriş";
            this.girisToolStripMenuItem1.Click += new System.EventHandler(this.girisToolStripMenuItem1_Click);
            // 
            // listeToolStripMenuItem1
            // 
            this.listeToolStripMenuItem1.Name = "listeToolStripMenuItem1";
            this.listeToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem1.Text = "Liste";
            this.listeToolStripMenuItem1.Click += new System.EventHandler(this.listeToolStripMenuItem1_Click);
            // 
            // menuOgrenci
            // 
            this.menuOgrenci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem2,
            this.listeToolStripMenuItem2});
            this.menuOgrenci.Name = "menuOgrenci";
            this.menuOgrenci.Size = new System.Drawing.Size(61, 20);
            this.menuOgrenci.Text = "Öğrenci";
            // 
            // girisToolStripMenuItem2
            // 
            this.girisToolStripMenuItem2.Name = "girisToolStripMenuItem2";
            this.girisToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.girisToolStripMenuItem2.Text = "Giriş";
            this.girisToolStripMenuItem2.Click += new System.EventHandler(this.girisToolStripMenuItem2_Click);
            // 
            // listeToolStripMenuItem2
            // 
            this.listeToolStripMenuItem2.Name = "listeToolStripMenuItem2";
            this.listeToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem2.Text = "Liste";
            this.listeToolStripMenuItem2.Click += new System.EventHandler(this.listeToolStripMenuItem2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 406);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDers;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPersonel;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuOgrenci;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem2;
    }
}

