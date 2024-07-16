using DemoOOInterface.Interfaces;

namespace DemoOOInterface.Models;

public class Voiture : Vehicule, IRouler
{

    public int NbrPortes { get; set; }

    public Voiture() : base("ce que", "je veux"){}
    
    public Voiture(string marque, string modele) : base(marque, modele)
    {
    }

    public override void SeDeplacer()
    {
        Rouler();
    }

    public void Rouler()
    {
        Console.WriteLine("Je roule");
    }
}