using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1_Encapsulation
{
    internal class Courant
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

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

        public Courant(string numero, Personne titulaire)
        {
            this.Numero = numero;
            this.Titulaire = titulaire;
        }

        public void Retrait(double Montant)
        {
            if( Montant  <= Solde + LigneDeCredit && Montant > 0 )
            {
                this.Solde -= Montant;
            }
        }

        public void Depot(double Montant)
        {
            if( Montant > 0)
            {
                this.Solde += Montant;
            }
        }


    }
}
