namespace btbEFPlayground.EfCore.Entities.SubEntities;

public class Adresse : BaseEntity
{
    public string Strasse { get; set; }
    public string Hausnummer { get; set; }
    public string Postleitzahl { get; set; }
    public string Ort { get; set; }
    
    public string OLDName { get; set; }
}