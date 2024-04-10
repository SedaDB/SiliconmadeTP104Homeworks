﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Grup1OkulYonetimUygulamasi
{
    internal class Uygulama
    {
        private static Okul Okul = new Okul();
        private int sayac = 0;

        public void Calistir()
        {
            SahteVeriGir();
            Menu();
            while (true)
            {
                Console.WriteLine();
                string str = SecimAl();
                if (str != null)
                {
                    switch (str.Length)
                    {
                        case 0:
                            HataSay();
                            break;
                        case 1:
                            switch (str[0])
                            {
                                case '1':
                                    TümOgrencileriListele();
                                    break;
                                case '2':
                                    SubeyeGoreListele();
                                    break;
                                case '3':
                                    CinsiyeteGoreListele();
                                    break;
                                case '4':
                                    TarihtenSonraDoganlar();
                                    break;
                                case '5':
                                    IllereGoreListele();
                                    break;
                                case '6':
                                    NotlariGoster();
                                    break;
                                case '7':
                                    KitapListele();
                                    break;
                                case '8':
                                    OkulEnBasariliBes();
                                    break;
                                case '9':
                                    OkulEnBasarisizUc();
                                    break;
                            }
                            break;
                        case 2:
                            switch (str[1])
                            {
                                case '0':
                                    switch (str)
                                    {
                                        case "10":
                                            SubeEnBasariliBes();
                                            break;
                                        case "20":
                                            NotGir();
                                            break;
                                    }
                                    break;
                                case '1':
                                    if (str == "11")
                                    {
                                        SubeEnBasarisizUc();
                                        break;
                                    }
                                    else
                                        break;
                                case '2':
                                    if (str == "12")
                                    {
                                        OrtalamaGoster();
                                        break;
                                    }
                                    else
                                        break;
                                case '3':
                                    if (str == "13")
                                    {
                                        SinifinOrtalamasi();
                                        break;
                                    }
                                    else
                                        break;
                                case '4':
                                    if (str == "14")
                                    {
                                        SonKitap();
                                        break;
                                    }
                                    else
                                        break;
                                case '5':
                                    if (str == "15")
                                    {
                                        OgrenciGir();
                                        break;
                                    }
                                    else
                                        break;
                                case '6':
                                    if (str == "16")
                                    {
                                        Guncelle();
                                        break;
                                    }
                                    else
                                        break;
                                case '7':
                                    if (str == "17")
                                    {
                                        OgrenciSil();
                                        break;
                                    }
                                    else
                                        break;
                                case '8':
                                    if (str == "18")
                                    {
                                        AdresGir();
                                        break;
                                    }
                                    else
                                        break;
                                case '9':
                                    if (str == "19")
                                    {
                                        KitapGir();
                                        break;
                                    }
                                    else
                                        break;
                            }
                            break;
                        case 5:
                            switch (str[0])
                            {
                                case 'C':
                                    if (str == "CİKİS")
                                        break;
                                    HataSay();
                                    break;
                                case 'L':
                                    if (str == "LİSTE")
                                    {
                                        Console.WriteLine();
                                        Menu();
                                        Console.WriteLine();
                                        continue;
                                    }
                                    else
                                        HataSay();
                                    break;
                                case 'Ç':
                                    if (str == "ÇIKIŞ")
                                        break;
                                    HataSay();
                                    break;
                                default:
                                    HataSay();
                                    break;
                            }
                            Cikis();
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Menüyü tekrar listelemek için \"liste\", çıkış yapmak için \"çıkış\" yazın.");
                }
           
               
            }
        }
        public void HataSay()
        {
            Console.WriteLine();
            Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
            ++sayac;
        }

        public void Menu()
        {
            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----");
            Console.WriteLine();
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör");
            Console.WriteLine("13 - Şubenin not ortalamasını gör");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
            Console.WriteLine("15 - Öğrenci ekle");
            Console.WriteLine("16 - Öğrenci güncelle");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("20 - Öğrencinin notunu gir");
            Console.WriteLine();
            Console.WriteLine("çıkış yapmak için \"çıkış\" yazıp \"enter\"a basın.");
        }

        public string SecimAl()
        {
            if (sayac != 10)
            {
                Console.Write("Yapmak istediginiz islemi seçiniz: ");
                return Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
            return "ÇIKIŞ";
        }

        public void Cikis() => Environment.Exit(0);

        public void SahteVeriGir()
        {
            SahteOgrenciGir();
            SahteNotGir();
            SahteAdresGir();
            SahteKitapEkle();
        }

        public void SahteOgrenciGir()
        {
            Uygulama.Okul.OgrenciEkle(1, "Elif", "Selçuk", new DateTime(2001, 5, 5), CINSIYET.Kiz, SUBE.A);
            Uygulama.Okul.OgrenciEkle(2, "Betül", "Yılmaz", new DateTime(2000, 10, 2), CINSIYET.Kiz, SUBE.B);
            Uygulama.Okul.OgrenciEkle(3, "Hakan", "Çelik", new DateTime(2001, 8, 12), CINSIYET.Erkek, SUBE.C);
            Uygulama.Okul.OgrenciEkle(4, "Kerem", "Akay", new DateTime(2002, 6, 10), CINSIYET.Erkek, SUBE.A);
            Uygulama.Okul.OgrenciEkle(5, "Hatice", "Çınar", new DateTime(2000, 6, 5), CINSIYET.Kiz, SUBE.B);
            Uygulama.Okul.OgrenciEkle(6, "Selim", "İleri", new DateTime(2004, 7, 20), CINSIYET.Erkek, SUBE.B);
            Uygulama.Okul.OgrenciEkle(7, "Selin", "Kamış", new DateTime(2002, 5, 20), CINSIYET.Kiz, SUBE.C);
            Uygulama.Okul.OgrenciEkle(8, "Sinan", "Avcı", new DateTime(2003, 2, 15), CINSIYET.Erkek, SUBE.A);
            Uygulama.Okul.OgrenciEkle(9, "Deniz", "Çoban", new DateTime(2000, 2, 2), CINSIYET.Erkek, SUBE.C);
            Uygulama.Okul.OgrenciEkle(10, "Selda", "Kavak", new DateTime(1999, 9, 20), CINSIYET.Kiz, SUBE.B);
        }

        public void SahteNotGir()
        {
            string[] strArray = new string[]
            {
        "Türkçe",
        "Matematik",
        "Fen",
        "Sosyal"
            };
            Random random = new Random();
            for (int ogrenciNo = 1; ogrenciNo <= 10; ++ogrenciNo)
            {
                for (int i = 0; i < strArray.Length; ++i)
                    Uygulama.Okul.NotEkle(ogrenciNo, strArray[i], random.Next(0, 100));
            }
        }

        public void SahteAdresGir()
        {
            Uygulama.Okul.AdresEkle(1, "Ankara", "Çankaya", "Bağlıca");
            Uygulama.Okul.AdresEkle(2, "Ankara", "Keçiören", "Osmangazi");
            Uygulama.Okul.AdresEkle(3, "Ankara", "Çankaya", "Çukurambar");
            Uygulama.Okul.AdresEkle(4, "İzmir", "Karşıyaka", "Alaybey");
            Uygulama.Okul.AdresEkle(5, "İzmir", "Gaziemir", "Atıfbey");
            Uygulama.Okul.AdresEkle(6, "İzmir", "Gaziemir", "Irmak");
            Uygulama.Okul.AdresEkle(7, "İzmir", "Bayraklı", "Adalet");
            Uygulama.Okul.AdresEkle(8, "İstanbul", "Arnavutköy", "Anadolu");
            Uygulama.Okul.AdresEkle(9, "İstanbul", "Beykoy", "Acarlar");
            Uygulama.Okul.AdresEkle(10, "İstanbul", "Ataşehir", "Atatürk");
        }

        public void SahteKitapEkle()
        {
            string[] strArray = new string[]
            {
        "Ölü Ozanlar Derneği",
        "George Orwell- 1984",
        "Bülbülü Öldürmek",
        "Hayvan Çiftliği",
        "Harry Potter ve Felsefe Taşı",
        "Çavdar Tarlasında Çocuklar",
        "Büyük Umutlar",
        "Gurur ve Ön Yargı",
        "Jane Eyre",
        "Uğultulu Tepeler",
        "Frankenstein",
        "Kuşların Şarkısı",
        "Noel Şarkısı",
        "Harry Potter Sırlar Odası",
        "Harry Potter Azkaban Tutsağı",
        " Bir Ses Böler Geceyi",
        "Masal Masal İçinde",
        "Sis ve Gece",
        "Agatha'nın Anahtarı "
            };
            Random random = new Random();
            for (int no = 1; no <= 10; ++no)
                Uygulama.Okul.KitapEkle(no, strArray[random.Next(0, strArray.Length)]);
        }

        public void Listele(List<Ogrenci> liste)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine("Listelenecek ögrenci yok.");
            }
            else
            {
                Console.WriteLine("Sube".PadRight(10) + "No".PadRight(10) + "Adı " + "Soyadı".PadRight(21) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.");
                Console.WriteLine("".PadRight(79, '-'));
                foreach (Ogrenci ogrenci in liste)
                    Console.WriteLine(ogrenci.Sube.ToString().PadRight(10) + ogrenci.No.ToString().PadRight(10) + (ogrenci.Ad + " " + ogrenci.Soyad).PadRight(25) + ogrenci.Ortalama.ToString().PadRight(15) + ogrenci.KitapSayisi.ToString());
            }
        }

        public void TümOgrencileriListele()
        {
            Console.WriteLine();
            Console.WriteLine("1-Bütün Ögrencileri Listele --------------------------------------------------");
            if (Uygulama.Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
            }
            else
            {
                Console.WriteLine();
                Listele(Uygulama.Okul.Ogrenciler);
            }
        }

        public void SubeyeGoreListele()
        {
            Console.WriteLine();
            Console.WriteLine("2-Subeye Göre Ögrencileri Listele --------------------------------------------");
            if (Uygulama.Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
            }
            else
            {
                SUBE sb = AracGerecler.SubeAl("Listelemek istediğiniz şubeyi girin (A/B/C): ");
                List<Ogrenci> list = Uygulama.Okul.Ogrenciler.Where<Ogrenci>(item => item.Sube == sb).ToList<Ogrenci>();
                Console.WriteLine();
                Listele(list);
            }
        }

        public void CinsiyeteGoreListele()
        {
            Console.WriteLine();
            Console.WriteLine("3-Cinsiyete Göre Öğrencileri Listele -----------------------------------------");
            CINSIYET cins = AracGerecler.KizMiErkekMi("Listelemek istediğiniz cinsiyeti girin (K/E): ");
            List<Ogrenci> list = Uygulama.Okul.Ogrenciler.Where<Ogrenci>(a => a.Cinsiyet == cins).ToList<Ogrenci>();
            Console.WriteLine();
            Listele(list);
        }

        public void TarihtenSonraDoganlar()
        {
            Console.WriteLine();
            Console.WriteLine("4-Dogum Tarihine Göre Ögrencileri Listele ------------------------------------");
            DateTime tarih = AracGerecler.TarihAl("Hangi tarihten sonraki ögrencileri listelemek istersiniz: ");
            List<Ogrenci> list = Uygulama.Okul.Ogrenciler.Where<Ogrenci>(a => a.DogumTarihi > tarih).ToList<Ogrenci>();
            Console.WriteLine();
            Listele(list);
        }

        public void IllereGoreListele()
        {
            Console.WriteLine();
            Console.WriteLine("5-Illere Göre Ögrencileri Listele --------------------------------------------");
            List<Ogrenci> list = Uygulama.Okul.Ogrenciler.OrderBy<Ogrenci, string>(a => a.Adres.Il).ToList<Ogrenci>();
            Console.WriteLine();
            Listele1(list);
        }

        public void Listele1(List<Ogrenci> liste)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
            }
            else
            {
                Console.WriteLine("Sube".PadRight(10, ' ') + "No".PadRight(10, ' ') + "Adı Soyadı".PadRight(21, ' ') + "Sehir".PadRight(15, ' ') + "Semt");
                Console.WriteLine("".PadRight(79, '-'));
                foreach (Ogrenci ogrenci in liste)
                    Console.WriteLine(ogrenci.Sube.ToString().PadRight(10, ' ') + ogrenci.No.ToString().PadRight(10, ' ') + (ogrenci.Ad + " " + ogrenci.Soyad).PadRight(21, ' ') + ogrenci.Adres.Il.PadRight(15, ' ') + ogrenci.Adres.Ilce);
            }
        }

        public void NotlariGoster()
        {
            Console.WriteLine();
            Console.WriteLine("6-Ögrencinin notlarını görüntüle ---------------------------------------------");
            if (Uygulama.Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
            }
            else
            {
                int no = NoAl();
                BilgiYazdir(no);
                Listele2(Uygulama.Okul.OgrenciNotlariGetir(no));
            }
        }

        public int NoAl()
        {
            int no;
            while (true)
            {
                no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                if (!Uygulama.Okul.VarMi(no))
                    Console.WriteLine("Bu numarada bir ögrenci yok.Tekrar deneyin.");
                else
                    break;
            }
            return no;
        }

        public void BilgiYazdir(int no)
        {
            Console.WriteLine();
            Console.Write("Ögrencinin Adı Soyadı: ");
            Console.WriteLine(Uygulama.Okul.AdiSoyadiGetir(no));
            Console.Write("Ögrencinin Subesi: ");
            Console.WriteLine(Uygulama.Okul.SubeGetir(no));
            Console.WriteLine();
        }

        public void Listele2(List<DersNotu> liste)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine("Öğrenciye ait bir not bulunmamaktadır");
            }
            else
            {
                Console.WriteLine("Dersin Adi".PadRight(15) + "Notu");
                Console.WriteLine("".PadRight(20, '-'));
                foreach (DersNotu dersNotu in liste)
                    Console.WriteLine(dersNotu.DersAdi.ToString().PadRight(15) + dersNotu.Not.ToString());
            }
        }

        public void KitapListele()
        {
            Console.WriteLine();
            Console.WriteLine("7-Ögrencinin okudugu kitapları listele ---------------------------------------");
            int no = NoAl();
            BilgiYazdir(no);
            Listele3(Uygulama.Okul.KitapListele(no));
        }

        public void Listele3(List<string> liste)
        {
            if (liste != null)
            {
                Console.WriteLine("Okudugu Kitaplar");
                Console.WriteLine("-----------------");
                foreach (string str in liste)
                    Console.WriteLine(str);
            }
            else
                Console.WriteLine("Öğrencinin okuduğu herhangi bir kitap bulunmamaktadır.");
        }

        public void OkulEnBasariliBes()
        {
            Console.WriteLine();
            Console.WriteLine("8-Okuldaki en basarılı 5 ögrenciyi listele -----------------------------------");
            List<Ogrenci> list = Uygulama.Okul.Ogrenciler.OrderByDescending<Ogrenci, double>(a => a.Ortalama).Take<Ogrenci>(5).ToList<Ogrenci>();
            Console.WriteLine();
            Listele(list);
        }

        public void OkulEnBasarisizUc()
        {
            Console.WriteLine();
            Console.WriteLine("9-Okuldaki en basarısız 3 ögrenciyi listele ----------------------------------");
            List<Ogrenci> list = Uygulama.Okul.Ogrenciler.OrderBy<Ogrenci, double>(a => a.Ortalama).Take<Ogrenci>(3).ToList<Ogrenci>();
            Console.WriteLine();
            Listele(list);
        }

        public void SubeEnBasariliBes()
        {
            Console.WriteLine();
            Console.WriteLine("10-Subedeki en basarılı 5 ögrenciyi listele -----------------------------------");
            SUBE sb = AracGerecler.SubeAl("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            List<Ogrenci> list = Uygulama.Okul.Ogrenciler.Where<Ogrenci>(item => item.Sube == sb).OrderByDescending<Ogrenci, double>(a => a.Ortalama).Take<Ogrenci>(5).ToList<Ogrenci>();
            Console.WriteLine();
            Listele(list);
        }

        public void SubeEnBasarisizUc()
        {
            Console.WriteLine();
            Console.WriteLine("11-Subedeki en basarısız 3 ögrenciyi listele ----------------------------------");
            SUBE sb = AracGerecler.SubeAl("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            List<Ogrenci> list = Uygulama.Okul.Ogrenciler.Where<Ogrenci>(item => item.Sube == sb).OrderBy<Ogrenci, double>(a => a.Ortalama).Take<Ogrenci>(5).ToList<Ogrenci>();
            Console.WriteLine();
            Listele(list);
        }

        public void OrtalamaGoster()
        {
            Console.WriteLine();
            Console.WriteLine("12-Ögrencinin Not Ortalamasını Gör ----------------------------------");
            if (Uygulama.Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
            }
            else
            {
                int no = NoAl();
                BilgiYazdir(no);
                Console.Write("Ögrencinin not ortalaması: " + Uygulama.Okul.OrtalamaGetir(no).ToString());
                Console.WriteLine();
            }
        }

        public void SinifinOrtalamasi()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("13-Şubenin Not Ortalamasını Gör -------------------------------------");
                SUBE sube = AracGerecler.SubeAl("Bir şube seçin (A/B/C): ");
                Console.WriteLine();
                double d = Uygulama.Okul.Ogrenciler.Where<Ogrenci>(a => a.Sube == sube ).Average<Ogrenci>(a => a.Ortalama);
                Console.Write(sube.ToString() + " subesinin not ortalaması: " + Decimal.Round((Decimal)d, 2).ToString());
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
            }
        }

        public void SonKitap()
        {
            Console.WriteLine();
            Console.WriteLine("14-Ögrencinin okudugu son kitabı listele ----------------------------");
            int no = NoAl();
            BilgiYazdir(no);
            List<string> stringList = Uygulama.Okul.SonKitapGetir(no);
            if (stringList != null)
            {
                Console.WriteLine("Ögrencinin Okudugu Son Kitap");
                Console.WriteLine("-----------------------------");
                foreach (string str in stringList)
                    Console.WriteLine(str);
            }
            else
                Console.WriteLine("Öğrencinin okuduğu herhangi bir kitap bulunmamaktadır.");
        }

        public void OgrenciGir()
        {
            
            Console.WriteLine();
            Console.WriteLine("15-Öğrenci Ekle -----------------------------------------------------");
            int no1 = AracGerecler.SayiAl("Ögrencinin numarası: ");
            bool noVarMi = Okul.NoBak(no1);
            if (noVarMi== false)
            {
                int no2 = Uygulama.Okul.NoOlustur(no1);
                Console.WriteLine($"Sistemde {no1} numaralı öğrenci olduğu için verdiğiniz öğrenci no {no2} olarak değiştirilmiştir.");
                no1 = no2;
            }
            string ad = Uygulama.IlkHarfiBuyut(AracGerecler.YaziAl("Ögrencinin adı: "));
            string soyad = Uygulama.IlkHarfiBuyut(AracGerecler.YaziAl("Ögrencinin soyadı: "));
            DateTime dogumTarihi = AracGerecler.TarihAl("Ögrencinin dogum tarihi: ");
            CINSIYET cinsiyet = AracGerecler.KizMiErkekMi("Ögrencinin cinsiyeti (K/E): ");
            SUBE sube = AracGerecler.SubeAl("Ögrencinin subesi (A/B/C): ");
            Uygulama.Okul.OgrenciEkle(no1, ad, soyad, dogumTarihi, cinsiyet, sube);
            Console.WriteLine();
            Console.WriteLine(no1.ToString() + " numaralı ögrenci sisteme basarılı bir sekilde eklenmistir.");
          
        }

        private static string IlkHarfiBuyut(string veri)
        {
            return veri.Substring(0,1).ToUpper() + veri.Substring(1).ToLower();
        }

        public void Guncelle()
        {
            Console.WriteLine();
            Console.WriteLine("16-Ögrenci Güncelle -----------------------------------------------------------");
            if (Uygulama.Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede güncellenecek ögrenci yok.");
            }
            else
            {
                int no = NoAl();
                string isim = Uygulama.IlkHarfiBuyut(AracGerecler.YaziAl("Ögrencinin adı: "));
                string soyisim = Uygulama.IlkHarfiBuyut(AracGerecler.YaziAl("Ögrencinin soyadı: "));
                DateTime dogumTarihi = AracGerecler.TarihAlGuncelle("Ögrencinin dogum tarihi: ");
                CINSIYET cinsiyet = AracGerecler.KizMiErkekMi("Ögrencinin cinsiyeti (K/E): ");
                SUBE sube = AracGerecler.SubeAl("Ögrencinin subesi (A/B/C): ");
                Uygulama.Okul.Guncelle(no, isim, soyisim, dogumTarihi, cinsiyet, sube);
                Console.WriteLine();
                Console.WriteLine("Ogrenci güncellendi.");
            }
        }

        public void OgrenciSil()
        {
            Console.WriteLine();
            Console.WriteLine("17-Ögrenci sil ----------------------------------------------------------------");
            if (Uygulama.Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek ögrenci yok.");
            }
            else
            {
                int no = NoAl();
                BilgiYazdir(no);
                string str = AracGerecler.YaziAl("Ögrenciyi silmek istediginize emin misiniz (E/H): ");
                if (str.ToUpper() == "E")
                {
                    Uygulama.Okul.OgrenciSil(no);
                    Console.WriteLine("Ögrenci basarılı bir sekilde silindi.");
                }
                else if (!(str.ToUpper() == "H"))
                {
                    Console.WriteLine("Öğrenci Silinmedi.");
                }
                    
            }
        }

        public void AdresGir()
        {
            Console.WriteLine();
            Console.WriteLine("18-Ögrencinin Adresini Gir ------------------------------------------");
            if (Uygulama.Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
            }
            else
            {
                int no = NoAl();
                BilgiYazdir(no);
                string il = Uygulama.IlkHarfiBuyut(AracGerecler.YaziAl("Il: "));
                string ilce = Uygulama.IlkHarfiBuyut(AracGerecler.YaziAl("Ilce: "));
                string mahalle = Uygulama.IlkHarfiBuyut(AracGerecler.YaziAl("Mahalle: "));
                Uygulama.Okul.AdresEkle(no, il, ilce, mahalle);
                Console.WriteLine();
                Console.WriteLine("Bilgiler sisteme girilmistir.");
            }
        }

        public void KitapGir()
        {
            Console.WriteLine();
            Console.WriteLine("19-Ögrencinin okudugu kitabı gir ------------------------------------");
            if (Uygulama.Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede ögrenci yok.");
            }
            else
            {
                int no = NoAl();
                BilgiYazdir(no);
                Console.Write("Eklenecek Kitabin Adı: ");
                string kitapAdi = Uygulama.IlkHarfiBuyut(Console.ReadLine());
                Uygulama.Okul.KitapEkle(no, kitapAdi);
                Console.WriteLine("Bilgiler sisteme girilmistir.");
            }
        }

        public void NotGir()
        {
            Console.WriteLine();
            Console.WriteLine("20-Not Gir ----------------------------------------------------------");
            int num1 = NoAl();
            BilgiYazdir(num1);
            string ders = AracGerecler.DersGir();
            int num2 = AracGerecler.SayiAl("Eklemek istediginiz not adedi: ");
            for (int i = 1; i <= num2; ++i)
            {
                int not = AracGerecler.SayiAl(i.ToString() + ". Notu girin: ");
                if (not < 0 || not > 100)
                {
                    Console.WriteLine("Girdiğiniz değer 0 ve 100 arasında olmalıdır.");
                    --i;
                }
                else
                    Uygulama.Okul.NotEkle(num1, ders, not);
            }
            Console.WriteLine();
            Console.WriteLine("Bilgiler sisteme girilmistir.");
        }
    }
}

