namespace Kirjat;

public class Kirja
{
    public string Nimi { get; set; }
    public string Kirjoittaja { get; set; }
    public int Vuosi { get; set; }
    public string Genre { get; set; }

    public Kirja(string nimi, string kirjoittaja, int vuosi, string genre)
    {
        this.Nimi = nimi;
        this.Kirjoittaja = kirjoittaja;
        this.Vuosi = vuosi;
        this.Genre = genre;
    }

    public static void LisääKirja(List<Kirja> kirjalista, Kirja uusiKirja)
    {
        kirjalista.Add(uusiKirja);
    }

    public static void TulostaKirjalista(List<Kirja> kirjalista)
    {
        foreach (Kirja kirja in kirjalista)
        {
            Console.WriteLine($"{kirja.Nimi}, {kirja.Kirjoittaja}, {kirja.Vuosi}, {kirja.Genre}");
        }
    }

    public static void PoistaKirja(List<Kirja> kirjalista, Kirja poistettavaKirja)
    {
        kirjalista.Remove(poistettavaKirja);
        Console.WriteLine("Kirja poistettu!");
    }
}