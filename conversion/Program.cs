/* 
---Tip Dönüşümleri---

Değişkenler belirli türleri olan ve bu türde değer tutan nesnelerdir.Bazı durumlarda bir değişkenin farklı
bir türe dönüştürülmesi gerekebilmektedir.
Bu durumda Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm) ya da Explicit Conversion (Bilinçli ya da açık dönüşüm) kullanılır. 

Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm)

Matematiksel olarak düşük kapasiteli bir değişkenin daha yüksek kapasiteli olan değişkene atanmasıdır.
Veri kaybı yaşanmaz. Özel bir kod dizimi gerekmez.

Explicit Conversion (Bilinçli ya da açık dönüşüm)

Derleyicinin izin vermediği durumlarda kullanılır. 
(int)x  şeklinde tanımlama yapılır. (veri tipi)veri ismi
Reel türler tam sayıya çevrilirken ondalık kısmı atılır.

** x.ToString() Methodu: Bu metot x değişken ya da sabitini stringe çevirip tutar.

*/

//Implicit Örnek

byte a = 5;
sbyte b = 30;
short c = 10;
int d = a + b + c;
System.Console.WriteLine("d:" + d);

long h = d;
System.Console.WriteLine("h" + h);

float g = h;
System.Console.WriteLine("G:" + g);

string e = "Scientia Ingenium Virtus";
char f = 'B';
object k = e + f + g;
System.Console.WriteLine("K: " + k);

//Explicit Conversion

int x = 4;
byte y = (byte)x;
System.Console.WriteLine("y:" + y);

int z = 100;
byte t = (byte)z;
System.Console.WriteLine("Z: " + t);

float w = 10.3f;
byte v = (byte)w;
System.Console.WriteLine("W: " + v);

int xx = 6;
string yy = xx.ToString();
System.Console.WriteLine("XX:" + yy);

string s1 = "10", s2 = "20";
int sayi1, sayi2, toplam;
sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);
toplam = sayi1 + sayi2;
Console.WriteLine("Toplam:" + toplam);


//Parse

ParseMethod();


    string metin1 = "10";
    string metin2 = "10.25";
    int sayi1;
    double double1;

    sayi1 = Int32.Parse(metin1);
    double1 = Double.Parse(metin2);
    Console.WriteLine("sayi1:" + sayi1);
    Console.WriteLine("double1:" + double1);

