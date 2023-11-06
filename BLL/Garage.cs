using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Garage : IGarage
    {
        public List<Automobile> Autos { get; set; }
        public string Adresse { get; set; }

        public Garage() { 
            Autos = new List<Automobile>();
        }

        public string AddAuto(Automobile au)
        {

            try
            {
                Autos.Add(au);
                return au.ToString();

            } catch(Exception ex) {
                return ex.Message;
            }

        }

        public List<Automobile> AfficherAutomobiles(subType soustypes)
        {
            throw new NotImplementedException();
        }

        public string DelectAuto(Automobile immutriculation)
        {
            try
            {
               Autos.Remove(immutriculation);
                return string.Empty;

            }
            catch (Exception ex)

            {
                return ex.Message; 
            }
        }

        public Automobile GetAuto(string immutriculation)
        {
            throw new NotImplementedException();
        }

        public int GetIndexAuto(Automobile a1)
        {
            throw new NotImplementedException();
        }

        public string UpdateAuto(Automobile au)
        {
            throw new NotImplementedException();
        }
    }
}
