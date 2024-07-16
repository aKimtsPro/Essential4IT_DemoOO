namespace DemoOOInterface.Models;

public abstract class Vehicule
{
    public string Marque { get; set; }
    internal string Modele { get; set; }

    protected Vehicule(string marque, string modele)
    {
        Marque = marque;
        Modele = modele;
    }

    public abstract void SeDeplacer();
    
    // Ceci serait une surcharge
    // public abstract void SeDeplacer(int distance); 

}