using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class Automobile
    {
        public Automobile(int annee, int immatriculation)
        {
            this.annee = annee;
            this.immatriculation = immatriculation;
        }

        private int annee { get; set; }
        private int immatriculation { get; set; }

        public override string ToString()
        {
            return "lannee: "+annee+" et le matricule: "+immatriculation;
        }

        public void afficher() { }

        public void automobile() { }

      
    }



}
