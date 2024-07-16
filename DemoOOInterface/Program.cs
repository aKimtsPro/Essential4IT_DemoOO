

using DemoOOInterface;
using DemoOOInterface.Interfaces;
using DemoOOInterface.Models;

IRouler rouler = new Voiture();
rouler = new VoitureAmphibie("","");

INaviguer naviguer = new Bateau("","", TypeBateau.YACHT);
naviguer = new VoitureAmphibie("","");

rouler.Rouler();

naviguer.Naviguer();


BiduleIndexe b = new BiduleIndexe();

string rslt = b[3];

Console.WriteLine(rslt);