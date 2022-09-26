using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Banka Hesap

            double bakiye = 1000;
            double asil = 250;
            bool isTrue = true;
            while (isTrue)
            {
                Console.Write("Yapmak istediğiniz işlemi belirtiniz: ");
                string islem = Console.ReadLine();
                if (islem == "bakiye öğrenme")
                {
                    Console.WriteLine($"Hesap bakiyeniz {asil} , esnek hesap bakiyeniz {bakiye}");
                }
                else if (islem == "para yatırma")
                {
                    Console.Write("Yatırmak istediğiniz tutarı giriniz : ");
                    double yatirma = Convert.ToDouble(Console.ReadLine());
                    if (bakiye == 1000)
                    {
                        asil = yatirma + asil;
                    }
                    else if (bakiye < 1000)
                    {
                        bakiye += yatirma;
                        if (bakiye > 1000)
                        {
                            asil = asil + (bakiye - 1000);
                            bakiye = 1000;
                        }
                    }
                    Console.WriteLine($"Yatırdığınız miktar: {yatirma}");
                }
                else if (islem == "para çekme")
                {
                    Console.Write("Çekmek istediğiniz tutarı giriniz : ");
                    double cekme = Convert.ToDouble(Console.ReadLine());
                    if (asil - cekme < 0 && (asil + bakiye) - cekme > 0)
                    {
                        asil = asil - cekme;
                        bakiye = asil + bakiye;
                        asil = 0;
                    }
                    else if (asil - cekme > 0)
                    {
                        asil = asil - cekme;
                    }
                    else
                    {
                        Console.WriteLine("yetersiz bakiye");
                    }
                    Console.WriteLine($"Çektiğiniz miktar: {cekme}");
                }
                else if (islem == "çıkış")
                {
                    isTrue = false;
                }
                else
                {
                    Console.WriteLine("yanlış işlem");
                }
            }
            Console.ReadLine();

            #endregion
        }
    }
}
