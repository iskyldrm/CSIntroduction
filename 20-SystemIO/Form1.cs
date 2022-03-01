using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {

           System.IO.
            DriveInfo[] suruculer= DriveInfo.GetDrives();
            foreach (var item in suruculer)
            {
                lstDrive.Items.Add(item.Name);
                lstDrive.Items.Add(item.DriveType);
                lstDrive.Items.Add(item.TotalSize);
                lstDrive.Items.Add(item.TotalFreeSpace);
                lstDrive.Items.Add(item.AvailableFreeSpace);
                lstDrive.Items.Add(item.DriveFormat);
                lstDrive.Items.Add(item.RootDirectory);




            }

        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
             lstDrive.Items.Clear();
            string[] klasorler = Directory.GetDirectories(@"c:\");
            
            foreach (var item in klasorler)
            {
               
                lstDrive.Items.Add(item);
            }
        }

        private void lstDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDosyalar.Items.Clear();
              var klasor = lstDrive.SelectedItem.ToString();
            string[] dosyalar = Directory.GetFiles(klasor);
            foreach (var dosya in dosyalar)
            {
                lstDosyalar.Items.Add(dosya);
            }
        }
    }
}
