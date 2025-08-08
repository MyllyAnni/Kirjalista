namespace Kirjat;

class Program
{
    static void Main(string[] args)
    {
        List<Kirja> listaKirjoista = new List<Kirja>();

        Console.WriteLine("Kirjan nimi: ");
        string nimi = Console.ReadLine() ?? "";

        Console.WriteLine("Kirjoittaja: ");
        string kirjoittaja = Console.ReadLine() ?? "";

        Console.WriteLine("Julkaisuvuosi: ");
        int vuosi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Genre: ");
        string genre = Console.ReadLine() ?? "";

        Kirja uusiKirja = new Kirja(nimi, kirjoittaja, vuosi, genre);

        Kirja.LisääKirja(listaKirjoista, uusiKirja);      
        Console.WriteLine("Kirja lisätty!");
    }
}