namespace DemoInterface;

public class Bateau : Vehicule, INaviguer
{
    public string Type { get; set; }

    public override void SeDeplacer()
    {
        Naviguer();
    }

    public void Naviguer()
    {
        Console.WriteLine("Je navigue");
    }
}