namespace Worldle_Oyun_Kopyası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                                     WORDLE TR HOŞ GELDİNİZ");
            Console.WriteLine("                                                 ==============================");
            Console.WriteLine("                                                  5 TAHMİN HAKKINIZ BULUNMAKTA");
            Console.ResetColor();
            Console.ReadKey();
        tekraret:
            string[] kelimeler = { "barış", "orhan", "nihat", "tuğçe" };
            Random rnd = new Random();
            string gizliKelime = kelimeler[rnd.Next(0, kelimeler.Length)];
            Console.Clear();
            int tahminHakkı = 5;
            int kalanHak = tahminHakkı;
            char[] tahminEdilen = new char[gizliKelime.Length];
            for (int i = 0; i < gizliKelime.Length; i++)
            {
                tahminEdilen[i] = '_';
            }
            while (kalanHak > 0)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("WORDLE TR");
                Console.WriteLine("==============================");
                Console.ResetColor();
                Console.WriteLine($"Kalan tahmin hakkınız: {kalanHak}");
                Console.WriteLine("Tahmin ettiğiniz kelime: " + new string(tahminEdilen));
                Console.Write("Harf girin: ");
                char tahmin = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool bulunan = false;
                for (int i = 0; i < gizliKelime.Length; i++)
                {
                    if (gizliKelime[i] == tahmin)
                    {
                        tahminEdilen[i] = tahmin;
                        bulunan = true;
                    }
                }

                if (!bulunan)
                {

                    Console.WriteLine($"Maalesef,{tahmin} harfi kelimenin içinde değil.");
                    kalanHak--;
                }
                else
                {
                    Console.WriteLine("Doğru tahmin! Bu harf kelimenin içinde.");

                }

                if (new string(tahminEdilen) == gizliKelime)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WORDLE TR");
                    Console.WriteLine("==============================");
                    Console.WriteLine("Tebrikler! Kelimeyi doğru tahmin ettiniz. " + gizliKelime);
                    Console.WriteLine("1- Tekrar et");
                    Console.WriteLine("2- Bitir");
                    string tekar = Console.ReadLine();
                    if (tekar == "1")
                    {
                        goto tekraret;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("WORDLE TR");
                        Console.WriteLine("==============================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Görüşmek üzere!");
                        break;
                    }

                }
            }

            if (kalanHak == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("WORDLE TR");
                Console.WriteLine("==============================");
                Console.WriteLine("Maalesef, tahmin hakkınız bitti. Doğru kelime: " + gizliKelime);
                Console.WriteLine("1- Tekrar et");
                Console.WriteLine("2- Bitir");
                string tekar = Console.ReadLine();
                if (tekar == "1")
                {
                    goto tekraret;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("WORDLE TR");
                    Console.WriteLine("==============================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Görüşmek üzere!");
                }

            }
        }
    }
}