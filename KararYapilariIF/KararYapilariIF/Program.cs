Console.WriteLine("Hava şuu an kaç derece?");
int sicaklik = int.Parse(Console.ReadLine()); // Convert.ToInt32(Console.ReadLine()); ile aynı

if (sicaklik < 10) 
{
    Console.WriteLine("Mont giy:)"); //önerme doğruysa çalışır 
}
else if (sicaklik < 15)
{
    Console.WriteLine("Ceket giyin :)");
}
else
{
    Console.WriteLine("Rahat şeyler giyin :)");
}
Console.WriteLine("\nBurası her türlü çalışır");

Random rastgeleSayiUretici = new Random();

int rastgeleSayi = rastgeleSayiUretici.Next(1,3);
Console.WriteLine("Yazı mı Tura mı?\n 1-Yazı\n2-Tura\nSeçiminizi yapın.");
string kullaniciSecimi = Console.ReadLine();
if (rastgeleSayi.ToString()==kullaniciSecimi)
{
    Console.WriteLine("Bildiniz:)");
}
else
{
    Console.WriteLine("Bilemediniz:(");
}

int yas = 16;
bool ebeveynIzni  = true;

if (yas >= 18)
{
    Console.WriteLine("Filme girebilirsiniz :)");
}
else if (yas<18 && ebeveynIzni)
{
    Console.WriteLine("Ebeveyn izni var. Hoş geldiniz :)");
}
else
{
    Console.WriteLine("Filme giremezsiniz :(");
}

Console.WriteLine("Kullanıcı adı giriniz: ");
string kullaniciAdi = Console.ReadLine();
Console.WriteLine("Şifre: ");
string sifre = Console.ReadLine();

if (kullaniciAdi == "abdullah" && sifre == "1234")
{
    Console.WriteLine("Hoş geldin abdullah");
}
else
{
    Console.WriteLine("Hatalı giriş");
}

















