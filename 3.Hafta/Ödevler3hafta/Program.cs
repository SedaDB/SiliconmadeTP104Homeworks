using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace Ödevler3hafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] asalSayilar2 = new int[]
            //    {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53};


            //int[] asal = new int[15]; //0'dan 14'e kadar asalSayilar[i]

            //for (int i = 0; i < asal.Length; i++)
            //{
            //    asal[i] = AsalSayilar(i);
            //    Console.Write(asal[i] + " ");
            //}
            // 2. Soru
            //Aşağıdaki ekran çıktısı verilen soruyu switch-case yapısını kullanarak yapın. Her aritmetik işlem, geriye değer döndüren parametreli metotlar ile yapılsın. Programın sonunda 0 girişi yapıldığı durumda program başa dönerek tekrar çalışmalıdır. 0 girişi yapılmadığında ise program başa dönmeyip “Devam etmek için 0’a basın” ifadesi tekrar edilmelidir. Ayrıca “Seçiminiz”  kısmında 5’e basılırsa program sonlanmalıdır. Programa ait tüm metotları aşağıdaki boşluğa yazın.
            // HesapMakinesi();
            // 3. Soru
            // 20 elemanlı bir tam sayı dizisine 7’den itibaren 7’nin katlarını ekleyen ve bu sayıları yan yana ekrana yazdıran void metodu yazın kodunu yazın.
            //YediserSayma();
            // 5. Soru
            // Rastgele değerde 10 elemanlı bir sayı dizisi oluşturun. Bu dizi içerisindeki tek sayıları başka bir diziye ekleyip, çift sayıları da bambaşka bir diziye ekleyen programı yazın.  
            // Bir dizinin elemanını aralarına boşluk koyarak yan yana yazdıran metodu yazın.Bu metot ile bu sorudaki 3 diziyi de ekrana yazdırın.
            RastgeleSayılarTekCift();


        }
        static void DiziYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine();
        }
        static void RastgeleSayılarTekCift()
        {
            Console.Write("Sayılar: ");
            Random rnd = new Random();
            int[] rastSayilar = new int[10];
            int sayacTek = 0, sayacCift = 0;
            for (int i = 0; i < rastSayilar.Length; i++)
            {
                rastSayilar[i] = rnd.Next(0, 1000);
                Console.Write(rastSayilar[i] + " ");
                if (rastSayilar[i] % 2 == 0)
                {
                    sayacCift++;
                }
                else
                {
                    sayacTek++;
                }
            }

            Console.WriteLine();
            int[] tekSayilar = new int[sayacTek];
            int[] ciftSayilar = new int[sayacCift];
            int tek = 0, cift = 0;

            for (int i = 0; i < rastSayilar.Length; i++)
            {
                if (rastSayilar[i] % 2 == 0)
                {
                    ciftSayilar[cift] = rastSayilar[i];
                    cift++;
                }
                else
                {
                    tekSayilar[tek] = rastSayilar[i];
                    tek++;
                }
            }
            Console.Write("Tek Sayılar: ");
            for (int i = 0; i < tekSayilar.Length; i++)
            {
                Console.Write(tekSayilar[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Çift Sayılar: ");
            for (int i = 0; i < ciftSayilar.Length; i++)
            {
                Console.Write(ciftSayilar[i] + " ");
            }

        }
        
        static void YediserSayma()
        {
            int[] yediser = new int[20];
            for (int i = 0; i < yediser.Length; i++)
            {
                yediser[i] = 7 * i + 7;
                Console.Write(yediser[i] + " ");
            }
        }
        static void HesapMakinesi()
        {
            Console.Write("1. Sayıyı yazın: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı yazın: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplama için 1'e basın");
            Console.WriteLine("Çıkartma için 2'ye basın");
            Console.WriteLine("Çarpma için 3'e basın");
            Console.WriteLine("Bölme için 4'e basın");
            Console.WriteLine("Çıkış için 5'e basın");
            Console.Write("Seçiminiz: ");
            int islem = Convert.ToInt32(Console.ReadLine());

            Console.Write("İşlem Sonucu: ");
            switch (islem)
            {

                case 1: Console.Write(Toplama(sayi1, sayi2)); break;
                case 2: Console.Write(Cikartma(sayi1, sayi2)); break;
                case 3: Console.Write(Carpma(sayi1, sayi2)); break;
                case 4: Console.Write(Bolme(sayi1, sayi2)); break;
                case 5: Cikis(); break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Hatalı seçim yaptınız. Yeniden deneyin.");
                    Tekrar(); break;
            }
            Console.WriteLine();
            Console.WriteLine("Devam etmek için 0'a basın.");
            string tekrar = Console.ReadLine();
            if (tekrar == "0")
            {
                Tekrar();
            }
            else
            {
                Cikis();
            }
        }
        static int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int Cikartma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        static int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        static float Bolme(int sayi1, int sayi2)
        {
            return (float)sayi1 / sayi2;
        }
        static void Cikis()
        {
            Environment.Exit(5);
            
        }
        static void Tekrar()
        {
            while (true)
            {
                HesapMakinesi();
            };
        }
        //metotlar 2. ve 3. süslü parantezin arasına yazılıyor.
        static int AsalSayilar(int sira)
        {

            int sayi = 3;
            int sayac = 0;
            int sayac2 = 0;

            do
            {

                sayac = 0;
                if (sayac2 == sira)
                {
                    break;
                }
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                    }

                }
                if (sayac == 0)
                {
                    sayac2++;
                }
                sayi++;
            } while (true);
            
            return sayi-1;

        }

    }
}
