using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WCFDecrypt.CAM
{
    public class CAM_Decryptage
    {

        private WCFDecrypt.CW.CW_Decryptage oDecrypt;
        private string resultPdf;
        private string resultFichier;

        public CAM_Decryptage()
        {
            this.oDecrypt = new CW.CW_Decryptage();

                        

        }

        public string CAM_generatePdf(string fichier, string cle, string confiance, string mail)
        {
            this.resultPdf = this.oDecrypt.CW_generatePdf(fichier, cle, confiance, mail);

            // Compose a string that consists of three lines.
            string text = DateTime.Now + " : Génération d'un fichier pdf dont le nom est " + fichier + ".pdf.";

            // Write the string to a file.
            //System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt");
            File.AppendAllText("c:\\journalisation\\log.txt", text + "\r\n");
            
            //file.Close();


            return this.resultPdf;
        }

        public string CAM_generateFichierDecrypt(string fichier, string texte)
        {
            this.resultPdf = this.oDecrypt.CW_generateFichierDecrypt(fichier, texte);

            // Compose a string that consists of three lines.
            string text = DateTime.Now + " : Génération d'un fichier décrypté dont le nom est " + fichier + ".txt.";

            // Write the string to a file.
            File.AppendAllText("c:\\journalisation\\log.txt", text + "\r\n");

            //file.Close();


            return this.resultPdf;
        }



    }
}