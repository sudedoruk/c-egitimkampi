// See https://aka.ms/new-console-template for more information
//***********DERS 1***************
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
string customerEmail,district,city;

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
Console.WriteLine("----Hamburger: "+hamburgerPrice+ " TL");
Console.WriteLine("----Pizza: "+pizzaPrice+" TL");
Console.WriteLine("----Kola: "+cokePrice+" TL");
Console.WriteLine("----Limonata: "+lemonadePrice+ " TL");
Console.WriteLine("----Kızartma: "+friesPrice+" TL");
Console.WriteLine("----Su: "+waterPrice+" TL");
Console.WriteLine("-------------------------------");
int hamburgerCount,cokeCount,waterCount,friesCount;
int pizzaCount, lemonadeCount;

int totalHamburgerPrice, totalPizzaPrice, totalLemonadePrice; ;
int totalCokePrice,totalWaterPrice,totalFriesPrice;
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
Console.WriteLine("Kola Tutarı: " +  totalCokePrice + " TL");
Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL\n");
int totalFiyat = totalLemonadePrice + totalHamburgerPrice + totalCokePrice + totalFriesPrice + totalPizzaPrice + totalWaterPrice;
Console.WriteLine("Toplam Ücret: " + totalFiyat);
#endregion
//***********DERS 2***************
#region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL");

            #endregion

#region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"  ' 

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

#region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber +  " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " "  + passengerDistrict  + " / " + passengerCity + " " + passengerAge);

            #endregion

#region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " +  totalPrice);

            #endregion

#region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

#region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion        