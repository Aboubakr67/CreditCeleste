using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Voiture
    {
        private string monNomVehicule;
        private string monAncienVehicule;

        // frmVoiture
        private string monMarque;
        private string monModele;
        private string monEnergie;
        private string monAnneeModele;
        private string monPuissance;
        private string monNumeroSerie;
        private string monDatePremImmat;
        private string monNumeroImmat;
        private string monAgeVehicule;



        public Voiture(string monNomVehicule, string monAgeVehicule, string monAncienVehicule)
        {
            // info de l'écran Introduction
            this.monNomVehicule = monNomVehicule;
            this.monAgeVehicule = monAgeVehicule;
            this.monAncienVehicule = monAncienVehicule;
        }

        public Voiture(string NomVehicule, string AgeVehicule, string AncienVehicule, 
            string DatePremImmat, string NumeroImmat, string NumeroSerie, 
            string Puissance)
        {
            // avec tout les élements
            // si on crée l'objet à partir de l'ecran
            monNomVehicule = NomVehicule;
            monAgeVehicule = AgeVehicule;
            monAncienVehicule = AncienVehicule;
            monDatePremImmat = DatePremImmat;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
        }

        //frmVoiture
        public Voiture(string marque, string modele, string energie, string anneeModele, string puissance, string numeroSerie, string datePremImmat, string numeroImmat, string ageVehicule)
        {
            monMarque = marque;
            monModele = modele;
            monEnergie = energie;
            monAnneeModele = anneeModele;
            monPuissance = puissance;
            monNumeroSerie = numeroSerie;
            monDatePremImmat = datePremImmat;
            monNumeroImmat = numeroImmat;
            monAgeVehicule = ageVehicule;
        }



        public void majVersBdd()
        {
            // stocke l'objet dans la base de données
        }

        // Creee get et set

        public void setVoiture(string NomVehicule,string AgeVehicule,string AncienVehicule)
        {
            // premier ecran
            monNomVehicule = NomVehicule;
            monAgeVehicule = AgeVehicule;
            monAncienVehicule = AncienVehicule;

        }
        public void setVoiture(string NomVehicule, string AgeVehicule, string AncienVehicule,
            string DatePremImmat, string NumeroImmat, string NumeroSerie,
            string Puissance)
        {
            // deuxieme ecran
            monNomVehicule = NomVehicule;
            monAgeVehicule = AgeVehicule;
            monAncienVehicule = AncienVehicule;
            monDatePremImmat = DatePremImmat;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
        }

        public void setVoiture(string NomVehicule, string AgeVehicule,
            string DatePremImmat, string NumeroImmat, string NumeroSerie,
            string Puissance)
        {
            // avec tout sauf ancien vehicule
            monNomVehicule = NomVehicule;
            monAgeVehicule = AgeVehicule;
            monDatePremImmat = DatePremImmat;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
        }


        // frmVoiture ----------------------------------------------------------------------------------------------------------------------
        public void setVoiture(string marque, string modele, string energie, string anneeModele, string puissance, string numeroSerie, string datePremImmat, string numeroImmat, string ageVehicule)
        {
            monMarque = marque;
            monModele = modele;
            monEnergie = energie;
            monAnneeModele = anneeModele;
            monPuissance = puissance;
            monNumeroSerie = numeroSerie;
            monDatePremImmat = datePremImmat;
            monNumeroImmat = numeroImmat;
            monAgeVehicule = ageVehicule;
        }

        //private string monNomVehicule;
        //private string monAncienVehicule;

        //// frmVoiture
        //private string monMarque;
        //private string monModele;
        //private string monEnergie;
        //private string monAnneeModele;
        //private string monPuissance;
        //private string monNumeroSerie;
        //private string monDatePremImmat;
        //private string monNumeroImmat;
        //private string monAgeVehicule;

        public string getNomVehicule()
        {
            return monNomVehicule;
        }

        public string getAncienVehicule()
        {
            return monAncienVehicule;
        }

        public string getMarque()
        {
            return monMarque;
        }

        public string getModele()
        {
            return monModele;
        }

        public string getEnergie()
        {
            return monEnergie;
        }

        public string getAnneeModele()
        {
            return monAnneeModele;
        }

        public string getPuissance()
        {
            return monPuissance;
        }

        public string getNumeroSerie()
        {
            return monNumeroSerie;
        }

        public string getDatePremImmat()
        {
            return monDatePremImmat;
        }

        public string getNumeroImmat()
        {
            return monNumeroImmat;
        }

        public string getAgeVehicule()
        {
            return monAgeVehicule;
        }

    }
}
