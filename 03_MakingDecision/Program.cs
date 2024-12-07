using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE
            //Console.WriteLine("şifreyi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "abc")
            //{
            //    Console.WriteLine("doğru şifre");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış şifre");
            //}
            //Console.WriteLine("başkenti giriniz: ");
            //string capital = Console.ReadLine();
            //Console.WriteLine("ülkeyi giriniz: ");
            //string country = Console.ReadLine();
            //if (capital == "bursa" & country == "türkiye")
            //{
            //    Console.WriteLine("bilgiler hatalı");
            //}
            //Console.WriteLine("sayıyı giriniz: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num == 7)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}
            //Console.WriteLine("sınav 1= ");
            //int exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav 2= ");
            //int exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav 3= ");
            //int exam3 = int.Parse(Console.ReadLine());
            //int average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınav ortalamsı: " + average);
            //string result = "hata";
            //if (average > 0 & average <= 50)
            //{
            //    result = "sonuç kötü";
            //}
            //if (average > 50 & average >= 80)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 80)
            //{
            //    result = "sonuç iyi";
            //}Console.WriteLine(result);
            //Console.Write("şehir girişi yapınız: ");
            //string city = Console.ReadLine();
            //if (city == "bursa" | city == "sinop" | city == "istanbul" | city == "bayburt")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}
            //Console.Write("kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("kullanıcı adı geçerli değil");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}
            #endregion
            #region MOD İŞLEMLERİ
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Write(" 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write(" 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);
            //Console.Write("sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion
            #region CHAR DEĞİŞKENLERİ KARAR YAPILARI
            //char team;
            //Console.Write("takımınızın sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'e' | team == 'E')
            //{
            //    Console.WriteLine("Eczacıbaşı");
            //}
            //if (team == 'v' | team == 'V')
            //{
            //    Console.WriteLine("Vakıfbank");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion
            #region Örnek Uygulama Projesi
            //Console.WriteLine("C# Eğitim Kampı Restoran");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();
            //string menuItem;
            //Console.Write("detayı görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Etli Pilav");
            //    Console.WriteLine("4- Fırında Makarna");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Kremalı Tavuk Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margarita");
            //    Console.WriteLine("3   k- Tavuklu Pizza");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Profiterol");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //}
            #endregion
            #region SWİTCH CASE
            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthnumber = int.Parse(Console.ReadLine());
            //switch (monthnumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi yaptınız"); break;
            //}
            #endregion
            #region Hesap Makinesi
            int number1, number2, result;
            char symbol;
            Console.Write("Lütfen 1. sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen yapıcağınız işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
                default: Console.Write("Hatalı veri girişi."); break;
            }
         
            #endregion
            Console.Read();
        }
    }
}
