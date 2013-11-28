using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFDecrypt.CW
{
    public class CW_Decryptage
    {
        private WCFDecrypt.CM.CM_Decryptage oDecrypt;
        private bool result;


        public CW_Decryptage()
        {
            this.oDecrypt = new CM.CM_Decryptage();

        }

        public bool CW_generatePdf(string titre)
        {
            this.result = this.oDecrypt.CM_generatePdf(titre);
            return this.result;

 
        }



    }
}