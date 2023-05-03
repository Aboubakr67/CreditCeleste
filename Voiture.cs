using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Voiture
    {
<<<<<<< HEAD
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



=======
        private string maMarqueVehicule;
        private string monAnneeVehicule;
        private string monModeleVehicule;
        private string monNumeroImmat;
        private string monNumeroSerie;
        private string monPuissance;
        private string monDate1erimmatriculation;
        private string energie;
        private string prixVehicule;
        private byte imageVehicule;


        public Voiture(string maMarqueVehicule)
        {
            // info de l'écran Introduction
            this.maMarqueVehicule = maMarqueVehicule;
        }

        public Voiture(string maMarqueVehicule, string monAnneeVehicule)
        {
            // info de l'écran Introduction
            this.maMarqueVehicule = maMarqueVehicule;
            this.monAnneeVehicule = monAnneeVehicule;
        }

        public Voiture(string NomVehicule, string modele, string annee, 
            string Date1erimmatriculation, string NumeroImmat, string NumeroSerie, 
            string Puissance, string energ, string prixVeh)
        {
            // avec tout les élements
            // si on crée l'objet à partir de l'ecran
            maMarqueVehicule = NomVehicule;
            monModeleVehicule = modele;
            monAnneeVehicule = annee;
            monDate1erimmatriculation = Date1erimmatriculation;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
            energie = energ;
            prixVehicule = prixVeh;
        }

>>>>>>> origin/Aboubakr
        public void majVersBdd()
        {
            // stocke l'objet dans la base de données
        }

        // Creee get et set

<<<<<<< HEAD
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
=======
        public void setVoiture(string NomVehicule,string AgeVehicule)
        {
            // premier ecran
            maMarqueVehicule = NomVehicule;
            monAnneeVehicule = AgeVehicule;

        }
        public void setVoiture(string NomVehicule, string modele, string annee,
            string Date1erimmatriculation, string NumeroImmat, string NumeroSerie,
            string Puissance, string energ, string prixVeh)
        {
            // deuxieme ecran
            maMarqueVehicule = NomVehicule;
            monModeleVehicule = modele;
            monAnneeVehicule = annee;
            monDate1erimmatriculation = Date1erimmatriculation;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
            energie = energ;
            prixVehicule = prixVeh;
        }

        public void setVoiture(string NomVehicule, string AgeVehicule,
            string Date1erimmatriculation, string NumeroImmat, string NumeroSerie,
            string Puissance, string energ, string prixVeh)
        {
            // avec tout sauf ancien vehicule
            maMarqueVehicule = NomVehicule;
            monAnneeVehicule = AgeVehicule;
            monDate1erimmatriculation = Date1erimmatriculation;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
            energie = energ;
            prixVehicule = prixVeh;
        }



        public string getMarque()
        {
            return maMarqueVehicule;
        }

        public string getDatePremiereImma()
        {
            return monDate1erimmatriculation;
>>>>>>> origin/Aboubakr
        }

        public string getModele()
        {
<<<<<<< HEAD
            return monModele;
        }

        public string getEnergie()
        {
            return monEnergie;
        }

        public string getAnneeModele()
        {
            return monAnneeModele;
=======
            return monModeleVehicule;
        }

        public string getNumImmatriculation()
        {
            return monNumeroImmat;
        }

        public string getNumSerie()
        {
            return monNumeroSerie;
>>>>>>> origin/Aboubakr
        }

        public string getPuissance()
        {
            return monPuissance;
        }

<<<<<<< HEAD
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
=======
        public string getAnneeVehicule()
        {
            return monAnneeVehicule;
        }

        public string getEnergieVehicule()
        {
            return energie;
        }

        public string getPrixVehicule()
        {
            return prixVehicule;
        }

        public byte getImageVehicule()
        {
            return imageVehicule;
>>>>>>> origin/Aboubakr
        }

    }
}
