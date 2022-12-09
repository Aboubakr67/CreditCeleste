using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Vendeur
    {
        private string monIdVendeur;
        private string monNomVendeur;
        private string monPrenomVendeur;// le prenom du vendeur
        private string test;


        public Vendeur()
        { }

        public Vendeur(string monId, string nomNom, string monPrenom)
        {
            MonIdVendeur = monId;
            MonNomVendeur = nomNom;
            MonPrenomVendeur = monPrenom;
        }


        public string getInfosVendeurs()
        {
            return monIdVendeur + " " + MonNomVendeur + " " + MonPrenomVendeur;
        }



        // Propriétes
        public string MonIdVendeur { get => monIdVendeur; set => monIdVendeur = value; }
        public string MonNomVendeur { get => monNomVendeur; set => monNomVendeur = value; }
        public string MonPrenomVendeur { get => monPrenomVendeur; set => monPrenomVendeur = value; }


    }
}
