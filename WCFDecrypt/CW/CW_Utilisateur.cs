using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFDecrypt.CW
{
    public class CW_Utilisateur
    {
        private System.Data.DataSet oDS;
        private WCFDecrypt.CM.CM_Utilisateur oUtilisateur;
        private bool result;

        public CW_Utilisateur()
        {
            this.oDS = new System.Data.DataSet();
            this.oUtilisateur = new WCFDecrypt.CM.CM_Utilisateur();

        }

        public System.Data.DataSet CW_getUser(string rows, string login, string mdp)
        {
            this.oDS = this.oUtilisateur.CM_selectUser(rows, login, mdp);
            return this.oDS;

        }

        public bool CW_sendMail(String adressMailReceiver, string subject, string body)
        {
            this.result = this.oUtilisateur.CM_sendMail(adressMailReceiver, subject, body);
            return this.result;

        }
    }
}