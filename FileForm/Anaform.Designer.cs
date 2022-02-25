
namespace FileForm
{
    partial class Anaform
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
            this.kişiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bizKimizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiİşlemleriToolStripMenuItem,
            this.hakkkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kişiİşlemleriToolStripMenuItem
            // 
            this.kişiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiEkleToolStripMenuItem,
            this.kişiBulToolStripMenuItem,
            this.kişiGüncelleToolStripMenuItem,
            this.kişiSilToolStripMenuItem,
            this.kişileriListeleToolStripMenuItem});
            this.kişiİşlemleriToolStripMenuItem.Name = "kişiİşlemleriToolStripMenuItem";
            this.kişiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kişiİşlemleriToolStripMenuItem.Text = "Kişi İşlemleri";
            // 
            // kişiEkleToolStripMenuItem
            // 
            this.kişiEkleToolStripMenuItem.Name = "kişiEkleToolStripMenuItem";
            this.kişiEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kişiEkleToolStripMenuItem.Text = "Kişi ekle";
            this.kişiEkleToolStripMenuItem.Click += new System.EventHandler(this.kişiEkleToolStripMenuItem_Click);
            // 
            // kişiBulToolStripMenuItem
            // 
            this.kişiBulToolStripMenuItem.Name = "kişiBulToolStripMenuItem";
            this.kişiBulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kişiBulToolStripMenuItem.Text = "Kişi Bul";
            // 
            // kişiGüncelleToolStripMenuItem
            // 
            this.kişiGüncelleToolStripMenuItem.Name = "kişiGüncelleToolStripMenuItem";
            this.kişiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kişiGüncelleToolStripMenuItem.Text = "Kişi güncelle";
            // 
            // kişiSilToolStripMenuItem
            // 
            this.kişiSilToolStripMenuItem.Name = "kişiSilToolStripMenuItem";
            this.kişiSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kişiSilToolStripMenuItem.Text = "Kişi sil";
            // 
            // hakkkımızdaToolStripMenuItem
            // 
            this.hakkkımızdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bizKimizToolStripMenuItem,
            this.versiyonToolStripMenuItem});
            this.hakkkımızdaToolStripMenuItem.Name = "hakkkımızdaToolStripMenuItem";
            this.hakkkımızdaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.hakkkımızdaToolStripMenuItem.Text = "Hakkkımızda";
            // 
            // bizKimizToolStripMenuItem
            // 
            this.bizKimizToolStripMenuItem.Name = "bizKimizToolStripMenuItem";
            this.bizKimizToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bizKimizToolStripMenuItem.Text = "biz kimiz";
            // 
            // versiyonToolStripMenuItem
            // 
            this.versiyonToolStripMenuItem.Name = "versiyonToolStripMenuItem";
            this.versiyonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versiyonToolStripMenuItem.Text = "versiyon";
            // 
            // kişileriListeleToolStripMenuItem
            // 
            this.kişileriListeleToolStripMenuItem.Name = "kişileriListeleToolStripMenuItem";
            this.kişileriListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kişileriListeleToolStripMenuItem.Text = "kişileri listele";
            this.kişileriListeleToolStripMenuItem.Click += new System.EventHandler(this.kişileriListeleToolStripMenuItem_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kişiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bizKimizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişileriListeleToolStripMenuItem;
    }
}