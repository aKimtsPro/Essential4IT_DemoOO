namespace Exo4_Heritage
{
    public class Banque
    {
        private Dictionary<string, Compte> Comptes { get; set; } = new Dictionary<string, Compte>();
        public string Nom { get; set; } // banque.Nom = "bazar"

        public Banque(string nom)
        {
            Nom = nom;
        }

        public Compte? this[string numCompte]
        {
            get // Console.WriteLine( banque["BE01"] )
            {
                if (Comptes.ContainsKey(numCompte))
                    return Comptes[numCompte];
                else
                    return null;
            }
            // set { } // banque["BE01"] = new Courant(...)
        }

        public void Ajouter(Compte courant)
        {
            Comptes.Add(courant.Numero, courant);
        }

        public void Supprimer(string numero)
        {
            Comptes.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double somme = 0;

            foreach (Compte compte in Comptes.Values)
            {
                if (compte.Titulaire == titulaire)
                {
                    somme = somme + compte;
                    //somme += compte;
                }
            }

            return somme;
        }
    
    }
}
