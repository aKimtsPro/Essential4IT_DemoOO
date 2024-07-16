namespace Exo7_Interfaces.Interfaces;

public interface ICustomer
{
    public double Solde { get; }
    public void Retrait(double Montant);
    public void Depot(double Montant);
}