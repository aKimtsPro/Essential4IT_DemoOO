
using Exo6_Abstract;

Personne personne = new Personne(); ;

Courant courant = new Courant("BE01", personne);
Epargne epargne = new Epargne("BE02", personne);

courant.LigneDeCredit = 100;
courant.Retrait(10); // Solde: -10

courant.AppliquerInteret(); // -10.975

Console.WriteLine(courant.Solde);

courant.Depot(110.975);
courant.AppliquerInteret(); // 103

Console.WriteLine(courant.Solde);

epargne.Depot(100);
epargne.AppliquerInteret(); // 104.5

Console.WriteLine(epargne.Solde);
