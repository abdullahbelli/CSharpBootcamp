// See https://aka.ms/new-console-template for more information


/*
 * Mevcut sayısı belirli olan  bir sınıfta tüm çğrencilerin adlarını ve notlarını almak istiyoruz.
 * 
 * Her öğrencinin notunu girdikten sonra:
 * 
 * 1. En yüksek not
 * 2. En düşük not
 * 3. En yüksek notu kim aldı?
 * 4. En düşük notu kim aldı?
 * 5. Not ortalaması
 * 6. Geçenler
 * 7. Kalan
*/

// 1. Aşama : Verilerin bellekte tutulması
Console.Write("Sınıfta kaç kişi var: ");
int mevcut = Convert.ToInt32(Console.ReadLine());

string[] isimler = new string[mevcut];
double[] notlar = new double[mevcut];

Console.WriteLine("Öğrenci bilgilerini gir:");

for (int i = 0; i < mevcut; i++)
{
    Console.Write($"{i+1}. Öğrencinin adı:");
    isimler[i] = Console.ReadLine();

    Console.Write($"{i + 1}. Öğrencinin notu:");
    notlar[i] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine();
}


//2. Aşama : Bellekteki verilerin gösterilmesi
Console.WriteLine(new string('*', 40));
Console.WriteLine();
Console.WriteLine("--- Bellekteki öğrenciler ---");

for (int i = 0;i < mevcut; i++)
{
    Console.WriteLine($"{isimler[i]} : {notlar[i]}");    
}

Console.WriteLine();

// 3. Aşama : istatistikler

double max = notlar[0];
string enIyiOgrenci = "";

double min = notlar[0];
string enZayifOgrenci = "";

double toplam = 0;
int gecenlerToplami = 0;
int kalanlarToplami = 0;

for (int i = 0; i < mevcut; i++)
{
    if (notlar[i] > max)
    {
        max = notlar[i];
        enIyiOgrenci = isimler[i];
        
    }

    if (notlar[i] < min)
    {
        min = notlar[i];
        enZayifOgrenci = isimler[i];
    }

    toplam += notlar[i];
    if (notlar[i] >= 45)
    {
        gecenlerToplami++;
    }
    else
    {
        kalanlarToplami++;
    }
}

Console.WriteLine(new string('-', 40));
Console.WriteLine();
Console.WriteLine("--- İstatistikler ---");

Console.WriteLine($"En iyi öğrenci adı : {enIyiOgrenci} notu: {max}");
Console.WriteLine($"En zayıf öğrenci adı : {enZayifOgrenci} notu: {min}");

double ortalama = toplam / mevcut;

Console.WriteLine($"Ortalama : {ortalama}");
Console.WriteLine($"Geçenler: {gecenlerToplami}, Kalanlar: {kalanlarToplami}");

string[] sehirler = { "Ankara", "Eskişehir", "İstanbul" };

Console.WriteLine("Aradığınız şehri girin: ");
string sehir = Console.ReadLine();
bool sehirVarmi = false;
int bulunanIndex = 0;

for (int i = 0;i < sehirler.Length; i++)
{
    if (sehirler[i] == sehir)
    {
        bulunanIndex = i ;
        sehirVarmi=true;
        break;
    }
}

if (sehirVarmi)
{
    Console.WriteLine($"{sehir} var {bulunanIndex}. Indexte");
}
else
{
    Console.WriteLine($"{sehir} yok");
}





