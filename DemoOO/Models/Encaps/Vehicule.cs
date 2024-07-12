using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models.Encaps
{
    public class Vehicule
    {
        //public string Marque;

        public string Marque { get; private set; }
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



        public Vehicule(string marque, string modele) {
            this.Marque = marque;
            this.Modele = modele;
            this.KmParcouru = 0;
        }

        public void SeDeplacer(int km)
        {
            Console.WriteLine($"Le vehicule de deplace de {km} km");
            this.KmParcouru = this.KmParcouru + km;
        }

    }
}
