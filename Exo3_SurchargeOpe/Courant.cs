using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3_SurchargeOpe
{
    public class Courant
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

        public override string ToString()
        {
            return $"Courant: {{ numero: {Numero}, solde: {Solde}, ligneDeCredit: {LigneDeCredit}, nomTitulaire: {Titulaire.Nom} }}";
        }

        public static double operator + (Courant a, Courant b)
        {
            double soldeEffectifA = a.Solde >= 0 ? a.Solde : 0;
            double soldeEffectifB = b.Solde >= 0 ? b.Solde : 0;

            return soldeEffectifA + soldeEffectifB;
            
            // [Alternative:]
            // if (a.Solde >= 0 && b.Solde >= 0)
            // {
            //     return a.Solde + b.Solde;
            // }
            // else if (a.Solde >= 0)
            // {
            //     return a.Solde + 0;
            // }
            // else if (b.Solde >= 0)
            // {
            //     return 0 + b.Solde;
            // }
            // else
            // {
            //     return 0 + 0;
            // }
        }

        public static double operator + (double b, Courant a)
        {
            double soldeEffectifA = a.Solde >= 0 ? a.Solde : 0;
            return soldeEffectifA + b;
        }
    }
}
