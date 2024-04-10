using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup1OkulYonetimUygulamasi
{
    internal class Adres
    {
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }

        public Adres(string il, string ilce)
        {
            Il = il;
            Ilce = ilce;
        }
        public Adres(string il, string ilce, string semt)
        {
            Il = il;
            Ilce = ilce;
            Semt = semt;
        }
        public Adres()
        {
            
        }
    }
}
