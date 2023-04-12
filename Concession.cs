using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste  // Mon tp
{
    class Concession
    {
        private string codeConcession;
        private string monNomConcession; // attribut propre à l'objet
        private string telConcession;
        private string mailConcession;
        private string regionConcession;
        private string villeConcession;
        private string stockVehicule;


        // collection de vendeurs
        private List<Vendeur> lesVendeurs = new List<Vendeur>();
        // il faut créer la class vendeur


        //public static string maRegion = "Alsace";  // attribut de classe
        // du moment qu'on declare une variable 

        public Concession()
        {
        }
        public Concession(string NomConcession, string laRegionConcession, string lavilleConcession)
        {
            monNomConcession = NomConcession;
            regionConcession = laRegionConcession;
            villeConcession = lavilleConcession;
        }

        public Concession(string codeC,string NomConcession, string telConc, string mailConc, string laRegionConcession, string lavilleConcession, string stock)
        {
            codeConcession = codeC;
            monNomConcession = NomConcession;
            telConcession = telConc;
            mailConcession = mailConc;
            regionConcession = laRegionConcession;
            villeConcession = lavilleConcession;
            stockVehicule = stock;
        }

        // -- Mutateurs 
        // Propriétes
        //public string MonAdresseConsession { get => monAdresseConcession; set => monAdresseConcession = value; }



        public string getCodeConcession()
        {
            return codeConcession;
        }

        public void setCodeConcession(string codeConc)
        {
            codeConcession = codeConc;
        }



        public string getMonNomConcession()
        {
            return monNomConcession;
        }

        public void setMonNomConcession(string leNomConcess)
        {
            monNomConcession = leNomConcess;
        }

        public string getTelConcession()
        {
            return telConcession;
        }

        public void setTelConcession(string leTelConcession)
        {
            telConcession = leTelConcession;
        }

        public void setMailConcession(string leMailConcession)
        {
            mailConcession = leMailConcession;
        }

        public string getMailConcession()
        {
            return mailConcession;
        }

        public void setRegionConcession(string laRegionConcession)
        {
            regionConcession = laRegionConcession;
        }

        public string getRegionConcession()
        {
            return regionConcession;
        }

        public void setVilleConcession(string laVilleConcession)
        {
            villeConcession = laVilleConcession;
        }

        public string getVilleConcession()
        {
            return villeConcession;
        }

        public void setStockVehicule(string leStockVehicule)
        {
            stockVehicule = leStockVehicule;
        }
        public string getStockVehicule()
        {
            return stockVehicule;
        }

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