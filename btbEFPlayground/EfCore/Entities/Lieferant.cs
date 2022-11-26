using btbEFPlayground.EfCore.Entities.SubEntities;

namespace btbEFPlayground.EfCore.Entities;

public class Lieferant
{
    public string Name { get; set; }
    public Adresse Adresse { get; set; }
    
    public IList<Lieferwerk> Lieferwerke { get; set; }
}