namespace DemoOOInterface.Models;

public abstract class Vehicule
{
    public string Marque { get; set; }
    internal string Modele { get; set; }

    public int KmParcouru { get; protected set; }
    
    protected Vehicule(string marque, string modele) : this(marque, modele, 0)
    {}

    protected Vehicule(string marque, string modele, int kmParcouru)
    {
        Marque = marque;
        Modele = modele;
        KmParcouru = kmParcouru;
    }
    
    

    public abstract void SeDeplacer();
    
    // Ceci serait une surcharge
    // public abstract void SeDeplacer(int distance); 

}