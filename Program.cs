using System.IO.Compression;

class Program
{
    static void Main()
    {
        Bebek anakarakter = new Bebek("Küçük Führer");
        bool Gameloop = true;



        while (Gameloop)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{anakarakter.ad} DURUMU -> Açlık: {anakarakter.aclik}% | Uyku: {anakarakter.uykusuzluk}% | Mutluluk: {anakarakter.mutluluk}%");
            Console.WriteLine("Ne yapmak istersin?");
            Console.WriteLine("1- Yemek yedir");
            Console.WriteLine("2-Uyut");
            Console.WriteLine("3- Oyun oyna");
            Console.WriteLine("4- Sev");
            Console.WriteLine("0- Oyundan Çık");

            string secim = Console.ReadLine() ?? "";
            Console.WriteLine("");

            if (secim == "1")
            {
                anakarakter.uykusuzluk += 10;
                anakarakter.Yemekye();

            }
            else if (secim == "2")
            {
                anakarakter.aclik += 20;
                anakarakter.Uyudu();
            }
            else if (secim == "3")
            {
                anakarakter.uykusuzluk += 50;
                anakarakter.OyunOyna();
            }
            else if (secim == "4")
            {
                anakarakter.uykusuzluk += 25;
                anakarakter.Sevmek();
            }
            else if (secim == "0")
            {
                Gameloop = false;
                Console.WriteLine("Oyun kapatılıyor... Görüşürüz!");
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız lütfen var olanları seçiniz");
            }



        }



    }

    //sınıfımız
    class Bebek
    {
        Random zar = new Random();
        public string ad = "";
        public int aclik;
        public int uykusuzluk;
        public int mutluluk;



        public Bebek(string adı)
        {
            ad = adı;
            aclik = zar.Next(20, 101);
            uykusuzluk = zar.Next(0, 51);
            mutluluk = zar.Next(0, 101);
        }

        public void OyunOyna()
        {
            mutluluk += 50;
            Console.WriteLine($"{ad} ile oyun oynadın şu anki mutluluğu {mutluluk}%");
        }
        public void Sevmek()
        {
            mutluluk += 30;
            Console.WriteLine($"{ad}'e ilgi gösterdin mutlu oldu şu anki mutluluk {mutluluk}%");
        }

        //metod1 
        public void Yemekye()
        {
            aclik -= 20;
            Console.WriteLine($"{ad} Yemek yedi şu anki açlığı {aclik}%");

        }

        //metod2
        public void Uyudu()
        {
            uykusuzluk -= 50;
            Console.WriteLine($"{ad} bir 3 saatlik bir güzellik uykusu aldı geri kalan uykusuzluğu {uykusuzluk}%");
        }

    }
}