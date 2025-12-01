// See https://aka.ms/new-console-template for more information

try
{
	Console.WriteLine("Lütfen bir tam sayı giriniz: ");
	int sayi1 = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Lütfen bir tam sayı daha giriniz: ");
	int sayi2 = Convert.ToInt32(Console.ReadLine());

	int sonuc = sayi1 / sayi2;
	Console.WriteLine($"Sonuc: {sonuc}");
}
catch (FormatException) //kodları dene eğer FormatException hatası varsa catche gir.
{
    Console.WriteLine("Lütfen sadece TAM SAYI giriniz!");
	
}
/*catch (DivideByZeroException)
{
    Console.WriteLine("Tam sayılar 0'a bölünemez!");
}*/
catch (Exception ex)
{
	Console.WriteLine($"Bilinmeyen bir hata oluştu: {ex.Message}");
}
/*finally
{
	Console.WriteLine("Burası hata olsa da olmasa da çalışacak...");
}
*/

Console.WriteLine("Çalışmaya devam edecek...");
