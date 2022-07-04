using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Üç_giriş_haklı_login_denemesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hak_sayisi = 3;

            while (true)
            {
                Console.WriteLine("Kullanıcı adını giriniz :");
                string kullanici_adi = Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz :");
                string sifre = Console.ReadLine();

                if (kullanici_adi == "hakan" && sifre == "123")
                {
                    Console.WriteLine("Tebrikler! Başarılı şekilde giriş yaptınız!");
                    break;
                }

                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış ");

                    if (hak_sayisi > 0)
                    {
                        hak_sayisi -= 1;
                    }

                    if (hak_sayisi == 0)
                    {
                        Console.WriteLine("Giriş hakkınız dolmuştur. Lütfen çağrı merkezimiz ile iletişim sağlayınız.");
                        break;
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
