namespace DemoInterface;

public class VoitureAmphibie : Vehicule, IAmphibie
{
    public bool ModeMaritime { get; set; }

    public override void SeDeplacer()
    {
        if (ModeMaritime)
        {
            Naviguer();
        }
        else
        {
            Rouler();
        }
    }

    public void Naviguer()
    {
        Console.WriteLine("Je navigue (amphibie)");
    }
    
    public void Rouler()
    {
        Console.WriteLine("Je roule (amphibie)");
    }

    public void ChangerMode()
    {
        ModeMaritime = !ModeMaritime;
    }
}