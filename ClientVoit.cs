using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class ClientVoit : Client
    {
        private string nomVendeur;
        
        ClientVoit()
        {}

        public ClientVoit(string cidClient, string nomCli, string prenomCli):base(cidClient,nomCli, prenomCli)
        { }

        public ClientVoit(string cidClient, string nomCli, string prenomCli, string nomVend) : base(cidClient, nomCli, prenomCli)
        {
            nomVendeur = nomVend;
        }

        public void majVersBdd()
        {
            // stocke l'objet dans la base de données
        }

        public void setClientVoit(string cidClient, string nomCli, string prenomCli, string nomVend)
        {
            nomVendeur = nomVend;
            setCidClient(cidClient);
            setNomClient(nomCli);
            setPrenomClient(prenomCli);
            //setClient(cidClient, nomCli, prenomCli);
            // pareil
        }

        public string getVendeur()
        {
            return nomVendeur;
        }

        public void setNomVendeur(string nomVend)
        {
            nomVendeur = nomVend;
        }


    }
}
