using System.Security;

namespace ODEV_OgrenciYonetimUygulaması
{
    internal class Program
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>(); //Global Liste tanımlamak için 2. ve 3. süslü parantez arasına yazılır. Genellikle tanımlamalar Main metot üstünde yazılır.
        static void Main(string[] args)
        {
            //1)	Math sınıfı metodlarından Math.Pow(2,3) metodu ile aynı işlevdeki kendi metodunuzu yazın. (Bu metot pozitif integer değerler için çalışsın ve içinde hiçbir Math sınıfından metot kullanılmasın.)



            //2)	Substring metodunun 2 parametreli versiyonunu kendiniz yazın.
            //(Bu metot için string veri de parametreden gönderilsin ve hiçbir System sınıfından string metot kullanılmasın.)

            //Console.Write("Yazıyı girin: ");
            //string soz = Console.ReadLine();

            //Console.Write("Başlangıç sayısını girin: ");
            //int basla = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Başlangıç sayısından itibaren yazılacak karakter sayısını girin: ");
            //int al = Convert.ToInt32(Console.ReadLine());

            //ParcaAl(soz, basla, al);


            SahteVeriGir();
            Giris();
            SecimAl();
           



        }
        static void ParcaAl(string soz, int basla, int al)
        {
            for (int i = basla; i < basla + al; i++)
            {
                Console.Write(soz[i]);
            }
        }
        static int UstunuAl(int sayi, int us)
        {
            int sonuc = sayi;
            for (int i = 2; i <= us; i++)
            {
                sonuc *= sayi;
            }
            return sonuc;
        }
        static void Giris()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması ");
            Console.WriteLine("1- Öğrenci Ekle (E)");
            Console.WriteLine("2- Öğrenci Listele (L)");
            Console.WriteLine("3- Öğrenci Sil (S)");
            Console.WriteLine("4- Çıkış (X)");
        }
        static void SecimAl()
        {
            int sayac = 10;
            do
            {
                Console.Write("Seçiminiz: ");
                string sec = Console.ReadLine().ToUpper();
                string sembol = "1234ELSX";
                if (sembol.IndexOf(sec) == -1)
                {
                    sayac--;
                    if (sayac != 0)
                    {
                        Console.WriteLine("Hatalı giriş yapıldı.");
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                    }
                }
                else
                {
                    switch (sec)
                    {
                        case "1":
                        case "E":
                            OgrenciEkle(); break;
                        case "2":
                        case "L":
                            OgrenciListele(); break;
                        case "3":
                        case "S":
                            OgrenciSil(); break;
                        case "4":
                        case "X":
                            Cikis(); break;
                    }
                }
            } while (sayac != 0);
        }
        static void OgrenciEkle()
        {
            Console.WriteLine("1- Öğrenci Ekle ----------");
            Console.WriteLine(ogrenciler.Count + 1 + ". Öğrencinin");
            bool tekrar = true;
            Ogrenci o1 = new Ogrenci();
            do
            {

                Console.Write("No: ");
                o1.No = Convert.ToInt32(Console.ReadLine());
                foreach (Ogrenci x in ogrenciler)
                {
                    if (x.No == o1.No)
                    {
                        Console.WriteLine("Bu öğrenci numarası atanmıştır. Lütfen başka numara atayınız.");
                        tekrar = true;
                        break;
                    }
                    else
                    {
                        tekrar = false;

                    }
                    
                }
            } while (tekrar);

            Console.Write("Adı: ");
            o1.Ad = IlkHarfiBuyut(Console.ReadLine());
            Console.Write("Soyadı: ");
            o1.Soyad = IlkHarfiBuyut(Console.ReadLine());
            Console.Write("Şubesi: ");
            o1.Sube = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.Write("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H) ");
            string giris = Console.ReadLine().ToUpper();
            if (giris == "E")
            {
                Console.WriteLine("Öğrenci eklendi.");
                ogrenciler.Add(o1);
            }
            else if (giris == "H")
            {
                Console.WriteLine("Öğrenci eklenmedi.");
            }


        }
        static string IlkHarfiBuyut(string veri)
        {
            veri = veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
            return veri;
        }

        static void OgrenciListele()
        {
            Console.WriteLine("2 - Öğrenci Listele------------");

            if (ogrenciler.Count > 0)
            {

                Console.WriteLine("Şube".PadRight(5)+"No".PadRight(5)+"Ad".PadRight(10)+"Soyad".PadRight(10));
                Console.WriteLine("----------------------------------");
                foreach (Ogrenci item in ogrenciler)
                {
                    Console.WriteLine((item.Sube).PadRight(5) + (item.No).ToString().PadRight(5) + (item.Ad).PadRight(10) + (item.Soyad).PadRight(10));
                }
            }
            else
            {
                Console.WriteLine("Gösterilecek öğrenci yok");
            }


        }
        static void OgrenciSil()
        {
            Console.WriteLine("3 - Öğrenci Sil----------");
            if (ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
                return;
            }
                Console.WriteLine("Silmek istediğiniz öğrencinin");
                Console.Write("No: ");
                int no = Convert.ToInt32(Console.ReadLine());
                foreach (Ogrenci x in ogrenciler)
                {
                    if (x.No == no)
                    {
                        Console.WriteLine("Adı: " + x.Ad);
                        Console.WriteLine("Soyadı: " + x.Soyad);
                        Console.WriteLine("Şubesi: " + x.Sube);
                        Console.WriteLine();
                        Console.Write("Öğrenciyi silmek istediğinize emin misiniz? (E / H)   ");
                        string giris = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        if (giris == "e")
                        {
                            Console.WriteLine("Öğrenci silindi.");
                            ogrenciler.Remove(x);
                        }
                        else if (giris == "h")
                        {
                            Console.WriteLine("Öğrenci silinmedi.");
                        }
                        break;
                    }
                }
           
        }
        static void Cikis()
        {
            Environment.Exit(4);
        }
        static void SahteVeriGir()
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.No = 1;
            ogrenci1.Ad = "Ahmet";
            ogrenci1.Soyad = "Melik";
            ogrenci1.Sube = "A";
            ogrenciler.Add(ogrenci1);

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.No = 2;
            ogrenci2.Ad = "Mehmet";
            ogrenci2.Soyad = "Yıldırım";
            ogrenci2.Sube = "A";
            ogrenciler.Add(ogrenci2);

            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.No = 3;
            ogrenci3.Ad = "Arif";
            ogrenci3.Soyad = "Susam";
            ogrenci3.Sube = "B";
            ogrenciler.Add(ogrenci3);
        }
    }
}
