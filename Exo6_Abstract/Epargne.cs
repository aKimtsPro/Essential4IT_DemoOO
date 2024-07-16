using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6_Abstract
{
    internal class Epargne : Compte
    {
        public DateTime DateDernierRetrait { get; private set; }


        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {}

        public override void Retrait(double Montant)
        {
            if( Solde >= Montant)
            {
                base.Retrait(Montant);
                DateDernierRetrait = DateTime.Now;
            }
        }

        public override double CalculerInteret()
        {
            return Solde * 0.045;
        }
    }
}
