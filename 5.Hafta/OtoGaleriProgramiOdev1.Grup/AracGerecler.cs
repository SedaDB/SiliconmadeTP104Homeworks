using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriProgramiOdev1.Grup
{
    internal class AracGerecler
    {
       
        public static bool PlakaMi(string plaka)
        {
            int sonuc;
            if (plaka.Length > 6 && plaka.Length < 10 && int.TryParse(plaka.Substring(0, 2), out sonuc) && AracGerecler.HarfMi(plaka.Substring(2, 1)) && (plaka.Length == 7
                && int.TryParse(plaka.Substring(3), out sonuc) || plaka.Length < 9 && AracGerecler.HarfMi(plaka.Substring(3, 1))
                && int.TryParse(plaka.Substring(4), out sonuc) || AracGerecler.HarfMi(plaka.Substring(3, 2)) && int.TryParse(plaka.Substring(5), out sonuc)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool HarfMi(string veri)
        {
            veri = veri.ToUpper();
            for (int i = 0; i < veri.Length; ++i)
            {
                int num = (int)veri[i];
                if (num < 65 || num > 90)
                {
                    return false;

                }
            }
            return true;
        }

        public static string YaziAl(string yazi)
        {
            while (true)
            {
                try
                {
                    Console.Write(yazi);
                    string giris = Console.ReadLine().ToUpper();
                    if (int.TryParse(giris, out int _))
                    {
                        throw new Exception("Giriş tanımlanamadı. Tekrar deneyin.");

                    }
                    return giris;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static int SayiAl(string mesaj)
        {
            while (true)
            {
                try
                {
                    Console.Write(mesaj);
                    string giris = Console.ReadLine().ToUpper();
                    int result;
                    if (int.TryParse(giris, out result))
                    {
                        return result;

                    }
                    if (giris == "X")
                    {
                        throw new Exception("Çıkış");

                    }
                    throw new Exception("Giriş tanımlanamadı. Tekrar deneyin.");
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Çıkış")
                    {
                        throw new Exception("Çıkış");

                    }
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static string PlakaAl(string plaka)
        {
            while (true)
            {
                try
                {
                    Console.Write(plaka);
                    string giris = Console.ReadLine().ToUpper();
                    if (giris == "X")
                    {
                        return "X";

                    }
                    return AracGerecler.PlakaMi(giris) ? giris : throw new Exception("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static string AracTipiAl()
        {
            Console.WriteLine("Araç tipi: ");
            Console.WriteLine("SUV için 1");
            Console.WriteLine("Hatchback için 2");
            Console.WriteLine("Sedan için 3");
            while (true)
            {
                Console.Write("Araba Tipi: ");
                string giris = Console.ReadLine().ToUpper();
                if (!(giris == "X"))
                {
                    switch (giris)
                    {
                        case "1":
                            return "SUV";
                        case "2":
                            return "Hatchback";
                        case "3":
                            return "Sedan";
                        default:
                            Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                            continue;
                    }
                }
                else
                    break;
            }
            throw new Exception("Çıkış");

        }
    }
}
