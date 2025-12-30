using System.IO.Compression;

class Program
{
    static void Main()
    {
        Bebek anakarakter = new Bebek("Küçük Führer");

        Console.WriteLine($"{anakarakter} uyandı ve şuanki açlığı {anakarakter.aclik} şuanki uykusuzluğu {anakarakter.uykusuzluk}");
        Console.WriteLine($"-----------------------------------------------------------------------------------------------------");

        anakarakter.Uyudu();
        anakarakter.Yemekye();



    }

    //sınıfımız
    class Bebek
    {
        Random zar = new Random();
        public string ad = "";
        public int aclik;
        public int uykusuzluk;


        public Bebek(string adı)
        {
            ad = adı;
            aclik = zar.Next(20, 101);
            uykusuzluk = zar.Next(50, 101);

        }

        //metod1 
        public void Yemekye()
        {
            aclik -= 20;
            Console.WriteLine($"{ad} Yemek yedi şu anki açlığı {aclik}");

        }

        //metod2
        public void Uyudu()
        {
            uykusuzluk -= 50;
            Console.WriteLine($"{ad} bir 3 saatlik bir güzellik uykusu aldı geri kalan uykusuzluğu {uykusuzluk}");
        }

    }
}