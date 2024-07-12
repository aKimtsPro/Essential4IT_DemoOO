using DemoOO.Models.Encaps;

namespace DemoOO.Models.Indexeur;

public class Parking
{
    public string Adresse { get; private set; }
    public string Nom { get; set; }
    private Dictionary<int, Vehicule> VehiculesGarees { get; set; } = new Dictionary<int, Vehicule>();
    private int _capacite;
    public int Capacite
    {
        get { return _capacite; }
        set {
            if( value >= 0 )
                _capacite = value;
        }
    }

    public Parking(string adresse, string nom, int capacite)
    {
        Adresse = adresse;
        Nom = nom;
        capacite = capacite;
    }

    
    public bool SeGarer(Vehicule vehicule, int place)
    {
        if (place > Capacite)
            return false;
        
        Vehicule gare = VehiculesGarees[place];
        if (gare != null)
            return false;
        
        VehiculesGarees.Add(place, vehicule);
        return true;
    }
    
    public Vehicule RecupVehicule(int place)
    {
        return VehiculesGarees[place];
    }
    
    public Vehicule this[int place]
    {
        get { return VehiculesGarees[place]; }
        set // renvoie void
        {
            if (place > Capacite)
                return;
        
            Vehicule gare = VehiculesGarees[place];
            if (gare != null)
                return;
        
            VehiculesGarees.Add(place, value);
        }
    }
    
    
    
}