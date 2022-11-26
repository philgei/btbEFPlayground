using btbEFPlayground.EfCore.Entities.SubEntities;

namespace btbEFPlayground.EfCore.Entities;

public class Probe
{
    public DateOnly Betonierdatum { get; set; }
    public string LieferscheinNummer { get; set; }
    public IList<Bauteil> Bauteile { get; set; }
    public float Betonmenge { get; set; }
    
    public float Luftporengehalt { get; set; }
    public float LuftTemperatur { get; set; }
    public float Betontemperatur { get; set; }
    public float KonsitenzklasseSoll { get; set; }
    public float Ausbreitmass { get; set; }
    
    public int Wuerfelnummer { get; set; }
    public int ProbeAlter { get; set; }
    public float Rohdichte { get; set; }
    public float Drcukfestigkeit { get; set; }
    
    public IList<Nachbehandlung> Nachbehandlungen { get; set; }
    public int TageNachbehandlungSoll { get; set; }
    public int TageNachbehandlungIst { get; set; }
    
    public Sorte Sorte { get; set; }
    
    public Baustelle Baustelle { get; set; }
    
    public bool NichtPruefbar { get; set; }
    public bool SomethingWrong { get; set; }
    
    public int SortKey { get; set; }
}