using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriProgramiOdev1.Grup
{
    internal class Uygulama
    {
        private Galeri OtoGaleri = new Galeri();
        private int sayac = 10;

        public void Calistir()
        {
            Menu();
            while (true)
            {
                string str1 = SecimAl();
                Console.WriteLine();
                string str2 = str1;
                if (str2 != null)
                {
                    switch (str2.Length)
                    {
                        case 1:
                            switch (str2[0])
                            {
                                case '1':
                                case 'K':
                                    ArabaKirala();
                                    break;
                                case '2':
                                case 'T':
                                    ArabaTeslimi();
                                    break;
                                case '3':
                                case 'R':
                                    ArabalariListele("Kirada");
                                    break;
                                case '4':
                                case 'M':
                                    ArabalariListele("Galeride");
                                    break;
                                case '5':
                                case 'A':
                                    ArabalariListele("ArabaYok");
                                    break;
                                case '6':
                                case 'I':
                                    KiralamaIptal();
                                    break;
                                case '7':
                                case 'Y':
                                    ArabaEkle();
                                    break;
                                case '8':
                                case 'S':
                                    ArabaSil();
                                    break;
                                case '9':
                                case 'G':
                                    BilgileriGoster();
                                    break;
                                case 'X':
                                    return;
                            }
                            break;
                        case 5:
                            if (str2 == "ÇIKIŞ")
                            {
                                Cikis();
                                break;
                            }
                            else
                            {
                                break;
                            }
                        default:
                            HataSay();
                            break;
                    }
                }
                else
                {
                HataSay();

                }
            }
        }

        public void HataSay()
        {
            Console.WriteLine("Geçersiz seçim! Lütfen geçerli bir seçim yapın.");
            sayac--;
        }

        public void Menu()
        {
            Console.WriteLine("Galeri Otomasyon                    ");
            Console.WriteLine("1- Araba Kirala (K)                 ");
            Console.WriteLine("2- Araba Teslim Al (T)              ");
            Console.WriteLine("3- Kiradaki Arabaları Listele (R)   ");
            Console.WriteLine("4- Galerideki Arabaları Listele (M) ");
            Console.WriteLine("5- Tüm Arabaları Listele (A)        ");
            Console.WriteLine("6- Kiralama İptali (I)              ");
            Console.WriteLine("7- Araba Ekle (Y)                   ");
            Console.WriteLine("8- Araba Sil (S)                    ");
            Console.WriteLine("9- Bilgileri Göster (G)             ");
        }

        public string SecimAl()
        {
            if (sayac != 0)
            {
                Console.WriteLine();
                Console.Write("Seçiminiz: ");
                return Console.ReadLine().ToUpper();
            }
            Console.WriteLine();
            Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
            return "ÇIKIŞ";
        }

        public void Cikis()
        {
            Environment.Exit(0);
        }

        public void ArabaKirala()
        {
            Console.WriteLine("-Araba Kirala-");
            Console.WriteLine();
            try
            {
                if (OtoGaleri.Arabalar.Count == 0)
                {

                    throw new Exception("Galeride hiç araba yok.");
                }
                if (OtoGaleri.GaleridekiAracSayisi == 0)
                {
                    throw new Exception("Tüm araçlar kirada.");

                }
                string plaka;
                bool devamMi = true;
                while (devamMi)
                {
                    plaka = AracGerecler.PlakaAl("Kiralanacak arabanın plakası: ");
                    if (!(plaka == "X"))
                    {
                        switch (OtoGaleri.DurumGetir(plaka))
                        {
                            case "Kirada":
                                Console.WriteLine("Araba şu anda kirada. Farklı araba seçiniz.");
                                break;
                            case "ArabaYok":
                                Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                                break;
                            default:
                                int sure = AracGerecler.SayiAl("Kiralanma süresi: ");
                                OtoGaleri.ArabaKirala(plaka, sure);
                                Console.WriteLine();
                                Console.WriteLine(plaka.ToUpper() + " plakalı araba " + sure.ToString() + " saatliğine kiralandı.");
                                devamMi = false;
                                break;
                        }
                    }
                    else
                        break;
                }
                return;

            }
            catch (Exception ex)
            {
                if (ex.Message == "Çıkış")
                    return;
                Console.WriteLine(ex.Message);
            }
        }

        public void ArabaTeslimi()
        {
            Console.WriteLine("-Araba Teslim Al-");
            Console.WriteLine();
            try
            {
                if (OtoGaleri.Arabalar.Count == 0)
                    throw new Exception("Galeride hiç araba yok.");
                if (OtoGaleri.KiradakiArabaSayisi == 0)
                    throw new Exception("Kirada hiç araba yok.");
                string plaka;
                bool devamMi = true;
                while (devamMi)
                {
                    plaka = AracGerecler.PlakaAl("Teslim edilecek arabanın plakası: ");
                    if (!(plaka == "X"))
                    {
                        switch (OtoGaleri.DurumGetir(plaka))
                        {
                            case "Galeride":
                                Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
                                break;
                            case "ArabaYok":
                                Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                                break;
                            default:
                                OtoGaleri.ArabaTeslimAl(plaka);
                                Console.WriteLine();
                                Console.WriteLine("Araba galeride beklemeye alındı.");
                                devamMi = false;
                                break;
                        }
                    }
                    else
                        break;
                }
                return;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ArabalariListele(string durum)
        {
            switch (durum)
            {
                case "Kirada":
                    Console.WriteLine("-Kiradaki Arabalar-");
                    break;
                case "Galeride":
                    Console.WriteLine("-Galerideki Arabalar-");
                    break;
                default:
                    Console.WriteLine("-Tüm Arabalar-");
                    break;
            }
            Console.WriteLine();
            ArabaListele(OtoGaleri.ArabaListesiGetir(durum));
        }

        public void ArabaListele(List<Araba> AracListe)
        {
            if (AracListe.Count == 0)
            {
                Console.WriteLine("Listelenecek araç yok.");
            }
            else
            {
                Console.WriteLine("Plaka".PadRight(14) + "Marka".PadRight(12) + "K. Bedeli".PadRight(12) + "Araba Tipi".PadRight(12) + "K. Sayısı".PadRight(12) + "Durum");
                Console.WriteLine("".PadRight(70, '-'));
                foreach (Araba araba in AracListe)
                {
                    Console.WriteLine(araba.Plaka.PadRight(14) + araba.Marka.PadRight(12) + araba.KiralamaBedeli.ToString().PadRight(12) + araba.AracTipi.ToString().PadRight(12) + araba.KiralamaSayisi.ToString().PadRight(12) + araba.Durum);
                }
            }
        }

        public void KiralamaIptal()
        {
            Console.WriteLine("-Kiralama İptali-");
            Console.WriteLine();
            try
            {
                if (OtoGaleri.KiradakiArabaSayisi == 0)
                    throw new Exception("Kirada araba yok.");
                string plaka;
                bool devamMi = true;
                while (devamMi)
                {
                    plaka = AracGerecler.PlakaAl("Kiralaması iptal edilecek arabanın plakası: ");
                    if (!(plaka == "X"))
                    {
                        switch (OtoGaleri.DurumGetir(plaka))
                        {
                            case "Galeride":
                                Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
                                break;
                            case "ArabaYok":
                                Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                                break;
                            default:
                                OtoGaleri.KiralamaIptal(plaka);
                                Console.WriteLine();
                                Console.WriteLine("İptal gerçekleştirildi.");
                                devamMi = false;
                                break;
                        }
                    }
                    else
                        break;
                }
                return;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ArabaEkle()
        {
            Console.WriteLine("-Araba Ekle-");
            Console.WriteLine();
            try
            {
                string plaka;
                bool devamMi = true;
                while (devamMi)
                {
                    plaka = AracGerecler.PlakaAl("Plaka: ");
                    if (!(plaka == "X"))
                    {
                        if (OtoGaleri.DurumGetir(plaka) == "Kirada" || OtoGaleri.DurumGetir(plaka) == "Galeride")
                        {

                            Console.WriteLine("Aynı plakada araba mevcut. Girdiğiniz plakayı kontrol edin.");
                        }
                        else
                        {
                            string marka = AracGerecler.YaziAl("Marka: ");
                            if (marka == "X")
                                return;
                            float kiralamaBedeli = (float)AracGerecler.SayiAl("Kiralama bedeli: ");
                            string aracTipi = AracGerecler.AracTipiAl();
                            OtoGaleri.ArabaEkle(plaka, marka, kiralamaBedeli, aracTipi);
                            Console.WriteLine();
                            Console.WriteLine("Araba başarılı bir şekilde eklendi.");
                            devamMi = false;
                        }

                    }
                    else
                        break;
                }
                return;


            }
            catch (Exception ex)
            {
                if (ex.Message == "Çıkış")
                    return;
                Console.WriteLine(ex.Message);
            }
        }

        public void ArabaSil()
        {
            Console.WriteLine("-Araba Sil-");
            Console.WriteLine();
            try
            {
                if (OtoGaleri.Arabalar.Count == 0)
                    throw new Exception("Galeride silinecek araba yok.");
                string plaka;
                bool devamMi = true;
                while (devamMi)
                {
                    plaka = AracGerecler.PlakaAl("Silmek istediğiniz arabanın plakasını giriniz: ");
                    if (!(plaka == "X"))
                    {
                        if (OtoGaleri.DurumGetir(plaka) == "ArabaYok")
                        {
                            Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                        }
                        else if (OtoGaleri.DurumGetir(plaka) == "Kirada")
                        {
                            Console.WriteLine("Araba kirada olduğu için silme işlemi gerçekleştirilemedi.");
                        }

                        else
                        {
                            OtoGaleri.ArabaSil(plaka);
                            Console.WriteLine();
                            Console.WriteLine("Araba silindi.");
                            devamMi = false;
                        }
                    }
                    else
                        break;
                }
                return;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("-Galeri Bilgileri-");
            Console.WriteLine("Toplam araba sayısı: " + OtoGaleri.ToplamArabaSayisi.ToString());
            Console.WriteLine("Kiradaki araba sayısı: " + OtoGaleri.KiradakiArabaSayisi.ToString());
            Console.WriteLine("Bekleyen araba sayısı: " + OtoGaleri.GaleridekiAracSayisi.ToString());
            Console.WriteLine("Toplam araba kiralama süresi: " + OtoGaleri.ToplamArabaKiralamaSuresi.ToString());
            Console.WriteLine("Toplam araba kiralama adedi: " + OtoGaleri.ToplamAracKiralamaAdedi.ToString());
            Console.WriteLine("Ciro: " + OtoGaleri.Ciro.ToString());
        }
    }
}
