namespace Exo2_Indexeurs
{
    public class Personne
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateNaiss { get; set; }

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

