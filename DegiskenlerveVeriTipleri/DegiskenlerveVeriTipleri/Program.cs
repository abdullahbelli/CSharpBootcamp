// See https://aka.ms/new-console-template for more information
/*
 * primitive tipler
 * 
 * Sayısal Veri Tipleri
 *      -- Tam Sayılar
 */
byte cayBardagi = 255;               // 8 bit, 0 - 255 (2^8 - 1)
sbyte negatifOlabilenCayBardagi = -128; // -128 ile 127 (8 bit signed)

short suBardagi = 32767;             // -32768 ile 32767 (16 bit signed)
ushort su2 = 65535;                  // 0 - 65535 (16 bit unsigned)

int surahi = 2000000000;             // -2,147,483,648 ile 2,147,483,647 (32 bit signed)

uint surahi2 = 4000000000u;          // 0 ile 4,294,967,295 (32 bit unsigned) → SONUNA 'u' ŞART

long damacana = 333333333333333;     // 64 bit signed
ulong damacana2 = 0;                 // 0 ile 18,446,744,073,709,551,615 (2^64 - 1)


byte a = 1;
byte b = 255;

byte total = (byte)(a + b);
Console.WriteLine($"Toplam: { total}"); // 0 çünkü 255 ten sonra başa döner ve 0 dan devam eder

checked // toplam 255 in üzerinde olursa hata ver
{
    byte total2 = (byte)(a + b);
    Console.WriteLine($"Toplam: {total2}");
}

//ondalıklı Sayılar

double pi = 3.14;
float fPi= 3.14f;
decimal para = 0.00000000001m;

//Sozel 

char sembol = '!';
string kelime = "Abdullah";

//Mantıksal

bool olurMu = false;

//boxing:
object test = 5; //şey 

var isim = "Abdullah";
var sayi = 23;
var oran = 1.6;

//***********************************************

//int suAnkiYil = 2025;

int suAnkiYil = DateTime.Now.Year;

Console.WriteLine("Doğum yılınızı 4 haneli olarak giriniz: ");

 string girilenYil = Console.ReadLine(); //Readline string verir!!

int dogumYiliniz = Convert.ToInt32(girilenYil);

//int dogumYiliniz = Convert.ToInt32(Console.ReadLine());

//int dogumYiliniz = 2003;


int yas = suAnkiYil - dogumYiliniz;

Console.WriteLine("Yasınız: " + yas); //string birleştirme

Console.WriteLine("Yaşınız: {0}", yas); //formatlama

Console.WriteLine($"Yaşınız: {yas}"); //string interpolation !!


