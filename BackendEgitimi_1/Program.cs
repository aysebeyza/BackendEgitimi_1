
#region---------------------------ÇİFT TEK SAYILARIN TOPLAMLARI -----------------------------------
int cifttoplam = 0;
int tektoplam = 0;

int[] sayilar = { 5, 2, 3, 4, 15, 10 };
// While döngüsü
int i = 0;
while (i < sayilar.Length)
{
    if (sayilar[i] % 2 == 0)
    { cifttoplam = cifttoplam + sayilar[i]; }
    i++;
}
i = 0;
while (i < sayilar.Length)
{
    if (sayilar[i] % 2 == 1)
    {
        tektoplam = tektoplam + sayilar[i];

    }
    i++;
}

Console.WriteLine("Çift Sayıların toplamı: " + cifttoplam);
Console.WriteLine("Tek Sayıların toplamı: " + tektoplam);
#endregion


#region-----------------------SAYI KERE SAYI----------------------


int sayi;
sayi = Convert.ToInt16(Console.ReadLine());  // Kullanıcıdan sayı girmesini istiyoruz

// Dış döngü: 1'den sayi'ye kadar
int x = 1;
while (x <= sayi)
{
    // İç döngü: sayi'dan i'ye kadar
    int j = sayi;
    while ( j>=x)
    {
        Console.Write(x);  // Her adımda i'yi yazdırıyoruz
        j--;
    }
    x++;
    Console.WriteLine();  // Her satır sonunda bir alt satıra geçiyoruz

}

Console.ReadLine();  // Çıkmadan önce bir tuşa basılmasını bekliyoruz


#endregion

#region -------------------YILDIZ PİRAMİDİ-----------------------

int body = int.Parse(Console.ReadLine());
int satir;
satir = (body * 2) - 1;

int m = 1;  // Başlangıç değeri
while (m <= satir)
{
    Console.WriteLine();  // Yeni satır 

    // Boşlukları yazdırıyoruz 
    int bosluk2 = (satir - m) / 2;
    int j = 0;
    while (j < bosluk)
    {
        Console.Write(" ");
        j++;
    }

    // Yıldızlar
    j = 0;
    while (j < m)
    {
        Console.Write("*");
        j++;
    }
    m += 2;
}

#endregion


#region----------------GİRİLEN SAYIYA KADAR OLAN ÇİFT TEK TOPLAMI -------------------------

int girilensayi = Convert.ToInt16(Console.ReadLine());
int cift = 0;
int tek = 0;
int s1 = 0;
while ( s1<=girilensayi)
{
    if(s1 % 2 == 0)
    {
        cift = cift + s1;
    }
    else
    {
        tek = tek + s1;
    }
    s1++;
}
Console.WriteLine(girilensayi + " sayısına kadar Çift sayıların toplamı" + cift);
Console.WriteLine(girilensayi + " sayısına kadar tek sayıların toplamı" + tek);

#endregion


#region --------------------- ELMAS --------------------------
int bosluk;
int yildiz;
Console.WriteLine("Orta satırdaki * sayısını girin (tek sayı): ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
{
    Console.Write("Lütfen tek sayı girin: ");
}
else
{
    int i = 1;
    while ( i <= n)
    {
        bosluk = (n - i) / 2;
        yildiz = i;
        int j = 0;
        while ( j < bosluk)
        {
            Console.Write(" ");
            j++;
        }
        int j = 0;
        while ( j < yildiz)
        {
            Console.Write("*");
            j++;
        }

        Console.WriteLine();
        i += 2;
    }
    int i = n - 2;
    while ( i >= 1)
    {
        bosluk = (n - i) / 2;
        yildiz = i;
        int j = 0;
        while ( j < bosluk)
        {
            Console.Write(" ");
            j++;
        }
        int j = 0;
        while ( j < yildiz)
        {
            Console.Write("*");
            j++;
        }

        Console.WriteLine();
        i -= 2;
    }
}
#endregion

#region ---------------------FIBONACCI ---------------

int a = 1;
int b = 1;
Console.Write("Gösterilecek Fibonacci Adım Sayısını Girin: ");
int sayi = int.Parse(Console.ReadLine());

int i = 0;
while (i < sayi)
{
    Console.Write(a + " ");
    int adim = a + b;
    a = b;
    b = adim;
    i++;
}
Console.WriteLine(); // Satır sonu için
  }

#endregion