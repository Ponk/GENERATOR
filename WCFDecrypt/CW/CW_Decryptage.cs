using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFDecrypt.CW
{
    public class CW_Decryptage
    {
        private WCFDecrypt.CM.CM_Decryptage oDecrypt;
        private string resultPdf;
        private string resultFichier;


        public CW_Decryptage()
        {
            this.oDecrypt = new CM.CM_Decryptage();

        }

        public string CW_generatePdf(string fichier, string cle, string confiance, string mail)
        {
            this.resultPdf = this.oDecrypt.CM_generatePdf(fichier, cle, confiance, mail);
            return this.resultPdf;

 
        }

        public string CW_generateFichierDecrypt(string fichier, string texte)
        {
            this.resultFichier = this.oDecrypt.CM_generateFichierDecrypt(fichier, texte);
            return this.resultFichier;

        }



    }
}