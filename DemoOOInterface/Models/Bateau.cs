using DemoOOInterface.Interfaces;

namespace DemoOOInterface.Models;

public class Bateau : Vehicule, INaviguer
{
    public TypeBateau Type { get; set; }


    public Bateau(string marque, string modele, TypeBateau type) : base(marque, modele)
    {
        Type = type;
    }

    public override void SeDeplacer()
    {
        Naviguer();
    }

    public void Naviguer()
    {
        Console.WriteLine("Je navigue");
    }
}