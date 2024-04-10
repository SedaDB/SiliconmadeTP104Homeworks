using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriProgramiOdev1.Grup
{
    internal class Araba
    {
        public List<int> KiralamaSureleri = new List<int>();

        public string Plaka { get; set; }

        public string Marka { get; set; }

        public float KiralamaBedeli { get; set; }

        public string AracTipi { get; set; }

        public string Durum { get; set; }

        public Araba(string plaka, string marka, float kiralamaBedeli, string aracTipi)
        {
            Plaka = plaka.ToUpper();
            Marka = marka.ToUpper();
            KiralamaBedeli = kiralamaBedeli;
            AracTipi = aracTipi;
            Durum = "Galeride";
        }
        public int KiralamaSayisi
        {
            get
            {
                return KiralamaSureleri.Count;
            }
        }
        public int ToplamKiralamaSuresi
        {
            get
            {
                int toplam = 0;
                foreach (int sure in KiralamaSureleri)
                {
                    toplam += sure;
                }

                return KiralamaSureleri.Sum();

            }
        }
        
    }
}
