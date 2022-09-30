using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste  // Mon tp
{
    class Concession
    {

       private string monNomConcession; // attribut propre à l'objet
        private string monAdresseConcession;


        // collection de vendeurs
        private List<Vendeur> lesVendeurs = new List<Vendeur>();
        // ilfaut créer la class vendeur


        public static string maRegion = "Alsace";  // attribut de classe
        // du moment qu'on declare une variable 

        public Concession()
        {
        }
        public Concession(string NomConcession, string AdresseConcession)
        {
            monNomConcession = NomConcession;
            monAdresseConcession = AdresseConcession;
        }

        // -- Mutateurs 
        // Propriétes
        public string MonAdresseConsession { get => monAdresseConcession; set => monAdresseConcession = value; }

        // pour rajouter un vendeur

        public void ajoutVendeur(Vendeur unVendeur)
        {
            lesVendeurs.Add(unVendeur);
        }

        public List<Vendeur> getLesVendeurs()
        {
            return lesVendeurs;
        }

    }
}
