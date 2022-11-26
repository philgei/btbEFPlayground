namespace btbEFPlayground.EfCore.Entities.SubEntities;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public IList<Telefonnummer> Telefonnummern { get; set; }
}