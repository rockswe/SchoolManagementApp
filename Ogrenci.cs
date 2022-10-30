using System;
using System.Collections.Generic;
using System.Linq;

namespace OkulYonetimUygulamasi
{
    internal class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;
        public CINSIYET Cinsiyet;
        public SUBE Sube;
        public string Aciklama;
        public Adres Adresi;
        public List<string> Kitaplar;
        public List<DersNotu> Notlar = new List<DersNotu>();

        public double Ortalama
        {
            get
            {
                double num = (double)this.Notlar.Sum<DersNotu>((Func<DersNotu, float>)(a => a.Not));
                return num == 0.0 ? 0.0 : num / (double)this.Notlar.Count;
            }
        }

        public int KitapSayisi => this.Kitaplar == null ? 0 : this.Kitaplar.Count;

        public void AdresEkle(string il, string ilce, string mahalle)
        {
            if (this.Adresi == null)
                this.Adresi = new Adres();
            this.Adresi.Il = il;
            this.Adresi.Ilce = ilce;
            this.Adresi.Mahalle = mahalle;
        }

        public void KitapEkle(string kitap)
        {
            if (this.Kitaplar == null)
                this.Kitaplar = new List<string>();
            this.Kitaplar.Add(kitap);
        }
    }
}