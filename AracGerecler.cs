using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi
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
            Console.Write(yazi);
            DateTime result;
            return DateTime.TryParse(Console.ReadLine(), out result) ? result : DateTime.MinValue;
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
                            goto label_6;
                    }
                    else
                        goto label_4;
                }
                else
                    break;
            }
            return CINSIYET.Empty;
        label_4:
            return CINSIYET.Kiz;
        label_6:
            return CINSIYET.Erkek;
        }

        public static SUBE SubeAl(string yazi)
        {
            while (true)
            {
                Console.Write(yazi);
                string str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    if (!(str.ToUpper() == "A"))
                    {
                        if (!(str.ToUpper() == "B"))
                        {
                            if (!(str.ToUpper() == "C"))
                                Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                            else
                                goto label_8;
                        }
                        else
                            goto label_6;
                    }
                    else
                        goto label_4;
                }
                else
                    break;
            }
            return SUBE.Empty;
        label_4:
            return SUBE.A;
        label_6:
            return SUBE.B;
        label_8:
            return SUBE.C;
        }

        public static string DersGir()
        {
            Console.Write("Not eklemek istediğiniz dersi giriniz: ");
            return Console.ReadLine().ToUpper();
        }
    }
}

