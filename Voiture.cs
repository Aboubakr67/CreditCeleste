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
        private string monAgeVehicule;
        private string monAncienVehicule;
        private string monDate1erimmatriculation;
        private string monNumeroImmat;
        private string monNumeroSerie;
        private string monPuissance;

        public Voiture(string monNomVehicule, string monAgeVehicule, string monAncienVehicule)
        {
            // info de l'écran Introduction
            this.monNomVehicule = monNomVehicule;
            this.monAgeVehicule = monAgeVehicule;
            this.monAncienVehicule = monAncienVehicule;
        }

        public Voiture(string NomVehicule, string AgeVehicule, string AncienVehicule, 
            string Date1erimmatriculation, string NumeroImmat, string NumeroSerie, 
            string Puissance)
        {
            // avec tout les élements
            // si on crée l'objet à partir de l'ecran
            monNomVehicule = NomVehicule;
            monAgeVehicule = AgeVehicule;
            monAncienVehicule = AncienVehicule;
            monDate1erimmatriculation = Date1erimmatriculation;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
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
            string Date1erimmatriculation, string NumeroImmat, string NumeroSerie,
            string Puissance)
        {
            // deuxieme ecran
            monNomVehicule = NomVehicule;
            monAgeVehicule = AgeVehicule;
            monAncienVehicule = AncienVehicule;
            monDate1erimmatriculation = Date1erimmatriculation;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
        }

        public void setVoiture(string NomVehicule, string AgeVehicule,
            string Date1erimmatriculation, string NumeroImmat, string NumeroSerie,
            string Puissance)
        {
            // avec tout sauf ancien vehicule
            monNomVehicule = NomVehicule;
            monAgeVehicule = AgeVehicule;
            monDate1erimmatriculation = Date1erimmatriculation;
            monNumeroImmat = NumeroImmat;
            monNumeroSerie = NumeroSerie;
            monPuissance = Puissance;
        }



        public string getNomVoiture()
        {
            return monNomVehicule;
        }

        public string getDatePremiereImma()
        {
            return monDate1erimmatriculation;
        }

        public string getNumImmatriculation()
        {
            return monNumeroImmat;
        }

        public string getNumSerie()
        {
            return monNumeroSerie;
        }

        public string getPuissance()
        {
            return monPuissance;
        }

        public string getAgeVehicule()
        {
            return monAgeVehicule;
        }

        public string getAncienVehicule()
        {
            return monAncienVehicule;
        }

    }
}
