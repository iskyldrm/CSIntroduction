using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace _19_RunTimeController
{
    
    public partial class Form1 : Form
    {
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Pcb_Click(object sender, EventArgs e)
        {
            //sender o andaki tiklanan nesneyi verir

            PictureBox tiklananBox = (PictureBox)sender;
            if ((bool)tiklananBox.Tag == true)
            {
                //MessageBox.Show(tiklananBox.Name);
                tiklananBox.BackColor = Color.Red;
                MessageBox.Show("Mayin Patladi");
                var result = MessageBox.Show("Mayin Patladi Devam Edecekmisiniz ? ", "Devam mi",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.Yes)
                    Setup();

            }
            else
            {
                tiklananBox.BackColor = Color.Green;
                

            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Setup();
        }
        public void Setup()
        {
            flp1.Controls.Clear();
            Random rnd = new Random();
            List<int> mayinlar = new List<int>();
            sayac = 0;
            for (int i = 0; i < 30; i++)
            {
                //Tekil mayin olusumu 
                int mayin = rnd.Next(0, 157);
                if (!mayinlar.Contains(mayin))
                    mayinlar.Add(mayin);
                else
                    i--;
            }



            for (int i = 0; i < 156; i++)
            {
                PictureBox box = new PictureBox();
                box.Name = "pcb" + i;
                box.Width = 30;
                box.Height = 30;
                box.Margin = new Padding(1); // Diş kenar bosluklari
                box.BackColor = Color.LightGray;

                //box.Tag = true;
                if (mayinlar.Contains(i))
                    box.Tag = true;
                else
                    box.Tag = false;

                // picture box 'lara tiklandigindaki event'i tanimlamak gerekli.

                box.Click += Pcb_Click;
                box.Click += DigerEvent;




                flp1.Controls.Add(box);
            }
        }
        public void DigerEvent(object sender, EventArgs e)
        {
            sayac++;
            this.Text = "Tiklanma Sayisi:" + sayac;
        }
    }
}
