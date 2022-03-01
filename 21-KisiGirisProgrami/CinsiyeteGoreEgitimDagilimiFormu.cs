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
    public partial class CinsiyeteGoreEgitimDagilimiFormu : Form
    {
        CinsiyeteGoreEgitimDagilimi bayanDagilim =new CinsiyeteGoreEgitimDagilimi();
        CinsiyeteGoreEgitimDagilimi erkekDagilim= new CinsiyeteGoreEgitimDagilimi();

        List<CinsiyeteGoreEgitimDagilimi> dagilim = new List<CinsiyeteGoreEgitimDagilimi>();
        public CinsiyeteGoreEgitimDagilimiFormu()
        {
            InitializeComponent();
        }

        private void CinsiyeteGoreEgitimDagilimiFormu_Load(object sender, EventArgs e)
        {
            DosyaOku();
        }
        private void DosyaOku()
        {
            //İlkOkul
            //OrtaOkul
            //Lise
            //ÖnLisans
            //Lisans
            //YuksekLisans
            //Doktora

            //1;Ali;Veli;25.02.2022 18:35:44;E;ÖnLisans;100;Fizikçi;;;
            string[] kayitlar = File.ReadAllLines("Kisiler.txt");

            foreach (var kayit in kayitlar)
            {
                string[] data = kayit.Split(";");

               if (data[4] == "E")
                {
                    erkekDagilim.Cinsiyet = "Erkek";
                    switch (data[5])
                    {
                        case "İlkOkul":
                            erkekDagilim.ilkokul++;
                            break;
                        case "OrtaOkul":
                            erkekDagilim.ortaokul++;
                            break;
                        case "Lise":
                            erkekDagilim.lise++;
                            break;
                        case "ÖnLisans":
                            erkekDagilim.onlisans++;
                            break;
                        case "Lisans":
                            erkekDagilim.lisans++;
                            break;
                        case "YuksekLisans":
                            erkekDagilim.yukseklisans++;
                            break;
                        case "Doktora":
                            erkekDagilim.doktora++;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    bayanDagilim.Cinsiyet = "Bayan";
                    switch (data[5])
                    {
                        case "İlkOkul":
                            bayanDagilim.ilkokul++;
                            break;
                        case "OrtaOkul":
                            bayanDagilim.ortaokul++;
                            break;
                        case "Lise":
                            bayanDagilim.lise++;
                            break;
                        case "ÖnLisans":
                            bayanDagilim.onlisans++;
                            break;
                        case "Lisans":
                            bayanDagilim.lisans++;
                            break;
                        case "YuksekLisans":
                            bayanDagilim.yukseklisans++;
                            break;
                        case "Doktora":
                            bayanDagilim.doktora++;
                            break;
                        default:
                            break;
                    }
                }

            }
            erkekDagilim.Toplam = erkekDagilim.ilkokul + erkekDagilim.ortaokul + erkekDagilim.lise + erkekDagilim.onlisans + erkekDagilim.lisans + erkekDagilim.yukseklisans + erkekDagilim.doktora;

            bayanDagilim.Toplam = bayanDagilim.ilkokul + bayanDagilim.ortaokul + bayanDagilim.lise + bayanDagilim.onlisans + bayanDagilim.lisans + bayanDagilim.yukseklisans + bayanDagilim.doktora;

            dagilim.Add(erkekDagilim);
            dagilim.Add(bayanDagilim);
            dataGridView1.DataSource = dagilim;

        }
    }
}
