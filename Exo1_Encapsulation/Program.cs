

using Exo1_Encapsulation;

Personne personne = new Personne("Luc", "Dubois", new DateTime(1990,1,1));

Courant courant = new Courant("BE00001", personne);

courant.Depot(100);
courant.LigneDeCredit = 10;

courant.Retrait(111);

Console.WriteLine(courant.Solde);