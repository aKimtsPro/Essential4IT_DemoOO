using Exo2_Indexeurs;

Personne p = new Personne("Luc", "Dubois", new DateTime(1990, 1, 1));

Courant c1 = new Courant("BE01", p);
Courant c2 = new Courant("BE02", p);
Courant c3 = new Courant("BE03", p);
Courant c4 = new Courant("BE04", p);

Banque banque = new Banque("Ma Banque");

banque.Ajouter(c1);
banque.Ajouter(c2);
banque.Ajouter(c3);
banque.Ajouter(c4);

Courant recupC1 = banque["BE01"];
Console.WriteLine( recupC1 == null ? "null" : recupC1 );

banque.Supprimer("BE02");

Courant recupC2 = banque["BE02"];
Console.WriteLine( recupC2 == null ? "null" : recupC2 );
