using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Collaborateur
    {
        private string monCodeCollab;
        private string nomCollab;
        private string prenomCollab;
        private string telCollab;
        private string emailCollab;

        Collaborateur() // constructeur vide
        {

        }


        public Collaborateur(string leCodeCollab, string leNomCollab, string lePrenomCollab, string leTelCollab, string lEmailCollab)
        {
            monCodeCollab = leCodeCollab;
            nomCollab = leNomCollab;
            prenomCollab = lePrenomCollab;
            telCollab = leTelCollab;
            emailCollab = lEmailCollab;
        }

        public void majVersBdd()
        {
            // stocke l'objet dans la base de données
        }

        public void setCollaborateur(string leCodeCollab, string leNomCollab, string lePrenomCollab, string leTelCollab, string lEmailCollab) // modifie tout
        {
            monCodeCollab = leCodeCollab;
            nomCollab = leNomCollab;
            prenomCollab = lePrenomCollab;
            telCollab = leTelCollab;
            emailCollab = lEmailCollab;
        }

        public string getCodeCollaborateur()
        {
            return monCodeCollab;
        }
        public string getNomCollaborateur()
        {
            return nomCollab;
        }

        public string getPrenomCollaborateur()
        {
            return prenomCollab;
        }

        public string getTelCollaborateur()
        {
            return telCollab;
        }

        public string getEmailCollaborateur()
        {
            return emailCollab;
        }

        // au tour des modifications des attributs

        public void setNomCollaborateur(string leNomCollab)
        {
            nomCollab = leNomCollab;
        }

        public void setPrenomCollaborateur(string lePrenomCollab)
        {
            prenomCollab = lePrenomCollab;
        }
        public void setTelCollaborateur(string leTelCollaborateur)
        {
            telCollab = leTelCollaborateur;
        }
        public void setEmailCollaborateur(string lEmailCollaborateur)
        {
            emailCollab = lEmailCollaborateur;
        }

    }
}
