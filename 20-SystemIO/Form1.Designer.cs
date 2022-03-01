
namespace _20_SystemIO
{
    partial class Form1
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
            this.btnDriver = new System.Windows.Forms.Button();
            this.lstDrive = new System.Windows.Forms.ListBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.lstDosyalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDriver
            // 
            this.btnDriver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDriver.Location = new System.Drawing.Point(12, 12);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(162, 58);
            this.btnDriver.TabIndex = 0;
            this.btnDriver.Text = "Driver Info";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // lstDrive
            // 
            this.lstDrive.FormattingEnabled = true;
            this.lstDrive.ItemHeight = 20;
            this.lstDrive.Location = new System.Drawing.Point(203, 13);
            this.lstDrive.Name = "lstDrive";
            this.lstDrive.Size = new System.Drawing.Size(219, 464);
            this.lstDrive.TabIndex = 1;
            this.lstDrive.SelectedIndexChanged += new System.EventHandler(this.lstDrive_SelectedIndexChanged);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDirectory.Location = new System.Drawing.Point(12, 76);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(162, 58);
            this.btnDirectory.TabIndex = 2;
            this.btnDirectory.Text = "Directory Info";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // lstDosyalar
            // 
            this.lstDosyalar.FormattingEnabled = true;
            this.lstDosyalar.ItemHeight = 20;
            this.lstDosyalar.Location = new System.Drawing.Point(439, 13);
            this.lstDosyalar.Name = "lstDosyalar";
            this.lstDosyalar.Size = new System.Drawing.Size(246, 464);
            this.lstDosyalar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 495);
            this.Controls.Add(this.lstDosyalar);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.lstDrive);
            this.Controls.Add(this.btnDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.ListBox lstDrive;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.ListBox lstDosyalar;
    }
}

