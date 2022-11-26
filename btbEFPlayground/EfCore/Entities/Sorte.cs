using btbEFPlayground.EfCore.Entities.SubEntities;

namespace btbEFPlayground.EfCore.Entities;

public class Sorte : BaseEntity
{
    public string Sortennummer { get; set; }
    public string Kurzbezeichnung { get; set; }
    public string Druckfestigkeitsklasse { get; set; }
    public Zementsorte Zementsorte { get; set; }
    public Zusatzstoff Zusatzstoff { get; set; }
    public Zusatzmittel Zusatzmittel { get; set; }
    public int Groesstkorn { get; set; }
    public float WZWert { get; set; }
    public FestigkeitsEntwicklung Festigkeitsentwicklung { get; set; }
}

public enum FestigkeitsEntwicklung
{
    schnell,
    mittel,
    lanngsam,
    sehrLangsam
}