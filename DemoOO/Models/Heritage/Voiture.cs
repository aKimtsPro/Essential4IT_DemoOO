using DemoOO.Models.Encaps;

namespace DemoOO.Models.Heritage;

public class Voiture : Vehicule
{
    public int NbrPortes { get; private set; }

    public Voiture(string marque, string modele, int nbrPortes) : base(marque, modele)
    {
        NbrPortes = nbrPortes;
    }

    public Voiture()
    {
        NbrPortes = 5;
        Marque = "truc";
    }

    public override void SeDeplacer(int km)
    {
        base.SeDeplacer(km);
        Console.WriteLine("Je me deplace en tant que Voiture");
    }


    public void SeDeplacer()
    {
        base.SeDeplacer(10);
    }

    public override void SeGarer()
    {
        Console.WriteLine("Je me gare en tant que voiture");
    }


}