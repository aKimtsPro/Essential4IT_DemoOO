namespace DemoInterface;

public class Voiture : Vehicule, IRouler
{

    public int NbrPortes { get; set; }

    public override void SeDeplacer()
    {
        Rouler();
    }

    public void Rouler()
    {
        Console.WriteLine("Je roule");
    }
}