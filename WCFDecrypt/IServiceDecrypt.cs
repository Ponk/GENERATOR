﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace WCFDecrypt
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceDecrypt
    {
        [OperationContract]
        string[] EncryptDecrypt(string name, string content);

        [OperationContract]
        System.Data.DataSet authentification(string rows, string login, string mdp);

        [OperationContract]
        bool envoiMail(String adressMailReceiver, string subject, string body);

        [OperationContract]
        string generatePdf(string fichier, string cle, string confiance, string mail);

        [OperationContract]
        string generateFichierDecrypt(string fichier, string texte);
    }
}
