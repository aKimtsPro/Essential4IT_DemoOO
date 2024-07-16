namespace Exo7_Interfaces.Interfaces;

public interface IBanker : ICustomer
{
    public void AppliquerInteret();
    public string Numero { get; }
    public Personne Titulaire { get; }
}