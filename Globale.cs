﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste     // Projet APP Projet 
{
    static class Globale    // pas besoin de faire un new en static
                            // les données existent lors de la declaratio
    {
        // Classe particuliere pour stocker les variables globales
        // Gestion de la concession

        public static Concession uneConcession; // Declaration
                                                // Variable en dehort des programmes (static)

        // Gestion de mon application

        public static string monApplication = "Aboubakr";

        // gestion de la voiture
        public static Voiture uneVoiture;  // la voiture en cours de traitement

        // gestion du client et du vendeur

        public static ClientVoit unClientVoit;

        public static List<Credit> lesCredits = new List<Credit>();
        // pour déclarer et cree une liste de crédit

        // liste de toutes les regions des agences
        public static List<String> lesRegions = new List<string>();

        // stocke la region dans la variable globale laRegion
        public static string laRegion;


        // liste de toutes les villes ou se trouve l'agence selectionner
        public static List<String> lesVilles = new List<string>();

        // stocke la ville dans la variable globale laVille
        public static string laVille;





    }
}
