using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal interface IGarage
    {
        string AddAuto(Automobile au);
        string UpdateAuto(Automobile au);
        int GetIndexAuto(Automobile a1);
        string DelectAuto(Automobile immutriculation);
        Automobile GetAuto(String immutriculation);
        List<Automobile> AfficherAutomobiles(subType soustypes);

    }

    public enum subType {  Voiture, Moto}
}
