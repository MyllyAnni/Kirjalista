namespace Kirjat;

class Program
{
    static void Main(string[] args)
    {
        List<Kirja> kirjalista = new List<Kirja>();

        while (true)
        {
            Console.WriteLine("Tervetuloa! Mitä haluat tehdä?");
            Console.WriteLine("Lisää kirja, paina L.");
            Console.WriteLine("Tulosta lista, paina T.");
            Console.WriteLine("Poista kirja, paina P");
            Console.WriteLine("Hae genren mukaan, paina G");
            Console.WriteLine("Tyhjä lopettaa.");
            string valinta = Console.ReadLine() ?? "";

            if (valinta == "L")
            {
                Console.WriteLine("Kirjan nimi: ");
                string nimi = Console.ReadLine() ?? "";

                Console.WriteLine("Kirjoittaja: ");
                string kirjoittaja = Console.ReadLine() ?? "";

                Console.WriteLine("Julkaisuvuosi: ");
                int vuosi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Genre: ");
                string genre = Console.ReadLine() ?? "";

                Kirja uusiKirja = new Kirja(nimi, kirjoittaja, vuosi, genre);

                Kirja.LisääKirja(kirjalista, uusiKirja);
                Console.WriteLine("Kirja lisätty!");
            }

            else if (valinta == "T")
            {
                Kirja.TulostaKirjalista(kirjalista);
            }

            else if (valinta == "P")
            {
                Console.WriteLine("Anna poistettavan kirjan nimi.");
                string poistettavaKirja = Console.ReadLine() ?? "";

                Kirja? poistettavaOlio = kirjalista.Find(k => k.Nimi == poistettavaKirja);

                if (poistettavaOlio != null)
                {
                    Kirja.PoistaKirja(kirjalista, poistettavaOlio);
                }

                else
                {
                    Console.WriteLine("Kirjaa ei löytynyt.");
                }
            }

            else if (valinta == "G")
            {
                Console.WriteLine("Kirjoita genre.");
                string genre = Console.ReadLine() ?? "";
                Kirja.HaeGenrenMukaan(kirjalista, genre);
            }

            else
            {
                break;
            }
        }
    }
}