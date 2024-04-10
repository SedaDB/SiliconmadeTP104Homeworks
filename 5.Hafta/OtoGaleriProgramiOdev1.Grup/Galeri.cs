using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriProgramiOdev1.Grup
{
    internal class Galeri
    {
        public List<Araba> Arabalar = new List<Araba>();
        public Galeri()
        {
            SahteVeriGir();
        }

        public int GaleridekiAracSayisi
        {
            get
            {
                int adet = 0;

                foreach (Araba a in Arabalar)
                {
                    if (a.Durum == "Galeride")
                    {
                        adet++;
                    }
                }

                return adet;
            }
        }

        public int KiradakiArabaSayisi
        {
            get
            {
                int adet = 0;

                foreach (Araba a in Arabalar)
                {
                    if (a.Durum == "Kirada")
                    {
                        adet++;
                    }
                }

                return adet;
            }
        }

        public int ToplamArabaSayisi
        {
            get
            {
              return  Arabalar.Count;
            }
        }
        public int ToplamArabaKiralamaSuresi
        {
            get
            {
                return Arabalar.Sum(a => a.KiralamaSureleri.Sum());
            }
        }

        public int ToplamAracKiralamaAdedi
        {
            get
            {
                return Arabalar.Sum(a => a.KiralamaSayisi);
            }
        
        }

        public float Ciro
        {
            get
            {
                return Arabalar.Sum(a => (float)a.ToplamKiralamaSuresi * a.KiralamaBedeli);
            }
        }

        public void ArabaEkle(string plaka, string marka, float kiralamaBedeli, string aracTipi)
        {
            Arabalar.Add(new Araba(plaka, marka, kiralamaBedeli, aracTipi));
        }

        public void SahteVeriGir()
        {
            ArabaEkle("34arb3434", "FIAT", 70f, "Sedan");
            ArabaEkle("35arb3535", "KIA", 60f, "SUV");
            ArabaEkle("34us2342", "OPEL", 50f, "Hatchback");
        }

        public string DurumGetir(string plaka)
        {
            Araba araba = Arabalar
                      .Where(a => a.Plaka == plaka.ToUpper())
                      .FirstOrDefault<Araba>();
            return araba != null ? araba.Durum : "ArabaYok";
        }

        public void ArabaKirala(string plaka, int sure)
        {
            Araba araba = Arabalar.Where(a => a.Plaka == plaka.ToUpper()).FirstOrDefault<Araba>();
            if (araba == null || !(araba.Durum == "Galeride"))
                return;
            araba.Durum = "Kirada";
            araba.KiralamaSureleri.Add(sure);
        }

        public List<Araba> ArabaListesiGetir(string durum)
        {
            List<Araba> arabaList = Arabalar;
            if (durum == "Kirada" || durum == "Galeride")
                arabaList = Arabalar.Where(a => a.Durum == durum).ToList<Araba>();
            return arabaList;
        }

        public void ArabaTeslimAl(string plaka)
        {
            Araba araba = Arabalar.Where(a => a.Plaka == plaka.ToUpper()).FirstOrDefault<Araba>();
            if (araba == null)
                throw new Exception("Bu plakada bir araç yok.");
            araba.Durum = !(araba.Durum == "Galeride") ? "Galeride" : throw new Exception("Zaten galeride");
        }

        public void KiralamaIptal(string plaka)
        {
            Araba araba = Arabalar.Where(a => a.Plaka == plaka.ToUpper()).FirstOrDefault<Araba>();
            if (araba == null)
                return;
            araba.Durum = "Galeride";
            araba.KiralamaSureleri.RemoveAt(araba.KiralamaSureleri.Count - 1);
        }

        public void ArabaSil(string plaka)
        {
            Araba araba = Arabalar.Where(x => x.Plaka == plaka.ToUpper()).FirstOrDefault<Araba>();
            if (araba == null || !(araba.Durum == "Galeride"))
                return;
            Arabalar.Remove(araba);
        }
    }
}
