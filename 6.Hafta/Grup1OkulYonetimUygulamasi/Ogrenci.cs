using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup1OkulYonetimUygulamasi
{
    internal class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public SUBE Sube { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public Adres Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Aciklama;
        public List<DersNotu> Notlar { get; set; } = new List<DersNotu>();
        public double Ortalama
        {
            get
            {
                double ortalama = Notlar.Sum<DersNotu>(a => a.Not) / Notlar.Count;
                return ortalama;
            }
        }
        public List<string> Kitaplar { get; set; } = new List<string>();
        public int KitapSayisi 
        { 
            get
            {
                return Kitaplar.Count;
            } 
        }
        public void AdresEkle(string il, string ilce, string semt)
        {
            if (Adres == null)
               Adres = new Adres();
            Adres.Il = il;
            Adres.Ilce = ilce;
            Adres.Semt = semt;
        }
        public void AdresEkle(string il, string ilce)
        {
            if (Adres == null)
                Adres = new Adres();
            Adres.Il = il;
            Adres.Ilce = ilce;
        }
        public void KitapEkle(string kitap)
        {
            if (Kitaplar == null)
                Kitaplar = new List<string>();
                Kitaplar.Add(kitap);
        }
    }
    public enum SUBE
    {
        Empty, A, B, C
    }
    public enum CINSIYET
    {
        Empty, Kiz, Erkek
    }
   
}
