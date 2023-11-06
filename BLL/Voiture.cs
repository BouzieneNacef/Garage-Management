using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Voiture : Automobile
    {
        public Voiture(int annee, int immatriculation, string couleur, string marque,
            string typeV) : base(annee, immatriculation)
        {
            this.couleur = couleur;
            this.marque = marque;
            this.typeV = typeV;
        }

        private string couleur {  get; set; }
        private string marque { get; set; }
        private string typeV { get; set; }

        public override string ToString()
        {
            return base.ToString()+ "le couleur "+couleur;
        }


    }
}
