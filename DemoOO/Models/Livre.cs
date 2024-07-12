

using DemoOO.Models.Edition;

namespace DemoOO.Models
{
    class Livre
    {
        public string Titre;
        public Auteur Auteur;
        public Editeur Editeur;
        public int? MarquePage;
        public int NbrPages;


        public Livre() { }

        public Livre(string titre, Auteur auteur, Editeur editeur, int? marquePage, int nbrPages)
        {
            Titre = titre;
            Auteur = auteur;
            Editeur = editeur;
            MarquePage = marquePage;
            NbrPages = nbrPages;
        }
       
        public Livre(Auteur auteur, string titre, Editeur editeur, int? marquePage = null, int nbrPages = 500)
        {
            this.Titre = titre;
            Auteur = auteur;
            Editeur = editeur;
            MarquePage = marquePage;
            NbrPages = nbrPages;
        }

        public void MettreMarquePage(int page)
        {
            this.RetirerMarquePage();
            this.MarquePage = page;
        }

        public void RetirerMarquePage()
        {
            MarquePage = null;
        }

    }
}
