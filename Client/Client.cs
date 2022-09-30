using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    public abstract class Client  
    {   // indique qu'il nest plus possible d'instancier un client, (cree un client)
        private int numeroClient;
        private string monCidClient;
        private string nomClient;
        private string prenomClient;

        public Client()
        {
            numeroClient = 87281;
            monCidClient = "M.";
            nomClient = "ZENNIR";
            prenomClient = "Aboubakr";
        }
        public Client(string nomC)
        {
            monCidClient = nomC;
        }

        public Client(string nomC, string prenomC)
        {
            nomClient = nomC;
            prenomClient = prenomC;
        }
        public Client(string moncid, string nomC, string prenomC)
        {
            monCidClient = moncid;
            nomClient = nomC;
            prenomClient = prenomC;
        }

        public Client(int numC,string moncid, string nomC, string prenomC)
        {
            numeroClient = numC;
            monCidClient = moncid;
            nomClient = nomC;
            prenomClient = prenomC;
        }


        public int getNumeroClient()
        {
            return numeroClient;
        }

        public void setNumeroClient(int numCli)
        {
            numeroClient = numCli;
        }

        public string getMonCidClient()
        {
            return monCidClient;
        }

        public void setCidClient(string monCid)
        {
            monCidClient = monCid;
        }

        // MUTATEURS GET ET SET nomClient
        public string getNomClient()
        {
            return nomClient;

        }

        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;

        }


        // MUTATEURS GET ET SET prenomClient
        public string getPrenomClient()
        {
            return prenomClient;
        }

        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;

        }

        public void setClient(string moncid, string nomC, string prenomC)
        {
            monCidClient = moncid;
            nomClient = nomC;
            prenomClient = prenomC;
        }






    }

}
