// See https://aka.ms/new-console-template for more information
int sayi, n;
int kareleri=0;
int carpim=1;
int toplam=0;
Console.WriteLine("Sayı değerini giriniz : ");
sayi = Convert.ToInt32(Console.ReadLine());
for (n=1;n<=sayi;n++) 
{
    //2 ile bölünmüyorsa tek sayıdır
    if (n % 2 != 0)
    {
        //örneğin ekrana girilen sayı 5 ise
        //1
        //1+3
        //1+3+5 olarak alıyor
        toplam = toplam + n;
        //tek sayıları bulup çarpıyor.
        //1*3*5
        carpim = carpim * n;
        Console.WriteLine("Tek sayıların toplamı : " + toplam);

    }
    else 
    {
        //2 ile bölünüyorsa çift sayıların kareleri toplamı
        kareleri = kareleri + n * n;
    }
}
Console.WriteLine("Tek sayıların toplamı : " + toplam);
Console.WriteLine("Tek sayıların çarpımı : " + carpim);
Console.WriteLine("Çift sayıların kareleri toplamı : " + kareleri);



