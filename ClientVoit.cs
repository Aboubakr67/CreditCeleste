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

        
        public ClientVoit(string cidClient, string nomCli, string prenomCli, string nomVend, string telCli, string emailCli, string numRueCli, string rueCli, string villeCli,
            string cpCli) : base(cidClient, nomCli, prenomCli, telCli, emailCli, numRueCli, rueCli, villeCli, cpCli)
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

        public void setClientVoit(string cidClient, string nomCli, string prenomCli, string nomVend, string telCli, string emailCli, string numRueCli, string rueCli, string villeCli, string cpCli)
        {
            nomVendeur = nomVend;
            // setClient vient de la mère (Client)
            setClient(cidClient, nomCli, prenomCli, telCli, emailCli, numRueCli, rueCli, villeCli, cpCli);
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
