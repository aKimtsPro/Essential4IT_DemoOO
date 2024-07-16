namespace Exo7_Interfaces.Interfaces;

public interface IBanker : ICustomer
{
    public void AppliquerInteret();
    public string Numero { get; }
    public Personne Titulaire { get; }

    // public double LigneDeCredit { get; set; }
    // Si on faisait cette modification, le compte devrait créer une 
    // prop LigneDeCredit
}