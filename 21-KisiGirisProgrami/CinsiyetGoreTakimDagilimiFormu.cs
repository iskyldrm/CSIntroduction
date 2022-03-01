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

namespace _21_KisiGirisProgrami
{
    public partial class CinsiyetGoreTakimDagilimiFormu : Form
    {

        CinsiyeteGoreTakim bayanTakim = new CinsiyeteGoreTakim();
        CinsiyeteGoreTakim erkekTakim = new CinsiyeteGoreTakim();

        List<CinsiyeteGoreTakim> takimDagilim = new List<CinsiyeteGoreTakim>();
        public CinsiyetGoreTakimDagilimiFormu()
        {
            InitializeComponent();
        }

        private void CinsiyetGoreTakimDagilimiFormu_Load(object sender, EventArgs e)
        {
            DosyaOku();
        }
        private void DosyaOku()
        {
            //Beşiktaş
            //Fenerbahçe
            //Galatasaray
            //Trabzonspor

            //1;Ali;Veli;25.02.2022 18:35:44;E;ÖnLisans;100;Fizikçi;;;
            string[] kayitlar = File.ReadAllLines("Kisiler.txt");

            foreach (var kayit in kayitlar)
            {
                string[] data = kayit.Split(";");

                if (data[4] == "E")
                {
                    erkekTakim.Cinsiyet = "Erkek";
                    switch (data[9])
                    {
                        case "Beşiktaş":
                            erkekTakim.Besiktas++;
                            break;
                        case "Fenerbahçe":
                            erkekTakim.Fenerbahce++;
                            break;
                        case "Galatasaray":
                            erkekTakim.Galatasaray++;
                            break;
                        case "Trabzonspor":
                            erkekTakim.TrabzonSpor++;
                            break;
                       default:
                            break;
                    }
                }
                else
                {
                    bayanTakim.Cinsiyet = "Bayan";
                    switch(data[9])
                    {
                        case "Beşiktaş":
                            bayanTakim.Besiktas++;
                        break;
                        case "Fenerbahçe":
                            bayanTakim.Fenerbahce++;
                        break;
                        case "Galatasaray":
                            bayanTakim.Galatasaray++;
                        break;
                        case "Trabzonspor":
                            bayanTakim.TrabzonSpor++;
                        break;
                        default:
                            break;
                    }
                }

            }

            takimDagilim.Add(bayanTakim);
            takimDagilim.Add(erkekTakim);
            dataGridView1.DataSource = takimDagilim;
        }
    }
}
