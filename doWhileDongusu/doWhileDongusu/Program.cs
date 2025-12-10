// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Amaç 1. Bilgisyarın tuttuğu 4 haneli (1000,9999) sayıyı bulmak.
 * 
 *      1. Bilgisayar bir sayı tutar
 *      2. Kullanıcı sayıyı tahmin eder.
 *      3. Tahmini sayı tutulandan büyükse "AŞAĞI" der ve 2. adıma geçer
 *      4.                         küçükse "YUKARI" der ve 2. adıma geçer
 *      5.                         eşitse  "BİLİNDİ" der ve biter.
 */

Random random = new Random();
do
{
    int tutulanSayi = random.Next(1000, 9999);
    int denemeSayisi = 0;

    do
    {
        Console.WriteLine("4 basamaklı sayıyı tahmin edin: ");
        int tahmin = Convert.ToInt32(Console.ReadLine());
        denemeSayisi++;

        if (tahmin > tutulanSayi)
        {
            Console.WriteLine("AŞAĞI");
        }
        else if (tahmin < tutulanSayi)
        {
            Console.WriteLine("YUKARI");
        }
        else
        {
            Console.WriteLine($"{denemeSayisi} denemede BİLDİNİZ.");
            break;
        }

        if (denemeSayisi == 3)
        {
            Console.WriteLine("Deneme hakkınız bitti.");
            break; 
        }

    } while (true);

    Console.WriteLine("Tekrar oynamak ister misiniz? Evet=1   Hayır=0");

} while (Convert.ToInt32(Console.ReadLine()) == 1);
