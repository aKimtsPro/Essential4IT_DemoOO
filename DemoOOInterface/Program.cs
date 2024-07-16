

using DemoInterface;

IRouler rouler = new Voiture();
rouler = new VoitureAmphibie();

INaviguer naviguer = new Bateau();
naviguer = new VoitureAmphibie();

rouler.Rouler();

naviguer.Naviguer();