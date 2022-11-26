using btbEFPlayground.EfCore.Entities.SubEntities;

namespace btbEFPlayground.EfCore.Entities;

public class Baustelle
{
    public string Name { get; set; }
    public Adresse Adresse { get; set; }
    public Person Bauleiter { get; set; }
    public Person Polier { get; set; }
    public IList<Bauteil> Bauteile { get; set; }
    public IList<Festigkeitsklasse> Festigkeitsklassen { get; set; }
    public float GesamtMengeBeton { get; set; }
    public Lieferant Lieferant { get; set; }
    public DateOnly ErsterBetonTag { get; set; }
    public DateOnly LetzterBetonTag { get; set; }
    public Behoerde Behoerde { get; set; }
    public DateOnly DatumAnmeldung { get; set; }
    public DateOnly DatumAbmeldung { get; set; }
    public string VertragsNummer { get; set; }
    public string NachtragsNummer { get; set; }
}