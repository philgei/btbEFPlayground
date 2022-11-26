using btbEFPlayground.EfCore.Entities.SubEntities;

namespace btbEFPlayground.EfCore.Entities;

public class Behoerde : BaseEntity
{
    public string Name { get; set; }
    public string Adresse { get; set; }
    
    public IList<Telefonnummer> Telefonnummern { get; set; }
}