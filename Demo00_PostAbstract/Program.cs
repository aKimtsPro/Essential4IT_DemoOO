


using DemoOO_PostAbstract;

Voiture v = Voiture.GenererModele();

v.Modele = "modele";

Voiture.TauxEmissionMax = 5;

DateTime date = DateTime.Now;

VehiculeConvertisseur convertisseur = VehiculeConvertisseur.Instance;

IVoler volant = new Avion();
volant = new Oiseau();
// volant = new IVolant();