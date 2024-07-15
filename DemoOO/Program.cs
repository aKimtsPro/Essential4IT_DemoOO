

using DemoOO.Models;
using DemoOO.Models.Heritage;
using DemoOO.Models.Indexeur;
using Monnaie = DemoOO.Models.Monnaie;

public class Program
{
    private static void Main(string[] args)
    {

        // Vehicule v = new Vehicule("mark", "model");
        //
        // v.SeDeplacer(15);
        //
        // //v.SetKmParcouru(-15); // private
        // //v.KmParcouru = 50; // set en private
        //
        //
        // v.SeDeplacer(25);
        //
        // Console.WriteLine( v.KmParcouru ); // 40
        //
        // // v.Marque = ":)";
        // Console.WriteLine( v.Marque );
        //
        // Parking parking = new Parking("adresse", "leParking", 500);
        //
        // parking.SeGarer(v, 1);
        // parking[1] = v;
        //
        // Vehicule vGare = parking.RecupVehicule(1);
        // Vehicule vG = parking[1];
        // // Vehicule vGare2 = parking[1];
        //
        // // parking.VehiculesGarees = new Dictionary<int, Vehicule>(); // set en private
        //
        // int a = 5, b = 7;
        // int c = a + b;
        //
        // string sA = "salut ", sB = "ca va?";
        // string sC = sA + sB;

        // [Demo surcharge d'operateur]
        // Auteur auteurA = new Auteur("Luc");
        // Auteur auteurB = new Auteur("Marie");
        //
        // // Possible uniquement grâce à la redéfinition de '+' dans Auteur
        // Auteur auteurC = auteurA + auteurB;
        //
        // Console.WriteLine(auteurA.Nom);
        // Console.WriteLine(auteurB.Nom);
        // Console.WriteLine(auteurC.Nom);
        //
        // // Possible uniquement grâce à la redéfinition de 'true' et 'false' dans Auteur
        // if (auteurC)
        // {
        //     Console.WriteLine("L'auteur a bien un nom");
        // }


        Voiture voiture = new Voiture("marque", "modele", 3);
        // A travers la variable de type Voiture, j'ai accès aux éléments de Voiture et de ses parents
        Console.WriteLine(voiture.KmParcouru);  // déclaré dans Vehicule
        Console.WriteLine(voiture.NbrPortes);   // déclaré dans Voiture
        // voiture.Marque = "truc"; // inaccessible car "protected" (seuls la classe et ses enfants)
        
        Vehicule vehicule = voiture; // contient une rèf à une Voiture
        // A travers la variable de type Vehicule, j'ai accès aux éléments de Vehicule et de ses parents
        Console.WriteLine(vehicule.KmParcouru); // déclaré dans Vehicule
        // Console.WriteLine(vehicule.NbrPortes); // déclaré dans Voiture => pas accessible
        
        Vehicule vehicule2 = new Vehicule("m", "m"); // contient une rèf à un Vehicule
        
        Voiture voit = (Voiture) vehicule2; // Erreur:
        // la variable vehicule2 ne fait pa réf à un objet compable avec le type Voiture
        
        Console.WriteLine("Tentative de cast de la variable vehicule");
        // Est-ce que la variable vehicule contient une réf. vers un objet Voiture (true)
        if (vehicule is Voiture)
        {
            Voiture v2 = (Voiture) vehicule; // on peut sans peur caster la valeur
            Console.WriteLine("C'est bien une Voiture");
        }
        else
        {
            Console.WriteLine("Ce n'est pas une Voiture");
        }
        
        Console.WriteLine("Tentative de cast de la variable vehicule2");
        // Est-ce que la variable vehicule2 contient une réf. vers un objet Voiture (false)
        if (vehicule2 is Voiture)
        {
            Voiture v2 = (Voiture) vehicule2; // on a eviter de caster la valeur => pas d'erreur
            Console.WriteLine("vehicule2 est bien une Voiture");
        }
        else
        {
            Console.WriteLine("vehicule2 n'est pas une Voiture");
        }

        
        object objVoit = voiture;
        object objVehicule = vehicule2;
        object objObj = new object();

        Console.WriteLine("--- DEMO OVERRIDE ToString ---");
        // version Vehicule ou version object?
        Console.WriteLine( voiture.ToString() );    // version Vehicule
        Console.WriteLine( vehicule2.ToString() );  // version Vehicule
        Console.WriteLine( objObj.ToString() );     // version object
        Console.WriteLine( objVehicule.ToString() );// version Vehicule
        Console.WriteLine( objVoit.ToString() );    // version Vehicule


        Vehicule veh1 = new Vehicule("marque1", "modele1"); // adr07
        Vehicule veh2 = new Vehicule("marque2", "modele1"); // adr48
        Vehicule veh3 = veh1; // adr07
        
        // veh2.SeDeplacer(15);

        // Vérifie les adresses 
        if (veh1 == veh2) // false
        {
            Console.WriteLine("le même objet");
        }
        else
        {
            Console.WriteLine("pas le même objet");
        }

        if (veh1.Equals(veh2))
        {
            Console.WriteLine("Les 2 objets sont égaux");
        }
        else
        {
            Console.WriteLine("Les 2 objets ne sont pas égaux");
        }

    }
}