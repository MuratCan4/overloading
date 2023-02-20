using System;

namespace metot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 62;
            string isim = "Murat";
            Metotlar instance = new Metotlar();
            instance.Topla(a,b,out int sonuc);
            Console.WriteLine(sonuc);
            instance.EkranaYazdir(a);
            instance.EkranaYazdir(isim);
        }
    }

    class Metotlar
    {
        public void Topla (int deger1, int deger2, out int toplam)
        {
            toplam = deger1 + deger2;
        }
        public void EkranaYazdir (int sayi)
        {
            Console.WriteLine(sayi);
        }
        public void EkranaYazdir (string sayi)
        {
            Console.WriteLine(sayi);
        }
    }
}