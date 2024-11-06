// 1 - 10 elemanlı bir tam sayı dizisi tanımla
int[] sayilar = new int[10];

// 2 - Diziyi for döngüsü ile doldur ve foreach döngüsü ile ekrana yazdır
Random rastgele = new Random();
for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rastgele.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı
}

Console.WriteLine("Dizinin ilk hali:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}

// 3 - Kullanıcıdan alınan yeni değeri (11. eleman olarak) diziye ekle
Console.WriteLine("\nBir sayı giriniz:");
int yeniSayi = Convert.ToInt32(Console.ReadLine());

// Diziyi genişleterek yeni elemanı ekle
Array.Resize(ref sayilar, sayilar.Length + 1);
sayilar[sayilar.Length - 1] = yeniSayi;

// 4 - Diziyi büyükten küçüğe sıralayarak ekrana yazdır
Console.WriteLine("\nDizi büyükten küçüğe sıralı haliyle:");
Array.Sort(sayilar); // Küçükten büyüğe sıralama
Array.Reverse(sayilar); // Büyükten küçüğe sıralama

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}