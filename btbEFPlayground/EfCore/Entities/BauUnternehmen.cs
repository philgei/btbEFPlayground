using btbEFPlayground.EfCore.Entities.SubEntities;

namespace btbEFPlayground.EfCore.Entities;

public class BauUnternehmen : BaseEntity
{
    public string Name { get; set; }
    public Adresse Adresse { get; set; }
    public string Email { get; set; }
    public IList<Telefonnummer> Telefonnummern { get; set; }
}