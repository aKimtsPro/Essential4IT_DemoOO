using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models.Heritage
{
    public class Vehicule
    {
        //public string Marque;

        public string Marque { get; protected set; }
        public string Modele { get; set; }


        private int _kmParcouru;

        public int KmParcouru
        {
            get { 
                return _kmParcouru; 
            }
            private set {
                if (value >= 0)
                {
                    _kmParcouru = value;
                }
            }
        }

        public Vehicule(){}

        public Vehicule(string marque, string modele) {
            this.Marque = marque;
            this.Modele = modele;
            this.KmParcouru = 0;
        }

        public virtual void SeDeplacer(int km)
        {
            Console.WriteLine($"Le vehicule de deplace de {km} km");
            this.KmParcouru = this.KmParcouru + km;
        }

        public override string? ToString()
        {
            return $"Vehicule {{ " +
                   $"marque: {Marque}, " +
                   $"modele: {Modele}, " +
                   $"kmParcouru: {KmParcouru} " +
                   $"}}";
        }

        public override bool Equals(object? o)
        {
            if (!(o is Vehicule))
                return false;

            Vehicule that = (Vehicule) o;

            return this.Marque == that.Marque &&
                   this.Modele == that.Modele;
        }
        
        

    }
}
