using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6_Abstract
{
    public abstract class Compte
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

        public Compte(string numero, Personne titulaire)
        {
            this.Numero = numero;
            this.Titulaire = titulaire;
        }


        public virtual void Retrait(double Montant)
        {
            if (Montant > 0)
            {
                Solde -= Montant;
            }
        }

        public virtual void Depot(double Montant)
        {
            if (Montant > 0)
            {
                Solde += Montant;
            }
        }

        public abstract double CalculerInteret();

        public void AppliquerInteret()
        {
            Solde += CalculerInteret();
        }


        public static double operator + (Compte a, Compte b)
        {
            double soldeEffectifA = a.Solde >= 0 ? a.Solde : 0;
            double soldeEffectifB = b.Solde >= 0 ? b.Solde : 0;

            return soldeEffectifA + soldeEffectifB;
        }
        
        public static double operator + (double b, Compte a)
        {
            double soldeEffectifA = a.Solde >= 0 ? a.Solde : 0;
            return soldeEffectifA + b;
        }
    }
}
