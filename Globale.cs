using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
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

        public static string gestBdd()
        {
            // connexion à une base de données
            //
            // serveur ; l'adresse IP/dns
            // le moyen d'accès
            // la base de données
            
            // trouver un moyen sécurisé : identifiants/ mdp
            // authentification sql server
            //string strConnexion = "Data Source=10.129.253.209;User Id=connEleveSio;password=mdpEleveSio;Initial Catalogue=CreditCeleste";
            // requete
            
            // authentification windows / domaine
            string strConnexion = "Data Source=15.0.2000.5;Integrated Security=SSPI;Initial Catalog=CreditCelesteFinal";
            //string strConnexion = "Data Source=10.129.187.103;User Id=Administrateur;password=Artemis22;Initial Catalog=CreditCelesteFinal";
            // s'authentifier avec notre base de donnée et notre nom de domaine



            // requete
            //
            string strRequete = "SELECT nomVendeur FROM Vendeur";
            //
            string aff = "";
            try  // permet d'esseyer, de tester, de controler l'erreur
            {
            
                // connexion à la base de données
                //
                SqlConnection oConnexion = new SqlConnection(strConnexion);
                // Rajoute l'objet SqlClient pour utiliser SqlConnextion
            
            
                // lancer la commande
                SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);
            
                //ouvrir ma base de données
                oConnexion.Open();
            
                //se positionner sur le premier objet
                //
                SqlDataReader oReader = oCommand.ExecuteReader();
            
                // lire un enregistrement
                while (oReader.Read())
                {
                    aff = Convert.ToString(oReader.GetValue(0));
                    //aff += oReader.GetValue(0) + " " + oReader.GetValue(1);
                    // Console.WriteLine(oReader.Item(0) + " " + oReader.Item(1)); VB
                    // Console.WriteLine(oReader.GetString(0) + " " + oReader.GetString(1));
                    //   Console.WriteLine(oReader[0] + " " + oReader[1]);    // comme un tableau
                    //  Console.WriteLine(oReader["nomVendeur"] + " " + oReader["prenomVendeur"]);
                }
                
                

                // fermer la base de données
                oReader.Close();
                oConnexion.Close();

            }
            
            catch (Exception ex)
            {
                aff = "Erreur : " + ex.Message;
                //aff = "Erreur : ";
            }

            return aff;
            
        }




    }
}
