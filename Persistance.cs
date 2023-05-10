using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste // AP
{
    static class Persistance   // AP
    {


        public static SqlConnection cnx = new SqlConnection("Data Source=S922P03;User Id=test;password=Artemis23;Initial Catalog=CreditCelesteAP;");

        //public static SqlConnection cnx = new SqlConnection("Data Source=10.129.187.129; User Id = cnxtest; password = cnxtest; Initial Catalog = CreditCelesteAP");
        //public static SqlConnection cnx = new SqlConnection("Data Source=10.167.229.6; User Id = cnxtest; password = cnxtest; Initial Catalog = CreditCelesteAP");

        public static void insertClient()
        {
            // Enregistre le client dans la BDD
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("insertClient", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cidCli", Globale.unClientVoit.getMonCidClient());
                cmd.Parameters.AddWithValue("@nomCli", Globale.unClientVoit.getNomClient());
                cmd.Parameters.AddWithValue("@prenomCli", Globale.unClientVoit.getPrenomClient());
                cmd.Parameters.AddWithValue("@telCli", Globale.unClientVoit.getTelClient());
                cmd.Parameters.AddWithValue("@emailCli", Globale.unClientVoit.getEmailClient());
                cmd.Parameters.AddWithValue("@numRueCli", Globale.unClientVoit.getNumRueClient());
                cmd.Parameters.AddWithValue("@rueCli", Globale.unClientVoit.getRueClient());
                cmd.Parameters.AddWithValue("@villeCli", Globale.unClientVoit.getVilleClient());
                cmd.Parameters.AddWithValue("@cpCli", Globale.unClientVoit.getCodePostalClient());


                
                Console.WriteLine("@cidCli" + Globale.unClientVoit.getMonCidClient());
                Console.WriteLine("@nomCli" + Globale.unClientVoit.getNomClient());
                Console.WriteLine("@prenomCli" + Globale.unClientVoit.getPrenomClient());
                Console.WriteLine("@telCli" + Globale.unClientVoit.getTelClient());
                Console.WriteLine("@emailCli" + Globale.unClientVoit.getEmailClient());
                Console.WriteLine("@numRueCli" + Globale.unClientVoit.getNumRueClient());
                Console.WriteLine("@rueCli" + Globale.unClientVoit.getRueClient());
                Console.WriteLine("@villeCli" + Globale.unClientVoit.getVilleClient());
                Console.WriteLine("@cpCli" + Globale.unClientVoit.getCodePostalClient());


                SqlDataReader oReader = cmd.ExecuteReader();

                Console.WriteLine("Client inseré dans la bdd");

                Persistance.cnx.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                throw;
            }
        }


        // Methode permet de recuperer toute les regions des agences de la BDD
        public static void RecupConcessionRegionBDD()
        {
            try
            {
                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("affToutRegionConcession", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    
                    //Console.WriteLine(oReader["regionConcession"]);
                    // ici on stocke les regions dans la collection lesRegions qui est une variable globale
                    Globale.lesRegions.Add(Convert.ToString(oReader["regionConcession"]));
                                    
                }

                Persistance.cnx.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                throw;
            }

        }


        public static void RecupConcessionVilleBDD(string regionConcession)
        {
            try
            {
                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("affVilleConcession", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@regionConcession", regionConcession);

                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    //Console.WriteLine(Convert.ToString(oReader["villeAgence"]));
                    Globale.lesVilles.Add(Convert.ToString(oReader["villeConcession"]));
                }
              
                Persistance.cnx.Close();
                
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                
                throw;
            }

        }


        // Permet de récuperer tout les vendeurs de la BDD
        public static void RecupVendeurBDD(string codeConcession)
        {
            
            try
            {
                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("affVendeurs", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeConcession", codeConcession);

                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    Console.WriteLine(oReader["cidVendeur"] + " " + oReader["nomVendeur"] + " " + oReader["prenomVendeur"]);

                    // rajouter les vendeurs à la concession
                    Globale.uneConcession.ajoutVendeur(new Vendeur(Convert.ToString(oReader["cidVendeur"]), Convert.ToString(oReader["nomVendeur"]), Convert.ToString(oReader["prenomVendeur"])));
                }

                Persistance.cnx.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                throw;
            }

        }

        // Permet d'afficher tous les crédit de la BDD
        public static void affCreditEtude(string codeConcession)
        {

         try
            {
                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("affCreditEtude", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeConcession", codeConcession);

                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    //Console.WriteLine(oReader["nomClient"] + " " + oReader["prenomClient"] + " " + oReader["montantCredit"] + " " + oReader["tauxCredit"] + " " + oReader["dureeCredit"] + " " + oReader["mensualite"] + " " + oReader["dateSaisie"] + " " + oReader["nomVendeur"]);


                    //aff = "Nom : " + oReader["nomClient"] + " " + " | " + " Prenom : " + oReader["prenomClient"] + " " + " | " + " Montant : " + oReader["montantCredit"] + " " + " | " + " Taux : " + oReader["tauxCredit"] + " " + " | " + " Duree : " + oReader["dureeCredit"] + " " + " | " + " Mensualite : " + oReader["mensualite"] + " " + " | " + " Date : " + oReader["dateSaisie"] + " " + " | " + " Vendeur : " + oReader["nomVendeur"];

                    Globale.lesCreditEtude.Add(new Credit(Convert.ToInt32(oReader["numCredit"]), Convert.ToString(oReader["nomClient"]),
                        Convert.ToString(oReader["prenomClient"]), Convert.ToDouble(oReader["montantCredit"]), Convert.ToDouble(oReader["dureeCredit"]),
                        Convert.ToDouble(oReader["tauxCredit"]), Convert.ToDouble(oReader["mensualite"])));
              
                }

                Persistance.cnx.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                throw;
            }

        }



        public static void EtudierCredit(int numCredit,string codeValidation)
        {

            try
            {
                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("EtudierCredit", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numCredit", numCredit);
                cmd.Parameters.AddWithValue("@codeValidation", codeValidation);

                SqlDataReader oReader = cmd.ExecuteReader();

                Persistance.cnx.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                throw;
            }

        }

        public static int RecupCodeClientBDD()
        {

            try
            {

                int codeClient = 0;

                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("recupCodeClient", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomClient", Globale.unClientVoit.getNomClient());
                cmd.Parameters.AddWithValue("@prenomClient", Globale.unClientVoit.getPrenomClient());

                SqlDataReader oReader = cmd.ExecuteReader();

                if (oReader.Read())
                {
                    //Console.WriteLine("Le numéro du client est : " + oReader["codeClient"]);
                    codeClient = Convert.ToInt32(oReader["codeClient"]);
                }
                //Console.WriteLine(numVendeur);
                Persistance.cnx.Close();
                return codeClient;
                //return Convert.ToString(oReader["numVendeur"]);


            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                //return Convert.ToString(ex.Message);
                throw;
            }

        }




        public static int RecupNumVendeurBDD()
        {

            try
            {
                string nomVendeur = "";
                string prenomVendeur = "";
                int numVendeur = 0;


                foreach (Vendeur xVendeur in Globale.uneConcession.getLesVendeurs())
                {
                    string nomCompletVendeur = xVendeur.MonIdVendeur + " " + xVendeur.MonNomVendeur + " " + xVendeur.MonPrenomVendeur;

                    //Console.WriteLine(nomCompletVendeur);

                    if (nomCompletVendeur == Globale.unClientVoit.getVendeur())
                    {
                        //Console.WriteLine("Compare nomCompletVendeur : " + nomCompletVendeur + "à" + "Globale.unClientVoit.getVendeur() : " + Globale.unClientVoit.getVendeur());
                        nomVendeur = xVendeur.MonNomVendeur;
                        prenomVendeur = xVendeur.MonPrenomVendeur;

                        //Console.Write(nomVendeur + " " + prenomVendeur);
                    }


                }


                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("recupNumVendeur", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomVendeur", nomVendeur);
                cmd.Parameters.AddWithValue("@prenomVendeur", prenomVendeur);

                SqlDataReader oReader = cmd.ExecuteReader();

                if (oReader.Read())
                {
                    //Console.WriteLine("Le numéro du vendeur est : " + oReader["numVendeur"]);
                    numVendeur = Convert.ToInt32(oReader["numVendeur"]);
                }
                //Console.WriteLine(numVendeur);
                Persistance.cnx.Close();
                return numVendeur;
                //return Convert.ToString(oReader["numVendeur"]);


            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                //return ex.Message;
                throw;
            }

        }

        public static void insertCredit(string montantCredit, string tauxCredit, string dureeCredit, string mensualiteCredit, int numVendeur, int codeClient, string codeValidation, string codeColl, string codeConcess)
        {
            try
            {
                Persistance.cnx.Open();


                SqlCommand cmd = new SqlCommand("insertCredit", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter param;

                param = cmd.Parameters.Add("@montantCredit", SqlDbType.VarChar, 50);

                param.Value = montantCredit;

                param = cmd.Parameters.Add("@tauxCredit", SqlDbType.VarChar, 50);

                param.Value = tauxCredit;

                param = cmd.Parameters.Add("@dureeCredit", SqlDbType.VarChar, 50);

                param.Value = dureeCredit;

                param = cmd.Parameters.Add("@mensualite", SqlDbType.VarChar, 50);

                param.Value = mensualiteCredit;

                param = cmd.Parameters.Add("@dateSaisie", SqlDbType.VarChar, 50);

                param.Value = Convert.ToString(DateTime.Now);

                param = cmd.Parameters.Add("@numVendeur", SqlDbType.Int, 10);

                // la fonction RecupNumVendeurBDD() permet de recuperer le numVendeur
                //int numVendeur = Convert.ToInt32(Persistance.RecupNumVendeurBDD());
                param.Value = numVendeur;

                param = cmd.Parameters.Add("@codeClient", SqlDbType.Int, 10);

                //int codeClient = Convert.ToInt32(Persistance.RecupCodeClientBDD());
                param.Value = codeClient;

                param = cmd.Parameters.Add("@codeValidation", SqlDbType.VarChar, 5);

                param.Value = codeValidation;

                param = cmd.Parameters.Add("@codeCollab", SqlDbType.VarChar, 50);

                param.Value = codeColl;

                param = cmd.Parameters.Add("@codeConcession", SqlDbType.VarChar, 50);

                param.Value = codeConcess;


                cmd.ExecuteNonQuery();

                Console.WriteLine("Credit inseré dans la bdd !!!!");

                cnx.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
                throw;
            }
        }



        public static void recupereConcByRegionVille(string regionConcession, string villeConcession)
        {
            try
            {
                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("recupereConcByRegionVille", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@region", regionConcession);
                cmd.Parameters.AddWithValue("@ville", villeConcession);

                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    Globale.uneConcession = new Concession(Convert.ToString(oReader["codeConcession"]), Convert.ToString(oReader["nomConcession"]), Convert.ToString(oReader["telConcession"]), Convert.ToString(oReader["emailConcession"]), Globale.laRegion, Globale.laVille, Convert.ToString(oReader["stockVehicule"]), Convert.ToString(oReader["codeCollab"]), Convert.ToString(oReader["nomCollab"]), Convert.ToString(oReader["prenomCollab"]));
                    //Console.WriteLine(Convert.ToString(oReader["villeAgence"]));
                   
                }

                Persistance.cnx.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);

                throw;
            }

        }




        public static void getMarquesConcession(string codeConcession)
        {
            try
            {
                                
                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("recupMarqueConcession", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeConcession", codeConcession);

                SqlDataReader oReader = cmd.ExecuteReader();


                while (oReader.Read())
                {
                    
        Globale.lesVoitures.Add(new Voiture(Convert.ToString(oReader["marque"]), Convert.ToString(oReader["modele"]), Convert.ToString(oReader["anneeModele"]), Convert.ToString(oReader["datePremImmat"]), Convert.ToString(oReader["numImmat"]), Convert.ToString(oReader["numSerie"]), Convert.ToString(oReader["puissance"]), Convert.ToString(oReader["energie"]), Convert.ToString(oReader["prixVehicule"])));
                    Console.WriteLine(Globale.lesVoitures.Count);

                }

                Persistance.cnx.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);

                throw;
            }

        }

        public static void getModelesMarquesConcession(string codeConcession, string marque)
        {
            try
            {

                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("recupModeleMarqueConcession", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeConcession", codeConcession);
                cmd.Parameters.AddWithValue("@marque", marque);

                SqlDataReader oReader = cmd.ExecuteReader();


                while (oReader.Read())
                {

                    Globale.lesVoitures.Add(new Voiture(Convert.ToString(oReader["marque"]), Convert.ToString(oReader["modele"]), Convert.ToString(oReader["anneeModele"]), Convert.ToString(oReader["datePremImmat"]), Convert.ToString(oReader["numImmat"]), Convert.ToString(oReader["numSerie"]), Convert.ToString(oReader["puissance"]), Convert.ToString(oReader["energie"]), Convert.ToString(oReader["prixVehicule"])));
                    Console.WriteLine(Globale.lesVoitures.Count);

                }

                Persistance.cnx.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);

                throw;
            }

        }

        public static void getAnneeModelesMarquesConcession(string codeConcession, string marque, string modele)
        {
            try
            {

                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("recupAnneeModeleMarqueConcession", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeConcession", codeConcession);
                cmd.Parameters.AddWithValue("@marque", marque);
                cmd.Parameters.AddWithValue("@modele", modele);

                SqlDataReader oReader = cmd.ExecuteReader();


                while (oReader.Read())
                {

                    Globale.lesVoitures.Add(new Voiture(Convert.ToString(oReader["marque"]), Convert.ToString(oReader["modele"]), Convert.ToString(oReader["anneeModele"]), Convert.ToString(oReader["datePremImmat"]), Convert.ToString(oReader["numImmat"]), Convert.ToString(oReader["numSerie"]), Convert.ToString(oReader["puissance"]), Convert.ToString(oReader["energie"]), Convert.ToString(oReader["prixVehicule"])));
                    Console.WriteLine(Globale.lesVoitures.Count);

                }

                Persistance.cnx.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);

                throw;
            }

        }


        public static void getEnergieAnneeModelesMarquesConcession(string codeConcession, string marque, string modele, string annee)
        {
            try
            {

                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("recupEnergieAnneeModeleMarqueConcession", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeConcession", codeConcession);
                cmd.Parameters.AddWithValue("@marque", marque);
                cmd.Parameters.AddWithValue("@modele", modele);
                cmd.Parameters.AddWithValue("@anneeModele", annee);

                SqlDataReader oReader = cmd.ExecuteReader();


                while (oReader.Read())
                {

                    Globale.lesVoitures.Add(new Voiture(Convert.ToString(oReader["marque"]), Convert.ToString(oReader["modele"]), Convert.ToString(oReader["anneeModele"]), Convert.ToString(oReader["datePremImmat"]), Convert.ToString(oReader["numImmat"]), Convert.ToString(oReader["numSerie"]), Convert.ToString(oReader["puissance"]), Convert.ToString(oReader["energie"]), Convert.ToString(oReader["prixVehicule"])));
                    Console.WriteLine(Globale.lesVoitures.Count);

                }

                Persistance.cnx.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);

                throw;
            }

        }

        public static void getPuissanceEnergieAnneeModelesMarquesConcession(string codeConcession, string marque, string modele, string annee, string energie)
        {
            try
            {

                Persistance.cnx.Open();
                SqlCommand cmd = new SqlCommand("recupPuissanceEnergieAnneeModeleMarqueConcession", Persistance.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeConcession", codeConcession);
                cmd.Parameters.AddWithValue("@marque", marque);
                cmd.Parameters.AddWithValue("@modele", modele);
                cmd.Parameters.AddWithValue("@anneeModele", annee);
                cmd.Parameters.AddWithValue("@energie", energie);

                SqlDataReader oReader = cmd.ExecuteReader();


                while (oReader.Read())
                {

                    Globale.lesVoitures.Add(new Voiture(Convert.ToString(oReader["marque"]), Convert.ToString(oReader["modele"]), Convert.ToString(oReader["anneeModele"]), Convert.ToString(oReader["datePremImmat"]), Convert.ToString(oReader["numImmat"]), Convert.ToString(oReader["numSerie"]), Convert.ToString(oReader["puissance"]), Convert.ToString(oReader["energie"]), Convert.ToString(oReader["prixVehicule"])));
                    Console.WriteLine(Globale.lesVoitures.Count);

                }

                Persistance.cnx.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);

                throw;
            }

        }

        public static void ChargerImages(string codeConcession, string marque, string modele, string annee, string energie, PictureBox pic)
        {
            try
            {
                using (SqlConnection oCnx = cnx)
                {
                    using (SqlCommand cmd = oCnx.CreateCommand())
                    {
                        Persistance.cnx.Open();
                        new SqlCommand("recupImageVoiture", Persistance.cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codeConcession", codeConcession);
                        cmd.Parameters.AddWithValue("@marque", marque);
                        cmd.Parameters.AddWithValue("@modele", modele);
                        cmd.Parameters.AddWithValue("@anneeModele", annee);
                        cmd.Parameters.AddWithValue("@energie", energie);
                        SqlDataReader dr;
                        //oCnx.QuickOpen(3000);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            pic.Image = Globale.ConvertByteArrayToImage((byte[])dr["imageVehicule"]);
                        }
                        oCnx.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }


    }
}
