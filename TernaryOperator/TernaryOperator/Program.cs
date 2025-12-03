Console.WriteLine("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

string mesaj = "";

if (sayi % 2 == 0 )
{
    //Console.WriteLine("Sayi çifttir");
    mesaj = "Çift";
}
else
{
    //Console.WriteLine("Sayi tektir.");
    mesaj = "Tek";
}
Console.WriteLine(mesaj);

string alternatifMesaj = sayi % 2 == 0 ? "Çift" : "Tek"; // ternary operator ( ? : )
Console.WriteLine(alternatifMesaj);




