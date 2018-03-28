using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1Beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public OtoparkKuyrugu oq = new OtoparkKuyrugu(100);
        Random r = new Random();


        public void Yenile()
        {
            aracListe.Items.Clear();
            int c = 0;
            foreach (Araba uye in oq.Otopark)
            {
                if (uye != null)
                {
                    c += uye.sure;
                    
                    aracListe.Items.Add("Arac No:   " + uye.aracNo + "   Sure:  " + uye.sure+"  Bekleme Süresi:  "+c);
                }
                else
                    continue;
            }
            
        }
        public void Yenile2()
        {
            listOncelik.Items.Clear();
            int c = 0;
            foreach (Araba uye in pq.Otopark)
            {
                if (uye != null)
                {
                    c += uye.sure;

                    listOncelik.Items.Add("Arac No:   " + uye.aracNo + "   Sure:  " + uye.sure + "  Bekleme Süresi:  " + c);
                }
                else
                    continue;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sure, aracNo;
            sure = r.Next(10, 301);
            aracNo = r.Next(1, 101);

            Araba tasit = new Araba(aracNo,sure);
         
            oq.Insert(tasit);
            Yenile();
            
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
           
            oq.Remove();
            Yenile();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            aracListe.Items.Clear();
            /*foreach (Araba item in oq.Otopark)
            {
                if (item != null)
                    aracListe.Items.Add("Arac No:  " + item.aracNo+ "  Sure:    "+item.sure);
                else
                    continue;
            }*/
            Yenile();
        }

        private void btnSureOrt_Click(object sender, EventArgs e)
        {
            int c = 0,a=0;
            foreach (Araba uye in oq.Otopark)
            {
                if (uye != null)
                {
                    c += uye.sure;
                    a ++;
                    
                }
                else
                    continue;
            }
            MessageBox.Show("Ortalama İşlem Süresi: "+ (c/a) +" Saniye");
        }
        Öncelik pq = new Öncelik(100);

        private void btnOncelikSirala_Click(object sender, EventArgs e)
        {
            foreach (Araba item in oq.Otopark)
            {
                if (item != null)
                    pq.Insert(item);
                else
                    continue;
            }
            Yenile2();
        }

        private void btnOCikar_Click(object sender, EventArgs e)
        {
            pq.Remove();
            Yenile2();
        }

        private void btnOSureOtr_Click(object sender, EventArgs e)
        {
            int c = 0, a = 0;
            foreach (Araba uye in pq.Otopark)
            {
                if (uye != null)
                {
                    c += uye.sure;
                    a++;

                }
                else
                    continue;
            }
            MessageBox.Show("Ortalama İşlem Süresi: " + (c / a) + " Saniye");
        }
    }
}
