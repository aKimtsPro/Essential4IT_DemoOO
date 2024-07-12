namespace Exo2_Indexeurs;

public class Banque
{
    private Dictionary<string, Courant> Comptes { get; set; } = new Dictionary<string, Courant>();
    public string Nom { get; set; } // banque.Nom = "bazar"

    public Banque(string nom)
    {
        Nom = nom;
    }

    public Courant? this[string numCompte]
    {
        get // Console.WriteLine( banque["BE01"] )
        {
            if (Comptes.ContainsKey(numCompte))
                return Comptes[numCompte];
            else
                return null;
        }
        // set { } // banque["BE01"] = new Courant(...)
    }

    public void Ajouter(Courant courant)
    {
        Comptes.Add(courant.Numero, courant);
    }

    public void Supprimer(string numero)
    {
        Comptes.Remove(numero);
    }
    
}