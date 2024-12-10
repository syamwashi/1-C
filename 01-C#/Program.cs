using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Hello World");
            //Console.Write("salam");

            //Console.WriteLine("***** KOKOREÇ DÜNYASI ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-İcecekler");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("4-Kokoreç miktarları");
            //Console.WriteLine();
            //Console.WriteLine("***** KOKOREÇ DUNYASİ *****");
            #endregion
            #region String Değişkenler
            //string
            //Değişken_türü değişken_adı;

            // string name;
            // name = "YUSUF";
            //Console.Write(name);
            //#endregion

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "kurak";
            //customerPhone = "90 123 456 7890";
            //customerEmail = "alikurak@gmail.com";
            //district = "Silivri";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone );
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("-----------------------------------");

            //Console.WriteLine(); 

            //customerName = ("Mehmet");
            //customerSurname = ("Sert");
            //customerPhone = ("+90 505 902 4872");
            //customerEmail = ("testermehmet@gmail.com");
            //district = ("Sapanca");
            //city = ("Muğla");


            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("-----------------------------------");





            #endregion
            #region Int Değişkenler

            //int

            //int number = 31;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;


            //Console.WriteLine("*****Restoran Menü Fiyatı *****");
            //Console.WriteLine();
            //Console.WriteLine("Hamburger--------: " + hamburgerPrice + "TL");
            //Console.WriteLine("Kola-------------: " + cokePrice + "TL");
            //Console.WriteLine("Su---------------: " + waterPrice + "TL");
            //Console.WriteLine("Kızartmalık------: " + friesPrice + "TL");
            //Console.WriteLine("Pizza------------: " + pizzaPrice + "TL");
            //Console.WriteLine("Limonata---------: " + lemonadePrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("*****Restoran Menü Fiyatı *****");
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;



            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //int totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            //int totalcokePrice = cokeCount * cokePrice;
            //int totalwaterPrice = waterCount * waterPrice;
            //int totalfriesPrice = friesCount * friesPrice;
            //int totalpizzaPrice = pizzaCount * pizzaPrice;
            //int totallemonadePrice = lemonadeCount * lemonadePrice;

            // Console.WriteLine(); 

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Hamburger:    "+ totalhamburgerPrice+"TL");
            //Console.WriteLine("Kola:         "+ totalcokePrice + "TL");
            //Console.WriteLine("Su:           "+ totalwaterPrice + "TL");
            //Console.WriteLine("Kızartma:     "+ totalfriesPrice + "TL");
            //Console.WriteLine("Limonata:     "+ totallemonadePrice + "TL");

            //int totalPrice = totalhamburgerPrice + totalcokePrice + totalwaterPrice + totalfriesPrice + totalpizzaPrice + totallemonadePrice;

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Toplam Tutar:" + totalPrice + "TL");





            #endregion
            #region Variables (Değişkenler)
            #endregion
            #region Double Değişkenler

            //Double number =94.25;
            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice =14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("Elma Birim Fiyatı:-----------" + applePrice +"TL");
            //Console.WriteLine("Portakal Birim Fiyatı:-------" + applePrice + "TL");
            //Console.WriteLine("Çilek Birim Fiyatı:----------" + applePrice + "TL");
            //Console.WriteLine("Patates Birim Fiyatı:--------" + applePrice + "TL");
            //Console.WriteLine("Domates Birim Fiyatı:--------" + applePrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram= 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.869;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice= strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma-----" + applePrice + " / Gramaj:" + appleGram + "gr" +" / Toplam Tutar:" + appleTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Portakal-" + orangePrice + " / Gramaj:" + orangeGram + " gr" + "  / Toplam Tutar:" + orangeTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Çilek----" + strawberryPrice + "    / Gramaj:" + strawberryGram + " gr" + "  / Toplam Tutar:" + strawberryTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Patates--" + potatoPrice + "  / Gramaj:" + potatoGram + "gr" + " / Toplam Tutar:" + potatoTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Domates--" + tomatoPrice + "  / Gramaj:" + tomatoGram + "gr" + " / Toplam Tutar:" + tomatoTotalPrice + "TL");


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("  Alışveriş Toplam Tutar: "+ shoppingTotalPrice + "TL");




            #endregion
            #region Char Değişkenleri
            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);









            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CShap Hava Yolları Yolcu Bilgisi ****");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;


            //Console.Write("Yolcu Adı:  ");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadı:  ");
            //passengerSurname= Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict= Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " / Yolcu: " + passengerName + " " + passengerSurname + " / " +passengerDistrict + " / " + passengerAge + " ");





            #endregion
            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, cahirPrice, tvPrice,
            //shoePrice = 1000;
            //computerPrice = 20000;
            //cahirPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı saysını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar saysını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye saysını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon saysını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoePrice + computerCount * computerPrice + tvCount * tvPrice + cahirPrice * chairCount;

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion
            #region Klavyeden Ondalıkı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz:  ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz:  ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz:  ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);            



            #endregion
            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);








            #endregion







            Console.Read();
        }
    }
}




//Yazdırma Komutları