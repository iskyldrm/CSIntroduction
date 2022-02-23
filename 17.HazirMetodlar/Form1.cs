using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.HazirMetodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Elimizdeki metinsel değerleri manipülasyonunda hazır
        //olara kullacağımız bir çok metod .net alt yapısında mevcuttur.
        private void btnCompare_Click(object sender, EventArgs e)
        {
            //Compare To elimizdeki string ifadeyi verilen string ile karşılaştırır.
            int deger = txtGiris.Text.CompareTo("Ali Veli");
            string mesaj = "";
            switch (deger)
            {
                case -1:
                    mesaj = "Verilen kelime diğeri ile eşleşmemektedir";
                    break;
                case 0:
                    mesaj="Kelimeler Eşleşmektedir";

                    break;
                case 1:
                    mesaj = "fazla kelime var";
                    break;
                default:
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //Verilen ifade elimizdeki değer içinde varmı yok mu ona bakar

            bool varmi = txtGiris.Text.Contains("Ali");
            MessageBox.Show("Aradığınız kelime " + (varmi ? "Bulunmaktadır" : "Bulunmamaktadır"));
        }

        private void btnstartwith_Click(object sender, EventArgs e)
        {
            //girilen deger ile elimizdeki stringin başlayıp başlamadığını kontrol eder.
            //bool deger döner

            bool basliyormu = txtGiris.Text.StartsWith("Ali");

            

            MessageBox.Show("girilen kelime " + (basliyormu?"ali ile başlıyor":"ali ile başlamıyor"));
        }

        private void btnindexof_Click(object sender, EventArgs e)
        {
            int index = txtGiris.Text.IndexOf("UEFA");
            MessageBox.Show("aradığınız kelime" + index + " indexte başlamaktadır");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //not : elimizdeki string ifade uzeirnde yaptığımız değişiklikler stringin orjinalini değiştirmez. size yeni bir string geri döner.

            string yenimetin = txtGiris.Text.Remove(10);
            MessageBox.Show(yenimetin);
            string Yenimetin = txtGiris.Text.Remove(10,1); // 2. kullanım
            MessageBox.Show(Yenimetin);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            //verilen kelime yada karekteri elimizdeki string içerisinde arar bulur değiştirir.

            string yenisi = txtGiris.Text.Replace("Fenerbahçe", "Galatasaray");
            MessageBox.Show(yenisi);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            // sptlit elimizdeki stringi parçalamaya yarar.
            // neye göre parçalayacağınız ise metoda paramatre olarak geçilir

            string[] kelimeler = txtGiris.Text.Split('.');
            foreach (var item in kelimeler)
            {
                txtBlackList.Text += (item + "\n");
            }
        }

        private void btnBlackList_Click(object sender, EventArgs e)
        {
            string[] blackListler = txtBlackList.Text.Split(' ');

            string yenim="";

            foreach (var yasak in blackListler)
            {


                    if (txtGiris.Text.Contains(yasak))
                    {
                        yenim = txtGiris.Text.Replace(yasak, "*******");
                    txtGiris.Text = yenim;
                    }
                
            }
            MessageBox.Show(yenim);
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            //elimizdeki metin içerisinde verilen sayidan başlarayara diğer verilen sayi kadar olan kısmı bize verir

            string substr = txtGiris.Text.Substring(50);
            string substr2 = txtGiris.Text.Substring(50,20);

            MessageBox.Show(substr);
            MessageBox.Show(substr2);

            


        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string str = "        sdsad sadsakda sadojaosd asdja sod asdjasodjas          ";
            MessageBox.Show(str.Trim());
        }

        private void btnCharToArray_Click(object sender, EventArgs e)
        {
            string str = "asdsjkldfjdl aowıeuwrsa";
            foreach (var ch in str.ToCharArray())
            {
                listBox1.Items.Add(ch);
            }
        }

        private void btnDigit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
