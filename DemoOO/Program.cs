

using DemoOO.Models;
using DemoOO.Models.Encaps;
using DemoOO.Models.Indexeur;
using Monnaie = DemoOO.Models.Monnaie;

public class Program
{
    private static void Main(string[] args)
    {

        Vehicule v = new Vehicule("mark", "model");

        v.SeDeplacer(15);

        //v.SetKmParcouru(-15); // private
        //v.KmParcouru = 50; // set en private


        v.SeDeplacer(25);

        Console.WriteLine( v.KmParcouru ); // 40

        // v.Marque = ":)";
        Console.WriteLine( v.Marque );

        Parking parking = new Parking("adresse", "leParking", 500);

        parking.SeGarer(v, 1);
        parking[1] = v;

        Vehicule vGare = parking.RecupVehicule(1);
        Vehicule vG = parking[1];
        // Vehicule vGare2 = parking[1];

        // parking.VehiculesGarees = new Dictionary<int, Vehicule>(); // set en private
        
        
        

    }
}