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
        private int telClient;
        private string emailClient;
        private string numRueClient;
        private string rueClient;
        private string villeClient;
        private string cpClient;

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

        public Client(int numClient, string monCid, string nomC, string prenomC, 
            int telC, string emailC, string numRueC, string rueC, string villeC, 
            string cpC)
        {
            numeroClient = numClient;
            monCidClient = monCid;
            nomClient = nomC;
            prenomClient = prenomC;
            telClient = telC;
            emailClient = emailC;
            numRueClient = numRueC;
            rueClient = rueC;
            villeClient = villeC;
            cpClient = cpC;
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

        public int getTelClient()
        {
            return telClient;
        }

        public void setTelClient(int telC)
        {
            telClient = telC;
        }

        public string getEmailClient()
        {
            return emailClient;
        }

        public void setEmailClient(string emailC)
        {
            emailClient = emailC;
        }

        public string getNumRueClient()
        {
            return emailClient;
        }

        public void setNumRueClient(string numRueC)
        {
            numRueClient = numRueC;
        }

        public string getRueClient()
        {
            return emailClient;
        }

        public void setRueClient(string rueC)
        {
            rueClient = rueC;
        }
        public string getVilleClient()
        {
            return emailClient;
        }

        public void setVilleClient(string villeC)
        {
            villeClient = villeC;
        }

        public string getCodePostalClient()
        {
            return emailClient;
        }

        public void setCodePostalClient(string cpC)
        {
            cpClient = cpC;
        }

        public void setClient(string moncid, string nomC, string prenomC)
        {
            monCidClient = moncid;
            nomClient = nomC;
            prenomClient = prenomC;
        }

        public void setClient(int numClient, string monCid, string nomC, string prenomC,
            int telC, string emailC, string numRueC, string rueC, string villeC,
            string cpC)
        {
            numeroClient = numClient;
            monCidClient = monCid;
            nomClient = nomC;
            prenomClient = prenomC;
            telClient = telC;
            emailClient = emailC;
            numRueClient = numRueC;
            rueClient = rueC;
            villeClient = villeC;
            cpClient = cpC;
        }





    }

}
