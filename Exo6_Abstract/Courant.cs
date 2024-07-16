using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6_Abstract
{
    public class Courant : Compte
    {

        private double _ligneDeCredit;

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set { 
                if( value >= 0)
                {
                    _ligneDeCredit = value;
                }
            }
        }

        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public override void Retrait(double Montant)
        {
            if( Montant <= Solde + LigneDeCredit )
            {
                base.Retrait(Montant);
            }
        }

        public override string ToString()
        {
            return $"Courant: {{ numero: {Numero}, solde: {Solde}, ligneDeCredit: {LigneDeCredit}, nomTitulaire: {Titulaire.Nom} }}";
        }

        public override double CalculerInteret()
        {
            if( Solde >= 0)
            {
                return Solde * 0.03;
            }
            else
            {
                return Solde * 0.0975;
            }
        }

    }
}
