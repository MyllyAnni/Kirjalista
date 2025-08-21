namespace Kirjat;

class Program
{
    static void Main(string[] args)
    {
        List<Kirja> kirjalista = new List<Kirja>();

        while (true)
        {
            Console.WriteLine("Tervetuloa! Mitä haluat tehdä? Lisää kirja, paina L. Tulosta lista, paina T. Tyhjä lopettaa.");
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

            else
            {
                break;
            }
        }
    }
}