using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            Console.WriteLine("*********YEMEK KATAGORİLERİ*******");
            Console.WriteLine();
            Console.WriteLine("1-ÇORBALAR");
            Console.WriteLine("2-ANA YEMEKLER");
            Console.WriteLine("3-SOĞUK BAŞLANGIÇLAR");
            Console.WriteLine("4-SALATALAR");
            Console.WriteLine("5-TATLILAR");
            Console.WriteLine("6-İÇECEKLER");
            Console.WriteLine();
            Console.WriteLine("*********YEMEK KATAGORİLERİ*******");
            #endregion
            #region STRING DEĞİŞKENLER
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Semih";
            customerSurname = "Kılıçsoy";
            customerPhone = "+90 555 555 19 03";
            customerEmail = "kılıcsoy@gmail.com";
            district = "Beşiktaş";
            city = "İstanbul";

            Console.WriteLine("*****REZERVASYON KARTI****");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            customerName = "Necip";
            customerSurname = "Uysal";
            customerPhone = "+90 555 190 35 55";
            customerEmail = "uysal@gmail.com";
            district = "Bakırköy";
            city = "İstanbul";

            Console.WriteLine("--------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("--------------------------\n");



            #endregion
            #region INT DEĞİŞKENLER
            int hamburgerPrice = 300;
            int cokePrice = 35, waterPrice = 10, friesPrice = 50;
            int pizzaPrice = 250, lemonadePrice = 30;
            Console.WriteLine("******RESTORAN MENÜ FİYATI******");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine("-------------------------------");
            int hamburgerCount, cokeCount, waterCount, friesCount;
            int pizzaCount, lemonadeCount;

            int totalHamburgerPrice, totalPizzaPrice, totalLemonadePrice; ;
            int totalCokePrice, totalWaterPrice, totalFriesPrice;
            hamburgerCount = 7;
            cokeCount = 0;
            waterCount = 3;
            friesCount = 7;
            pizzaCount = 5;
            lemonadeCount = 4;


            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            Console.WriteLine("\nHamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL\n");
            int totalFiyat = totalLemonadePrice + totalHamburgerPrice + totalCokePrice + totalFriesPrice + totalPizzaPrice + totalWaterPrice;
            Console.WriteLine("Toplam Ücret: " + totalFiyat);
            #endregion


        }
    }
}
