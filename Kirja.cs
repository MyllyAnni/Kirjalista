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

    public static void LisääKirja(List<Kirja> listaKirjoista, Kirja uusiKirja)
    {
        listaKirjoista.Add(uusiKirja);
    }
}