using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup1OkulYonetimUygulamasi
{
    internal class AracGerecler
    {
        public static int SayiAl(string mesaj)
        {
            int result;
            while (true)
            {
                Console.Write(mesaj);
                if (!int.TryParse(Console.ReadLine(), out result))
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                else
                    break;
            }
            return result;
        }

        public static string YaziAl(string yazi)
        {
            string s;
            while (true)
            {
                Console.Write(yazi);
                s = Console.ReadLine();
                if (int.TryParse(s, out int _))
                    Console.WriteLine("Hatalı islem tekrar girin.");
                else if (string.IsNullOrEmpty(s))
                    Console.WriteLine("Veri girişi yapılmadı tekrar deneyin.");
                else
                    break;
            }
            return s;
        }

        public static DateTime TarihAl(string yazi)
        {
            DateTime result;
            while (true)
            {
                Console.Write(yazi);
                if (!DateTime.TryParse(Console.ReadLine(), out result))
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                else
                    break;
            }
            return result;
        }

        public static DateTime TarihAlGuncelle(string yazi)
        {
            while (true)
            {

            try
            {
                Console.Write(yazi);
                DateTime result;
                if (DateTime.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    throw (new Exception("Hatalı giriş yapıldı."));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            }
            
            
        }

        public static CINSIYET KizMiErkekMi(string yazi)
        {
            while (true)
            {
                Console.Write(yazi);
                string str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    if (!(str.ToUpper() == "K"))
                    {
                        if (!(str.ToUpper() == "E"))
                            Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                        else
                            return CINSIYET.Kiz;
                    }
                    else
                        return CINSIYET.Erkek;
                }
                else
                    break;
            }
            return CINSIYET.Empty;
                   
        }

        public static SUBE SubeAl(string yazi)
        {
            while (true)
            {
                Console.Write(yazi);
                string str = Console.ReadLine().ToUpper();
                if (!string.IsNullOrEmpty(str))
                {
                    if (!(str == "A"))
                    {
                        if (!(str == "B"))
                        {
                            if (!(str == "C"))
                                Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                            else
                                return SUBE.C;
                        }
                        else
                            return SUBE.B;
                    }
                    else
                        return SUBE.A;
                }
                else
                    break;
            }
            return SUBE.Empty;

            
        }

        public static string DersGir()
        {
            Console.Write("Not eklemek istediğiniz dersi giriniz: ");
            return Console.ReadLine().ToUpper();
        }
    }
}
