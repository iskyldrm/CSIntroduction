
namespace _17.HazirMetodlar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnstartwith = new System.Windows.Forms.Button();
            this.btnindexof = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtBlackList = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnBlackList = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnCharToArray = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDigit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGiris.Location = new System.Drawing.Point(12, 12);
            this.txtGiris.Multiline = true;
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(376, 70);
            this.txtGiris.TabIndex = 0;
            this.txtGiris.Text = resources.GetString("txtGiris.Text");
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompare.Location = new System.Drawing.Point(17, 212);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(376, 32);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare To";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnContains
            // 
            this.btnContains.BackColor = System.Drawing.Color.Maroon;
            this.btnContains.Location = new System.Drawing.Point(17, 250);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(376, 35);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = false;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnstartwith
            // 
            this.btnstartwith.BackColor = System.Drawing.Color.Yellow;
            this.btnstartwith.Location = new System.Drawing.Point(17, 291);
            this.btnstartwith.Name = "btnstartwith";
            this.btnstartwith.Size = new System.Drawing.Size(376, 35);
            this.btnstartwith.TabIndex = 3;
            this.btnstartwith.Text = "Start With";
            this.btnstartwith.UseVisualStyleBackColor = false;
            this.btnstartwith.Click += new System.EventHandler(this.btnstartwith_Click);
            // 
            // btnindexof
            // 
            this.btnindexof.BackColor = System.Drawing.Color.Fuchsia;
            this.btnindexof.Location = new System.Drawing.Point(17, 332);
            this.btnindexof.Name = "btnindexof";
            this.btnindexof.Size = new System.Drawing.Size(376, 35);
            this.btnindexof.TabIndex = 4;
            this.btnindexof.Text = "İndexof";
            this.btnindexof.UseVisualStyleBackColor = false;
            this.btnindexof.Click += new System.EventHandler(this.btnindexof_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.BlueViolet;
            this.btnRemove.Location = new System.Drawing.Point(17, 373);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(376, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.HotPink;
            this.btnReplace.Location = new System.Drawing.Point(17, 414);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(376, 35);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtBlackList
            // 
            this.txtBlackList.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBlackList.Location = new System.Drawing.Point(12, 88);
            this.txtBlackList.Multiline = true;
            this.txtBlackList.Name = "txtBlackList";
            this.txtBlackList.Size = new System.Drawing.Size(376, 70);
            this.txtBlackList.TabIndex = 7;
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSplit.Location = new System.Drawing.Point(17, 455);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(376, 35);
            this.btnSplit.TabIndex = 8;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnBlackList
            // 
            this.btnBlackList.BackColor = System.Drawing.Color.Aqua;
            this.btnBlackList.Location = new System.Drawing.Point(17, 496);
            this.btnBlackList.Name = "btnBlackList";
            this.btnBlackList.Size = new System.Drawing.Size(376, 35);
            this.btnBlackList.TabIndex = 9;
            this.btnBlackList.Text = "Black List Kontrol";
            this.btnBlackList.UseVisualStyleBackColor = false;
            this.btnBlackList.Click += new System.EventHandler(this.btnBlackList_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubstring.Location = new System.Drawing.Point(17, 537);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(376, 35);
            this.btnSubstring.TabIndex = 10;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = false;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrim.Location = new System.Drawing.Point(12, 578);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(376, 35);
            this.btnTrim.TabIndex = 11;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = false;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnCharToArray
            // 
            this.btnCharToArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCharToArray.Location = new System.Drawing.Point(12, 619);
            this.btnCharToArray.Name = "btnCharToArray";
            this.btnCharToArray.Size = new System.Drawing.Size(376, 35);
            this.btnCharToArray.TabIndex = 12;
            this.btnCharToArray.Text = "ChartoArray";
            this.btnCharToArray.UseVisualStyleBackColor = false;
            this.btnCharToArray.Click += new System.EventHandler(this.btnCharToArray_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(420, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(49, 680);
            this.listBox1.TabIndex = 13;
            // 
            // btnDigit
            // 
            this.btnDigit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDigit.Location = new System.Drawing.Point(12, 660);
            this.btnDigit.Name = "btnDigit";
            this.btnDigit.Size = new System.Drawing.Size(376, 35);
            this.btnDigit.TabIndex = 14;
            this.btnDigit.Text = "digit";
            this.btnDigit.UseVisualStyleBackColor = false;
            this.btnDigit.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 736);
            this.Controls.Add(this.btnDigit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCharToArray);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnBlackList);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtBlackList);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnindexof);
            this.Controls.Add(this.btnstartwith);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnstartwith;
        private System.Windows.Forms.Button btnindexof;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtBlackList;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnBlackList;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnCharToArray;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDigit;
    }
}

