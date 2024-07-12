namespace Exo0_Classes
{
    public class Personne
    {
        public string Prenom;
        public string Nom;
        public DateTime DateNaiss;

        public Personne(){}
        
        public Personne(string prenom, string nom, DateTime dateNaiss)
        {
            Prenom = prenom;
            Nom = nom;
            DateNaiss = dateNaiss;
        }

        public void SePresenter(Personne aSaluer)
        {
            Console.WriteLine($"Bonjour {aSaluer.Prenom} {aSaluer.Nom}, je suis {this.Prenom} {this.Nom}.");
        }
    }
}

