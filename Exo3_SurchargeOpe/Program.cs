// See https://aka.ms/new-console-template for more information

using Exo3_SurchargeOpe;

Personne p1 = new Personne("Luc", "Dubois", new DateTime(1990,1,1));
Personne p2 = new Personne("Marie", "Debois", new DateTime(1990, 1, 1));

Courant c1 = new Courant("BE01", p1);
Courant c2 = new Courant("BE02", p1);
Courant c3 = new Courant("BE03", p2);

double rslt = 0.5 + c1;
rslt = c1 * 3;

Banque b = new Banque("MaBanque");

b.Ajouter(c1);
b.Ajouter(c2);
b.Ajouter(c3);

c1.LigneDeCredit = 100;
c1.Retrait(10); // solde: -10

c2.LigneDeCredit = 20;
c2.Depot(20); // solde: 20

c3.Depot(10000); // solde: 10000

// Test point 1
double sommeDesComptes = c1 + c2;
Console.WriteLine( $"Somme du premier et second compte: {sommeDesComptes}" ); // somme: 20

// Test point 2
Console.WriteLine( $"Total pour luc: {b.AvoirDesComptes(p1)}" ); // total: 20
Console.WriteLine( $"Total pour marie: {b.AvoirDesComptes(p2)}" ); // total: 10000
