using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WCFDecrypt.CM
{
    public class CM_Decryptage
    {
        private string resultPdf;
        private string resultFichier;


        public string CM_generatePdf(string fichier, string cle, string confiance, string mail)
        {
            

            string cheminFichier = "C:\\pdf_fichiers\\"+ fichier +".pdf";
            int i = 0;

            while (File.Exists(cheminFichier))
            {
                i++;

                cheminFichier = "C:\\pdf_fichiers\\" + fichier + "(" + i + ").pdf";



            }

            System.IO.FileStream fs = new FileStream(cheminFichier, FileMode.Create);

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);

            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            document.AddAuthor("Groupe 1 eXia");
            document.AddTitle(fichier);

            document.Open();
            document.Add(new Paragraph("Le fichier est : " + fichier + "."));
            document.Add(new Paragraph("La clé utilisée est : " + cle + "."));
            document.Add(new Paragraph("Le taux de confiance est de : " + confiance + " %."));
            document.Add(new Paragraph("Le mail trouvé est (si mail il y a dans le document) : " + mail + "."));
            
            document.Close();
            writer.Close();
            fs.Close();

            this.resultPdf = "Le PDF a bien été généré";

            return this.resultPdf;


        }

        public string CM_generateFichierDecrypt(string fichier, string texte)
        {


            string cheminFichier = "C:\\pdf_fichiers\\" + fichier + ".txt";
            int i = 0;

            while (File.Exists(cheminFichier))
            {
                i++;

                cheminFichier = "C:\\pdf_fichiers\\" + fichier + "(" + i + ").txt";



            }

            
            System.IO.StreamWriter file = new System.IO.StreamWriter(cheminFichier);
            
            
            file.WriteLine(texte);


            file.Close();

            this.resultFichier = "Le fichier décrypté a été créé";

            return this.resultFichier;


        }


    }
}