/*  

C# Değişkenler

değişkentürü değişkenismi = değer;  şeklinde tanımlanır.

*her değişkenin türü ve ismi vardır
*harf,rakam,_ ile tanımlama yapılabilir.
*tanımlayıcı harf ile başlamak zorundadır, boşluk simge içeremez.
*case sensetive bir dildir.
*aynı tipte değişkenler aralarına virgül koyularak tanımlanabilir.
*ReadLine() methodun tuttuğu değer string türündedir

*/

byte number1 = 224;// doğal sayı tutar. 1 bayt (0-255)
sbyte number2 = -18; // tam sayı tutar. 1 bayt (-128-127)
short number3 = 28;// tam sayı tutar. 2 bayt 
int number4 = 34;// tam sayı tutar. 4 bayt
long number5 = 25;// tam sayı tutar 8 bayt
float number6 = 5.67F; // ondalıklı sayı yazıldığında yanına f yazılmalı.
double number7 = 5D; //ondalıklı sayı tanımlanırken sonuna d eklenir
decimal number8 = 4546; 

char text1 = 'N'; // tek bir karakter tutar.
string text2 = "Per aspera ad astra" ; //sınırsız metin tutar
string text3 = string.Empty; //boş string tutar
bool hypothesis =7>6; // doğru ya da yanlış olarak iki değer alabilir
bool hypothesis2 = 94<357;
object infinty = "stones"; // her türden veri alabilir. 
object number9 = 7915;

DateTime date = DateTime.Now; // Tarihi gösterir
System.Console.WriteLine(date);

const  float pi = 3.14F; // const anahtar kelimesini sabit bir değişken oluşturulmak istendiğinde kullanılır


