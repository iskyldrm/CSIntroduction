using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_KisiGirisProgrami
{
    public struct  CinsiyeteGoreEgitimDagilimi
    {
        //public int CinsiyetSayisi { get; set; }
        //public int  KadinSayisi { get; set; }
        public string Cinsiyet { get; set; }
        public int ilkokul { get; set; }

        public int ortaokul { get; set; }
        public int lise { get; set; }
        public int onlisans { get; set; }
        public int lisans { get; set; }
        public int yukseklisans { get; set; }
        public int doktora { get; set; }
        public int Toplam { get; set; } 

    }
}
