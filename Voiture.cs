using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Voiture
    {
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

        public void majVersBdd()
        {
            // stocke l'objet dans la base de données
        }

        // Creee get et set

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
        }

        public string getModele()
        {
            return monModeleVehicule;
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
        }

    }
}
