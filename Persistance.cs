using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste // AP
{
    static class Persistance
    {
        //public static SqlConnection cnx = new SqlConnection("Data Source=192.168.1.70;User Id=cnxtest;password=cnxtest;Initial Catalog=CreditCelesteAP;");

        public static SqlConnection cnx = new SqlConnection("Data Source=10.129.187.129; User Id = cnxtest; password = cnxtest; Initial Catalog = CreditCelesteAP");


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



    }
}
