
/*if else kullanarak kullanicidan aldigimiz sayinin 10 dan buyuk ya da kucuk mu oldugunu ve
 iki ye bolunup bolunmedigini yazicaz */ 

int sayi;
Console.WriteLine("Bir sayi giriniz:");
sayi = int.Parse(Console.ReadLine());
if (sayi > 10)
{
    Console.WriteLine("Sayı 10'dan büyüktür.");
}
else
{
    Console.WriteLine("Sayı 10'dan küçüktür.");
}
// mod  operatorumuz % isaretiyle mod aliyoruz
if (sayi % 2 == 0)
{
    Console.WriteLine("Sayı 2'ye tam bölünür.");
}
else
{
    Console.WriteLine("Sayı 2'ye tam bölünmez.");
}
