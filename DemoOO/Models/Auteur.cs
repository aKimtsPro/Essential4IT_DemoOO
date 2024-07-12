
namespace DemoOO.Models
{
    internal class Auteur
    {
        public string? Nom { get; set; }

        public Auteur(string nom)
        {
            Nom = nom;
        }

        public static Auteur operator + (Auteur a, Auteur b)
        {
            // static => this n'est pas utilisable
            return new Auteur(a.Nom + ' ' + b.Nom);
        }

        public static Auteur operator + (Auteur a, string b)
        {
            // static => this n'est pas utilisable
            return new Auteur(a.Nom + ' ' + b);
        }

        // Cas particulier:
        // Si je défini l'opération true, je dois aussi défini l'opération false
        public static bool operator true (Auteur auteur)
        {
            // static => this n'est pas utilisable
            return auteur.Nom != null;
        }

        public static bool operator false(Auteur auteur)
        {
            // static => this n'est pas utilisable
            return auteur.Nom == null;
        }
        
    }
}
