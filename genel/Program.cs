using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ekrana değeri yazdırır.
            //Console.Write("Merhaba Dünya");

            /*Ekrana değeri yazdırır. Alt satıra iner.*/
            //Console.WriteLine("Merhaba Dünya");

            // Karakter seti
            //\n karakter bir alt satıra inme işine yarar
            // Console.Write("Merhaba Dünya\n");

            //\r karakter satır başı işine yarar
            //Console.Write("Merhaba Dünya\r");

            //\\ karakter ters slaş yazma işine yarar
            //Console.Write("Merhaba Dünya\\");

            ////\" karakter " işareti yazma işine yarar
            //Console.Write("\"Merhaba Dünya\"");

            ////\' karakter ' işareti yazma işine yarar
            //Console.Write("'Merhaba Dünya\'");

            ////Arkplan rengini değiştirme
            //Console.BackgroundColor = ConsoleColor.Red;
            ////Yazı rengini değiştirme
            //Console.ForegroundColor = ConsoleColor.Blue;

            //Console.WriteLine("Merhaba Dünya");
            //Console.ReadKey();
            //Console.Read();

            //Consoldan çıkış için soru sorma ve çıkma işlemi
            //Console.WriteLine("Çıkmak istediğinizden emin misiniz? E/H");
            //string Cevap = Console.ReadLine();
            //if (Cevap == "E")
            //{
            //    Environment.Exit(0);
            //}else
            //{
            //    Console.ReadLine();
            //}

            /*Değişkenler*/
            //Değişkenin Türü Değişkenin Adı=Değişkenin değeri;            
            //string Ad, Soyad;
            //Ad = "Abdullah";
            //Soyad = "Akyol";
            ////Değer tipli örnek
            //int a = 5;
            //int b;
            //b = a;
            //a = 10;

            ////Referans Tipli Değişkenler
            //string[] Harfler = { "a", "b", "c", "d" };
            //string[] Harfler2 = Harfler;
            //Harfler[0] = "e";

            /*Değişken türleri*/
            /*Tamsayı değişken türleri*/
            //byte Sayi = 1; //8 bitlik yer kaplar. 0-255 arasında değer alır.
            //sbyte Sayi = -128;//Hafızada 8 bitlik yer kaplar. -128 ile 127 arasında değer alır.
            //short Sayi = -32767;//Hafızada 16 bitlik yer kaplar. -32767 ile 32767 arasında değer alır.
            //ushort Sayi = 65535;//Hafızada 16 bitlik yer kaplar. 0-65535 arasında değer alır.
            //int Sayi = 10;//Hafızada 32 bitlik yer ayırır. 
            //uint Sayi = 10;//Hafızada 32 bitlik yer kaplar. İşaretsiz tamsayıdır.
            //long Sayi = -10;//Hafızada 64 bitlik yer kaplar. İşaretli tamsayıdır.
            //ulong Sayi = 10;//Hafızada 64 bitlik yer kaplar. İşaretsiz tamsayıdır.

            /*Ondalıklı sayı değişken türleri*/
            //float Sayi = -10.5f;//Hafızada 32 bitlik yer kaplar. İşaretli ondalıklı sayıdır.
            //double Sayi = -10.5;//Hafızada 64 bitlik yer kaplar. İşaretli ondalıklı sayıdır.
            //decimal Sayi = -25.1m;//Hafızada 128 bitlik yer kaplar. İşaretli ondalıklı sayıdır.

            /*Karakter değeri tutan değişkenler*/
            //char Harf = 'A';//Hafızada 16 bitlik yer kaplar. Unicode tek karakter için kullanılır.

            /*Doğru veya yanlış değeri tutan değişkenler*/
            //bool Dogrumu = true;//Doğru vey yanlış değeri barındıran değişken
            //Dogrumu = false;


            /*Referans tipili değişken türleri*/
            //string Ad = "Abdullah";//Metinsel karakter dizisini barındırır.
            //object Soyad = true;//genel veri türünü kapsar. Yazma anında hata varsa hataları göstermez.
            ////Çalışma anında hataları verir.
            //Soyad = "Akyol";
            //dynamic Soyad = 25;//Genel veri türünü kapsar. yazma ve çalışma anında hata varsa ahatyı göstermez.
            //var Soyad = true;//İçine atanan değere göre türürn belirlendiği değişken türüdür.

            //string Adim = "Abdullah", Soyadim = "Akyol", Memleket = "Muş";
            //Console.WriteLine(Adim);
            //Adim = "1 "+Adim;
            //Console.WriteLine(Adim);
            //Adim = $"2 {Adim}";
            //Console.WriteLine(Adim);
            //Adim = string.Format(" {0} {1}", Adim, Soyadim);
            //Console.WriteLine(Adim);
            //byte Plaka = 49;
            //byte Yas = 32;
            //byte Yil = 10;
            //int Toplam = Yas + Yil;
            //bool AskerlikDurumu = true;
            //Console.WriteLine(Adim);
            //Console.WriteLine(Soyadim);
            //Console.WriteLine(Memleket);
            //Console.WriteLine(Plaka);
            //Console.WriteLine(Toplam);
            //Console.WriteLine(AskerlikDurumu);

            /*20.10.2022*/
            // Değişkenlerin varsayılan değerleri
            //Default anahtar kelimesi ile bakılabiliniyo
            //Console.WriteLine(default(double));

            ////nullable özelliği
            //byte? Sayi = null;

            //Console.WriteLine(Sayi);

            ////Kilo bilgisini tutacak değişken
            //int Kilo=81;

            //Kilo =Kilo+ 71;
            //Console.WriteLine(Kilo);

            //Sabitler 
            //const anahtar sözcüğü
            //const string Yazilimci = "Abdullah Akyol";

            ////Değişken Tipini Öğrenme
            ////GetType ve Typeof metotları
            //var Degisken = 10.7;
            ////değişkeninadı.GetYpe();
            //string Cevap = Degisken.GetType() == typeof(decimal) ?
            //      "değerimiz Decimal" :
            //      "Değerimiz bilinmiyor";
            //Console.WriteLine(Cevap);

            ///*Klavyeden değer Girme*/
            //Console.Write("Adınız: ");
            //string Ad = Console.ReadLine();
            //Console.Write("Soyadınız: ");
            //string Soyad = Console.ReadLine();
            //Console.Write("Ülkeniz: ");
            //string Ulke = Console.ReadLine();
            //Console.Write("İliniz: ");
            //string İl = Console.ReadLine();
            //Console.Write("Yaşınız: ");
            //string Yas = Console.ReadLine();
            //Console.Write("Askerlik Durumunuz: ");
            //string Askerlik = Console.ReadLine();

            //Console.WriteLine($"Adınız ve Soyadınız:{Ad} {Soyad}," +
            //    $" Ülekeniz:{Ulke}, İliniz:{İl}, Yaşınız:{Yas}, " +
            //    $"" +
            //    $"Askerlik Durumu:{Askerlik}");

            /*Tür Dönüşümleri*/
            //Klavyeden Sayısal değer girme
            //Console.Write("1. Sayıyı Gir: ");
            //string Sayi1 = Console.ReadLine();
            //Console.Write("2. Sayıyı Gir: ");
            //string Sayi2 = Console.ReadLine();
            //string Sonuc = Sayi1 + Sayi2;
            //Console.WriteLine("Sonuç: " + Sonuc);

            //.parse() ile dönüştürme
            //Console.Write("1. Sayıyı Gir: ");
            //byte Sayi1 = byte.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Gir: ");
            //byte Sayi2 = byte.Parse(Console.ReadLine());//Bilinçli tür dönüşümü
            //int Sonuc = Sayi1 + Sayi2;//Bilinçsiz(otomatik) tür dönüşümü (implicit)
            //Console.WriteLine("Sonuç: " + Sonuc);

            //Explicit Tür dönüşümü
            //Sayısal değişken olduğunda kullanılıyır. 
            //Aynı türden değeri taşıyan değişkenlerde olur.
            //Örn: tamsayı değişkenlerinde büyük değer tutan 
            //değişkenden küçük değer tutan değişkene çevirme
            //int Sayi = 1000;
            //byte Sayi1 = (byte)Sayi;
            //Console.Write(Sayi1);

            ////Explicit tür dönüşümü sayısal değerler
            //Console.Write("1. Notu Gir: ");
            //int Sayi1 = int.Parse(Console.ReadLine());
            //byte _Sayi1 = (byte)Sayi1;
            //Console.Write("2. Sayıyı Gir: ");
            //int Sayi2 = int.Parse(Console.ReadLine());//Bilinçli tür dönüşümü
            //int Sonuc = Sayi1 + Sayi2;//Bilinçsiz(otomatik) tür dönüşümü (implicit)
            //Console.WriteLine("Sonuç: " + Sonuc);

            //// Not Ortalaması Örneği
            //Console.Write("1. Notu Gir: ");
            //byte Sayi1 = byte.Parse(Console.ReadLine());
            //Console.Write("2. Notu Gir: ");
            //byte Sayi2 = byte.Parse(Console.ReadLine());
            //Console.Write("3. Notu Gir: ");
            //byte Sayi3 = byte.Parse(Console.ReadLine());
            //int Sonuc = (Sayi1 + Sayi2 + Sayi3) / 3;
            //Console.WriteLine("Not Ortalaması: " + Sonuc);

            // Convert Metodu
            //Parse() metodu ile aynı işi yapar. 
            //Tek fark null değerli değişkenlerde çeviri 
            //yaparken değeri 0 olarak alır.
            //string sayi = null;
            ////int Sayi1 = Convert.ToInt32(sayi);
            //int Sayi1 = int.Parse(sayi);
            //Console.Write("Değer: " + Sayi1);


            //Console.Write("1. Notu Gir: ");
            //byte Sayi1 = Convert.ToByte(Console.ReadLine());
            //Console.Write("2. Notu Gir: ");
            //byte Sayi2 = byte.Parse(Console.ReadLine());
            //Console.Write("3. Notu Gir: ");
            //byte Sayi3 = byte.Parse(Console.ReadLine());
            //int Sonuc = (Sayi1 + Sayi2 + Sayi3) / 3;
            //Console.WriteLine("Not Ortalaması: " + Sonuc);

            //ToString() Metodu

            //int Not = 80;
            //bool Varmi = false;
            //string Deger = Not.ToString();
            //Console.WriteLine(Deger);
            //Deger = Varmi.ToString();
            //Console.WriteLine(Deger);


            /*27.10.2022*/
            //TryParseMetodu
            //Değişken dönüşümlerinde tür dönüşümü yapılabiliyorsa, 
            //değişken türünü çevirip geriye true değerini döndürür.
            //Çevrilemiyorsa False değerini döndürür.
            //Console.Write("Not Giriniz: ");
            //string Not = Console.ReadLine();
            ////1. Tanımlama Yolu
            //bool Cevap = int.TryParse(Not, out int Sayi1);
            //2. Tanımlama Yolu
            //int Sayi1;
            //bool Cevap = int.TryParse(Not, out Sayi1);

            //Console.WriteLine(Cevap.ToString());
            //Console.WriteLine(Sayi1);


            //String ve String metotları
            //string Str = "Abdullah";
            //Karakerler Dizisi
            //Console.WriteLine(Str[0]);
            //Console.WriteLine(Str[1]);
            //Console.WriteLine(Str[2]);
            //Console.WriteLine(Str[3]);
            //Console.WriteLine(Str[4]);
            //Console.WriteLine(Str[5]);
            //Console.WriteLine(Str[6]);

            //Değişken tanımlayarak Yapma
            //string Ad = "Abdullah";
            //string Soyad = "Akyol";
            //int Age = 32;
            //1. Yol
            //string Str = "Helle there. My name is Abdullah Akyol. I'm 32 years old.";
            //2. Yol
            //string Str = "Helle there. My name is " + Ad + " " + Soyad + ". I'm " + Age + " years old.";
            //3. Yol
            //string Str = $"Helle there. My name is {Ad} {Soyad}. I'm {Age} years old.";
            //4. Yol
            //string Str = string.Format("Helle there. My name is {0} {1}. I'm {2} years old.",
            //    Ad, Soyad, Age);

            //Dışarıdan Değişken alarak Yapma
            //Console.Write("Adınız: ");
            //string Ad = Console.ReadLine();
            //Console.Write("Soyadınız: ");
            //string Soyad = Console.ReadLine();
            //Console.Write("Yaşınız: ");
            //int Age = int.Parse(Console.ReadLine());

            //string Str = string.Format("Helle there. My name is {0}  {1}. I'm {2} years old.",
            //    Ad, Soyad, Age);
            //Console.WriteLine(Str);

            /*String Metot ve özellikleri*/
            //string Msg = "Hello there. My name is Abdullah Akyol.";

            //Length özelliği
            //Karakter uzunluğunu verir.
            //Console.WriteLine($"Metin karakter sayısı: {Msg.Length}");

            //ToLower() Metodu
            //Büyük harf olan karakterleri küçük harfe dönüştürür.
            //Console.WriteLine(Msg.ToLower());

            //ToUpper() Metodu
            //Küçük harf olan karakterleri büyük harfe dönüştürür.
            //Console.WriteLine(Msg.ToUpper());

            //Trim() Metodu
            //Metnin başında ve sonunda bulunan boşlukları siler
            //Console.WriteLine(Msg.Trim());

            //Split() metodu
            //Belirtilen karakteri baz alarak metni böler.
            //Console.WriteLine(Msg.Split(' ')[1]);

            //StartsWith() Metodu
            //Girilen karakterleri metnin başında arar. 
            //Eğer uyuşma var ise true değerini döndüdürür.
            //Yoksa false değerini döndürür.
            //Console.WriteLine(Msg.StartsWith("Hello"));

            //EndsWith() Metodu
            //Girilen karakterleri metnin sonunda arar. 
            //Eğer uyuşma var ise true değerini döndüdürür.
            //Yoksa false değerini döndürür.
            //Console.WriteLine(Msg.EndsWith("Akyol."));

            //Contains() Metodu
            //Girilen değeri metin içinde arar. Eğer var ise true döndüdür. 
            //Yok ise false döndüdürür.
            //Console.WriteLine(Msg.Contains("Abd"));

            //IndexOf() Metodu
            //Girilen değeri metin içinde arar ve 
            //eşleşme olduğunda sıra numarasını verir.
            //Soldan sağa doğru ilk eşleştiği karakerin sıra numarasını verir.
            //Bulamazsa -1 değerini verir.
            //Console.WriteLine(Msg.IndexOf("A"));

            //LastIndexOf() Metodu
            //Girilen değeri metin içinde arar ve 
            //eşleşme olduğunda sıra numarasını verir.
            //Sağdan Sola doğru ilk eşleştiği karakerin sıra numarasını verir.
            //Bulamazsa -1 değerini verir.
            //Console.WriteLine(Msg.LastIndexOf("A"));

            //Substring() Metodu
            //Başlangıç numarası girilmiş ve 
            //alınacak karakter sayısı belirtilmemişse
            //Console.WriteLine(Msg.Substring(24));

            //Başlangıç numarası girilmiş ve 
            //alınacak karakter sayısı belirtilmeşse
            //Console.WriteLine(Msg.Substring(24,10));

            //Replace() Metodu
            //Girilen değerle eşleşen karakterleri
            //Belirtilen karakterlerle değiştirme işine yarar.
            //Console.WriteLine(Msg.Replace(" ", "-"));

            //Insert() Metodu
            //Belirtilen sıra numarasına göre 
            //girilen karakterleri metne yerleştirir.
            //Console.WriteLine(Msg.Insert(0, "..."));
            //Console.WriteLine(Msg.Insert(Msg.Length, "***"));

            //Remove() Metodu
            //Metin içerisinde index numarasına göre karakterleri siler
            //Geriye metnin kalan kısmını çevirir.

            //Kaç karakter sileceği belirtilmemişse
            //Console.WriteLine(Msg.Remove(5));

            //Kaç karakter sileceği belirtilmişse
            //Console.WriteLine(Msg.Remove(5,10));

            //Padleft() Metodu
            //Metnin soluna karakter sayısını girilen karakter 
            //sayısına tmamalayınyacaya kadar belirtilen karakteri girir.
            //string Ad = "Abdullah Akyol";
            //Karakter belirtilmemişse bolşluk koyar.
            //Console.WriteLine(Ad.PadLeft(12));

            //Karakter belirtilmişse belirtilen karakteri koyar.
            //Console.WriteLine(Ad.PadLeft(Ad.Length + 4, '*'));

            //PadRight() Metodu
            //Metnin sağına karakter sayısını girilen karakter 
            //sayısına tmamalayınyacaya kadar belirtilen karakteri girir.

            //Karakter belirtilmemişse bolşluk koyar.
            //Console.WriteLine(Ad.PadRight(12));

            //Karakter belirtilmişse belirtilen karakteri koyar.
            //Console.WriteLine(Ad.PadRight(Ad.Length + 4, '*'));

            /*String sınıfını kullanarak metot çağırma
             Ör:string.concat(str,str2);
             */

            //Caoncat() Metodu
            //Birden fazla stringi birleştirerek geriye çevirir.
            //Console.WriteLine(string.Concat(Msg, " ", Ad));

            //string.Empty özelliği
            //Değişken içini boşaltma işine yarar.
            //Ör:string Ad=""; ile string Ad=string.Empty birbirine eşittir.
            //Ad = string.Empty;

            //IsNullOrEmpty() Metodu
            //Ad = null;
            //Console.WriteLine(string.IsNullOrEmpty(Ad));

            ////Metotları birlikte kullanma
            //Console.WriteLine(Ad.Replace(" ", "-").PadLeft(Ad.Length + 4, '*'));
            ////Ad Soyad Yıldızlı Örnek
            //string Ad = "Abdullah";
            //string Soyad = "Akyol";
            //string Sonuc = Ad[0].ToString().PadRight(Ad.Length, '*') + " " +
            //    Soyad[0].ToString().PadRight(Soyad.Length, '*');
            //Console.WriteLine(Sonuc);

            /*03.11.2022*/
            //Diziler ve Dizi Metotları

            //string Msg = "Hello there. My name is Abdullah Akyol.";
            //Karakterler Dizisi
            //Console.WriteLine(Msg[0]);
            //Console.WriteLine(Msg[1]);
            //Console.WriteLine(Msg[2]);
            //Console.WriteLine(Msg[3]);
            //Console.WriteLine(Msg[4]);

            //Split Metodu ile bölme işlemi
            //1. Yol
            //var Sonuc = Msg.Split();
            //2. Yol
            ////string[] Sonuc = Msg.Split();
            ////Console.WriteLine(Sonuc[0]);
            ////Console.WriteLine(Sonuc[1]);
            ////Console.WriteLine(Sonuc[2]);
            ////Console.WriteLine(Sonuc[3]);
            ////Console.WriteLine(Sonuc[4]);
            ////Console.WriteLine(Sonuc[5]);
            ////Console.WriteLine(Sonuc[6]);

            //Dizi tanımlama
            //Eğer aynı türden birden fazla isme ihtiyacım olsa, bunlar için birden 
            //fazla değişken tanımlamak zorunda kalırım.Fakat diziler sayesinde elemanları
            //tek bir değişkende tanımlayıp çağırabilirim.
            //string Ad = "Zeynep";
            //string Ad1 = "Faysal";

            //1. Yol Tanımlama
            //Metinsel İfade Tanımlama
            //string[] Isimler = new string[5];
            ////Atama Yapıldı. Yani set işlemi
            //Isimler[0] = "Yasin";
            //Isimler[1] = "Bora";
            //Isimler[2] = "Eftalya";
            //Isimler[3] = "Hatice";
            //Isimler[4] = "Melih";
            //Isimler[4] = "7";
            ////Çağırma yapıldı. Yani get işlemi
            //Console.WriteLine(Isimler[0]);
            //Console.WriteLine(Isimler[1]);
            //Console.WriteLine(Isimler[2]);
            //Console.WriteLine(Isimler[3]);
            //Console.WriteLine(Isimler[4]);

            //Sayısal İfade Tanımlama
            //int[] Sayilar = new int[5];
            ////Atama Yapıldı. Yani set işlemi
            //Sayilar[0] = 5;
            //Sayilar[1] = 7;
            //Sayilar[2] = 9;
            //Sayilar[3] = 4;
            //Sayilar[4] = 1;
            ////Çağırma yapıldı. Yani get işlemi
            //Console.WriteLine(Sayilar[0]);
            //Console.WriteLine(Sayilar[1]);
            //Console.WriteLine(Sayilar[2]);
            //Console.WriteLine(Sayilar[3]);
            //Console.WriteLine(Sayilar[4]);

            //Bool türündeki dizi
            //bool[] IsRight = new bool[3];

            ////2. Yol Tanımlama ve set işlemi yapıldı
            //string[] Isimler = {"Yasin",null,"Eftalya","Hatice","Melih" };
            //Isimler[1] = "Bora";
            //Isimler[3] = "Zeynep";
            ////Çağırma yapıldı. Yani get işlemi
            //Console.WriteLine(Isimler[0]);
            //Console.WriteLine(Isimler[1]);
            //Console.WriteLine(Isimler[2]);
            //Console.WriteLine(Isimler[3]);
            //Console.WriteLine(Isimler[4]);
            //3. Yol Tanımlama
            //string[] Isimler;
            ////Buşekilde değer ataması yapılamaz
            //Isimler[0] = "";
            ////Dizinin Eleman sayısı belirlendi
            //Isimler = new string[3];
            ////Değer ataması yapıldı. Yani set işlemi
            //Isimler[0] = "Halit Ziya";
            ////Çağırma yapıldı. Yani get işlemi
            //Console.WriteLine(Isimler[0]);

            ////Aralık dışına çıkma. Yani Taşma işlemi
            //string[] Isimler = { "Abdullah", "Enis", "Barış" };
            //Console.WriteLine(Isimler[3]);

            ////Değişkenden diziye Atama
            //string Ad = "Zeynep";
            //string[] Isimler = new string[3];
            //Isimler[0] = Ad;
            //Console.WriteLine(Isimler[0]);

            ////Çok Boyutlu Diziler
            //string[] TekBoyutSehir = new string[9];
            ////1. Yol Tanımlama
            //string[,] Sehirler = new string[3, 3];
            ////Tek Boyut atama
            //TekBoyutSehir[0] = "İstanbul";
            //TekBoyutSehir[1] = "Ankara";
            //TekBoyutSehir[2] = "İzmir";
            //TekBoyutSehir[3] = "Muş";
            //TekBoyutSehir[4] = "Manisa";
            //TekBoyutSehir[5] = "Bursa";
            //TekBoyutSehir[6] = "Kars";
            //TekBoyutSehir[7] = "Malatya";
            //TekBoyutSehir[8] = "Aydın";
            ////Çift Boyutlu Atama
            ////0. Sıra numaralı Satır için
            //Sehirler[0,0]= "İstanbul";
            //Sehirler[0, 1] = "Ankara";
            //Sehirler[0, 2] = "İzmir";
            ////1. Sıra numaralı Satır için
            //Sehirler[1, 0] = "Muş";
            //Sehirler[1, 1] = "Manisa";
            //Sehirler[1, 2] = "Bursa";
            ////2. Sıra numaralı Satır için
            //Sehirler[2, 0] = "Kars";
            //Sehirler[2, 1] = "Malatya";
            //Sehirler[2, 2] = "Aydın";

            ////Çift Boyutlu Çağırma. Yani get işlemi
            //Console.WriteLine(Sehirler[0, 0]);
            //Console.WriteLine(Sehirler[0, 1]);
            //Console.WriteLine(Sehirler[0, 2]);
            //Console.WriteLine(Sehirler[1, 0]);
            //Console.WriteLine(Sehirler[1, 1]);
            //Console.WriteLine(Sehirler[1, 2]);
            //Console.WriteLine(Sehirler[2, 0]);
            //Console.WriteLine(Sehirler[2, 1]);
            //Console.WriteLine(Sehirler[2, 2]);

            //2. Yol İlk Değer ataması yapılarak
            //string[,] Sehirler = { {"İstanbul","Ankara","İzmir" }, { "Muş", "Manisa", "Bursa" },
            //    { "Kars", "Malatya","Aydın" } };
            //Çift Boyutlu Çağırma. Yani get işlemi
            //Console.WriteLine(Sehirler[0, 0]);
            //Console.WriteLine(Sehirler[0, 1]);
            //Console.WriteLine(Sehirler[0, 2]);
            //Console.WriteLine(Sehirler[1, 0]);
            //Console.WriteLine(Sehirler[1, 1]);
            //Console.WriteLine(Sehirler[1, 2]);
            //Console.WriteLine(Sehirler[2, 0]);
            //Console.WriteLine(Sehirler[2, 1]);
            //Console.WriteLine(Sehirler[2, 2]);

            /*Dizi Metotları*/
            //string[] Isimler = {"Yasin","Bora","Eftalya","Hatice","Melih" };

            ////Length Özelliği. Dizinin eleman sayısını verir.
            //Console.WriteLine($"Dizinin Elaman Sayısı: {Isimler.Length}");
            //Console.WriteLine($"Dizinin Son Elamanının Sıra Numarası: {Isimler.Length-1}");

            ////GetLength() Metodu
            //string[,] Sehirler = { {"İstanbul","Ankara","İzmir","ssa" }, { "Muş", "Manisa", "Bursa","ssa" },
            //    { "Kars", "Malatya","Aydın" ,"ssa"} };
            //Console.WriteLine($"Dizinin Elaman Sayısı: {Sehirler.Length}");
            //Console.WriteLine($"Dizinin Satır Sayısı: {Sehirler.GetLength(0)}");
            //Console.WriteLine($"Dizinin Sütun Sayısı: {Sehirler.GetLength(1)}");

            ////SetValue() Metodu. Dizi elemanlarına atama işlemi yapar.
            //Isimler.SetValue("Barkay", 0);
            //Isimler[0] = "Berkay";
            //foreach (var item in Isimler)
            //{
            //    Console.WriteLine(item);
            //}


            ////GetValue() Metodu. Dizi elemanlarını çağırma işlemi yapar.
            //Console.WriteLine(Isimler.GetValue(0));
            //Console.WriteLine(Isimler[0]);

            ////GetUpperBound() Metodu
            ////Dizinin Son elemanının sıra numarasını getirir
            //Console.WriteLine($"Tek boyutlu dizinin son elamanının sıra numarası: {Isimler.GetUpperBound(0)}");
            //Console.WriteLine($"Çok boyutlu dizinin satırında bulunan" +
            //    $" son elamanının sıra numarası: {Sehirler.GetUpperBound(0)}");
            //Console.WriteLine($"Çok boyutlu dizinin sütununda bulunan" +
            //    $" son elamanının sıra numarası: {Sehirler.GetUpperBound(1)}");

            //Array.Sort() Metodu. Gönderilen dizinin elemanlarını,a-z ve 
            //küçükten büyüğe doğru sıralar.
            //Array.Sort(Isimler);
            //Console.WriteLine(Isimler[0]);
            //for (int i = 0; i < Isimler.Length; i++)
            //{
            //    Console.WriteLine(Isimler[i]);
            //}


            ////Array.Reverse() Metodu. Gönderilen dizinin elemanlarını ters çevirir.
            //Array.Reverse(Isimler);
            //Array.Sort(Isimler);
            //Console.WriteLine(Isimler[0]);

            //Array.Clear() Metodu
            //Array.Clear(Isimler, 0, 2);
            //Console.WriteLine($"Dizinin 1. Elemanı: " +
            //    $"{Isimler.GetValue(1)}");

            //Console.ReadLine();

            //DATETİME SINIFI VE METOTLARI
            //Mevcut tarih saati almak için kullanılır
            DateTime Tarih = new DateTime(2000, 9, 5, 4, 48, 53, 78);
            DateTime Simdi = DateTime.Now;
            DateTime Tarih1 = DateTime.Now;
            //ToLongDateString
            //Günün sayısal değerini,ayın ismini,yılı ve günün ismini yazar
            Console.WriteLine(Simdi.ToLongDateString());
            Console.WriteLine($"ToLongDateString: {Simdi.ToLongTimeString()}");

            //ToShortDateString
            //günü,ayın ve yılın sayısal değerini yazar
            Console.WriteLine($"ToShortDateString:{Simdi.ToShortDateString()}");

            //ToLongTimeString
            //Saat,Dakika ve saniye bilgisini getirir
            Console.WriteLine(Simdi.ToLongTimeString());
            Console.WriteLine($"ToLongTimeString:{Simdi.ToLongTimeString()}");

            //ToShortTimeString
            //Saat, dakika bilgisini yazar
            Console.WriteLine(Simdi.ToShortTimeString());
            Console.WriteLine($"ToShortTimeString:{Simdi.ToShortTimeString()}");

            //Year Özelliği
            //sadece yıl bilgisini getirir
            Console.WriteLine($"Year:{Simdi.Year}");

            //Month Özelliği
            //sadece ay bilgisini verir
            Console.WriteLine($"Month:{Simdi.Month}");

            //Day Özelliği
            //sadece gün bilgisini verir
            Console.WriteLine($"Day:{Simdi.Day}");

            //DayOfWeek Özelliği
            //Haftanın hangi günü olduğu bilgisini verir
            Console.WriteLine($"DayOfWeek:{Simdi.DayOfWeek}");

            //Hour Özelliği
            //Sdece saat bilgisini verir
            Console.WriteLine($"Hour:{Simdi.Hour}");

            //Minute Özelliği
            //sadece dakika bilgisini verir
            Console.WriteLine($"Minute:{Simdi.Minute}");

            //Second Özelliği
            //Sadece saniye bilgisini verir
            Console.WriteLine($"Second:{Simdi.Second}");

            //tarih ve saat üzerinde ekleme veya eksiltme işlemi yapma
            //AddDays()Metodu=Girilen tam sayı değerine göre günü arttırıp veya azaltma işlemi yapar
            DateTime YeniGun = Simdi.AddDays(3);
            Console.WriteLine($"AddDays():{YeniGun.ToLongDateString()}");

            //AddMonths()metpdu
            DateTime YeniAy = Simdi.AddMonths(-3);
            Console.WriteLine($"AddMonths():{YeniAy.ToLongDateString()}");

            //AddYears()Metodu
            DateTime YeniYıl = Simdi.AddYears(-3);
            Console.WriteLine($"AddYears():{YeniYıl.ToLongDateString()}");

            //AddHours Metodu
            DateTime YeniSaat = Simdi.AddHours(14);
            Console.WriteLine($"AddHours():{YeniSaat.ToLongDateString()}");

            //AddMinutes Metodu
            DateTime YeniDakika = Simdi.AddMinutes(35);
            Console.WriteLine($"AddMinute():{YeniDakika.ToLongTimeString()}");

            //3 yıl öncesine git,2 ay arttır ve 5 gün ileri git işlemi yapar
            DateTime YeniTarih = Simdi.AddYears(-3).AddMonths(2).AddDays(5);
            Console.WriteLine($"AddYears(-3).AddMonths(2).AddDays(5):" + $"{YeniTarih.ToLongDateString()}");

            //Elle girilen tarih ve zaman
            DateTime GirilenTarih = new DateTime(1990, 1, 1, 10, 15, 59);

            //TimeSpan nesnesi iki tarih arasındaki fark veya toplam üzeride işlem yapmaya yarar
            TimeSpan Sonuc = Simdi - GirilenTarih;

            //Days Özelliği.İki tarih arasındaki veya toplamındaki gün sayısını tam sayı olarak getirir
            Console.WriteLine($"Days:{Sonuc.Days}");

            //TotalDays özelliği.İki tarih arasındaki veya toplamındaki gün sayısını ondalıklı sayı olarak getirir
            Console.WriteLine($"TotalDays:{Sonuc.TotalDays}");

            //TotalHours Özelliği.İki tarih arasındaki veya toplamındaki saat sayısını ondalıklı sayı olarak getirir
            Console.WriteLine($"TotalHours:{Sonuc.TotalHours}");

            //Yıl bilgisini days özelliğini 365'e bölerek bulabiliriz.
            Console.WriteLine($"Toplam Yıl:{Sonuc.Days / 365}");

            //String sınıfı kulanılarak biçimlndirme yapmak
            Console.WriteLine("----String Sınıfı ile biçimlendirme----");

            //Sayısal olarak gün ay yıl  saat dakika ve saniye bilgisini verir
            Console.WriteLine(Simdi.ToString());

            //ToString("d")formatı gün ay ve yıl bilgisini sayısal olarak getirir
            Console.WriteLine($"d formatı:{Simdi.ToString("d")}");

            //ToString "D" formatı günün sayısal değerini ayın ismini yılı ve günü getirir
            Console.WriteLine($"D formatı:{Simdi.ToString("D")}");

            //ToString "F " formatı günün sayısal değerini ayın ismini yılın sayısal değerini ve günün ismini ve saat dakika ve saniye bilgisini getirir
            Console.WriteLine($"F formatı:{Simdi.ToString("F")}");

            //ToString "t"formatı saat ve dakika bilgisin, getirir
            Console.WriteLine($"t formatı:{Simdi.ToString("t")}");

            //ToString "T" formatı saat dakika ve saniye bilgileini sayısal olarak getirir
            Console.WriteLine($"T formatı:{Simdi.ToString("T")} ");

            //ToString "Y" formatı ay ismini ve yılın sayısal değerini getirir
            Console.WriteLine($"Y formatı:{Simdi.ToString("Y")} ");

            //UZUN FORMATLI TOSTRİNG KULLANIMI*****
            Console.WriteLine("----String Sınıfı ile uzun biçimlendirme----");
            //ToString("dd")formatı günün sayısal değerini getirir
            Console.WriteLine($"dd formatı:{Simdi.ToString("dd")}");

            //ToString("MM")formatı ayın sayısal değerini getirir
            Console.WriteLine($"MM formatı:{Simdi.ToString("MM")}");

            //ToString("yy")formatı yılın 2 basamaklı sayısal değerini getirir
            Console.WriteLine($"yy formatı:{Simdi.ToString("yy")}");

            //ToString("yyyy")formatı yılın 4 basamaklı sayısal değerini getirir
            Console.WriteLine($"yyyy formatı:{Simdi.ToString("yyyy")}");

            //ToString("ddd")formatı günün 3 karakterli ismini getirir
            Console.WriteLine($"ddd formatı:{Simdi.ToString("ddd")}");

            //ToString("MMM")formatı ayın 3 karakterli ismini getirir
            Console.WriteLine($"MMM formatı:{Simdi.ToString("MMM")}");

            //ToString("MMMM")formatı ayın tam ismini getirir
            Console.WriteLine($"MMMM formatı:{Simdi.ToString("MMMM")}");

            //ToString("hh")formatı saati 12lik saat formatına göre getirir
            Console.WriteLine($"hh formatı:{Simdi.ToString("hh")}");

            //ToString("HH")formatı saati 24lük saat formatına göre getirir
            Console.WriteLine($"HH formatı:{Simdi.ToString("HH")}");

            //ToString("mm")formatı dakikayı 2 basamaklı olarak getirir
            Console.WriteLine($"mm formatı:{Simdi.ToString("mm")}");

            //ToString("ss")formatı saniyeyi 2 basamaklı olarak getirir
            Console.WriteLine($"ss formatı:{Simdi.ToString("ss")}");

            //Birlikte kullanım
            Console.WriteLine($"dd.MM.yyyy HH:mm:ss formatı:" +
                $"{Simdi.ToString("dd MM yyyy HH:mm:ss")}");

            Console.WriteLine($"dd.MM.yyyy HH:mm:ss formatı:" +
                $"{Simdi.ToString("dd MM yyyy HH:mm:ss")}");

            //Kültürel kullanımı . Yani dil kullanımı
            CultureInfo Kultur = new CultureInfo("de");
            Console.WriteLine($"dd.MM.yyyy HH:mm:ss Türkçe Formatı:" +
                    $"{Simdi.ToString("dd MMMM yyyy dddd HH:mm:ss", Kultur)}");

        }
    }
}
