/* 
--Operatörler --

1)Aritmetik operatörler

+(ekleme) ‐(çıkarma) *(çarpma) /(bölme)
++(işlemin uygulandığı sayıyı 1 arttırır) --(işlemin uygulandığı sayıyı 1 azaltır)
(x++ / x--) bu şekilde kullanımda ilk önce operand kullanılır sonra arttırılır ya da azaltılır
(++x / --x) bu kullanımda ise ilk arttırılır ya da azaltılır sonra operand kullanılır.
% (mod alma yani bölümden kalanı bulmak) !(boolean içerisinde bulunan değeri ters çevirir)
*, /, % operatörleri eşit önceliktedir ama +,-'den daha önceliklidir.  

2)Karşılaştırma operatörleri
Karşılaştırma operatörleri aritmetik operatörlerden düşük önceliklidir.

<(küçüktür) >(büyüktür)
<=(küçük veya eşittir) >=(büyük veya eşittir)
==(eşittir) !=(eşit değildir)

3)Bitsel operatörler
Kod yazılırken bilgisayar diline derlendiğinde sıfır ve birlerden oluşan bir yapı haline çevrilir.
Bu işlem sonucunda elde edilen bitsel değerler için pek tercih edilmese de bitsel operatörler
kullanabiliriz.

&(bitsel ve) ~(bitsel değil) |(bitsel veya) ^(bitsel özel veya) 

4)Mantıksal operatörler

!(değil): Elde edilen boolean veri türündeki değerin tersini alır.
&&(koşullu ve): operatörü iki değerin ikisi de doğru ise doğru,
en az birisi yanlış ise yanlış değerini döndürür.
||(koşullu veya): operatörü iki değerden birisi doğru ise doğru,
ikisi de yanlış ise yanlış değerini döndürür.

5)Atama ve işlemli atama operatörleri
= (atama) operatörü bir değişkene herhangi bir değer atamak için kullanılır.
*=, /=, +=, -=, &=, ^=, |=
soldaki operatöre sağdaki ile belirlenen işlem yapılır ve çıkan değer kendisine eşitlenir.

*/

int x = 44;
int y = 11;
int z = x%y;

System.Console.WriteLine(z);

y = y+2; // y+=2 bunun uzun halidir.

int number1 = 10;
int number2 = 20;
bool result = number1 != number2;
Console.WriteLine(result); 

int x = 5;
int y = 6;

y = y + 2;
y += 2;  // üsttekinin kısa syntaxı

x = x * 4;
x *= 4;  //kısa syntax

bool isTrue = true;
bool isFalse = false;

if (isTrue&&isFalse)
{
    Console.WriteLine("is not working.");
}

if (isTrue || isFalse)
{
    Console.WriteLine("working");
}

if (isTrue&& !isFalse)
{
    Console.WriteLine("working");
}
