/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.gen.businnes.logic;

import business.domain.Document;
import com.gen.data.cad.CAD;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.StringTokenizer;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Pattern;
import javax.annotation.PostConstruct;
import javax.ejb.ActivationConfigProperty;
import javax.ejb.MessageDriven;
import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.MessageListener;
import javax.jms.ObjectMessage;
import javax.xml.ws.WebServiceRef;
import org.tempuri.ServiceCom;

/**
 *
 * @author Hubiquitos
 */
@MessageDriven(mappedName = "jms/DocumentQueue", activationConfig = {
    @ActivationConfigProperty(propertyName = "destinationType", propertyValue = "javax.jms.Queue")
})
public class DocumentProcessor implements MessageListener {
    @WebServiceRef(wsdlLocation = "http://localhost:46969/ServiceCom.svc?wsdl")
    private ServiceCom service;

    public Connection connect;
    public Statement stmt;
    public ResultSet rs;

    public int FrenchWords = 0;
    public double tauxConfiance = 0;
    public String DocName;
    public String DocEmail;
    public String DocContent;
    public String DocKey;
    public String[] words;
    public List<String> dico;
    
    public CAD cad = new CAD("jdbc:mysql://localhost/dictionnairebdd", "root", "");

    public DocumentProcessor() throws SQLException, ClassNotFoundException {
        
    }
        
    @PostConstruct
    private void getDico()
    {
        try {
            connect = cad.OpenConnection();
            stmt = connect.createStatement();
            rs = stmt.executeQuery("SELECT MOT_DICTIONNAIRE FROM t_dictionnairefull");
            this.dico = new ArrayList<>();
            while(rs.next())
            {
                dico.add(rs.getString("MOT_DICTIONNAIRE"));
            }
            
            rs.close();
            stmt.close();
            connect.close();

        } catch (SQLException | ClassNotFoundException ex) {
            Logger.getLogger(DocumentProcessor.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
        
    @Override
    public void onMessage(Message message) {

        if (message instanceof ObjectMessage) {
            try {
                ObjectMessage objMsg = (ObjectMessage) message;
                Document document = (Document) objMsg.getObject();
                DocName = document.getName();
                DocKey = document.getKey();
                DocContent = document.getContent();
                
                String delims = " ,()[].;' \"\\/<>&²0123456789*+$€_-~µ£¨^:!?";
                String splitString = DocContent;
                StringTokenizer st = new StringTokenizer(splitString, delims);
                
                words = DocContent.split("\\s+");

                FrenchWords = 0;
                
                while (st.hasMoreElements())
                {
                    if(dico.contains(st.nextElement()))
                    {
                        FrenchWords++;
                    }
                }

                for(String word : words)
                {
                    if(isEmail(word))
                    {
                        tauxConfiance = 100;
                        DocEmail = word;
                    }
                    else
                    {
                        tauxConfiance = (100 * FrenchWords/ words.length);
                    }
                }
                    
                System.out.println("Mots Français: "+FrenchWords);
                System.out.println("Taux de confiance: "+tauxConfiance+" %");
                System.out.println("Mail du terroriste: "+DocEmail);
                
                if(tauxConfiance >= 50)
                {
                    SendResults(DocName, DocContent, DocKey, DocEmail, tauxConfiance);
                }
                
                FrenchWords = 0;
                DocEmail = "";
                                
                //System.out.println("le document " + document + " va être retiré de la queue");
            } catch (JMSException ex) {
                Logger.getLogger(DocumentProcessor.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
    
    private boolean isEmail(String Email)
    {
        return Pattern.matches("^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)+$", Email);
    }

    public void SendResults(String DocName, String DocContent, String DocKey, String DocEmail, Double DocTaux)
    {
            System.out.println("Fichier trouvé : " + DocName);
            System.out.println("content : " + DocContent);
            System.out.println("mail : " + DocEmail);
            System.out.println("key : " + DocKey);
            
            

            getData(DocName, DocContent, DocKey, DocEmail, DocTaux);
    }

    private void getData(java.lang.String docName, java.lang.String docContent, java.lang.String docKey, java.lang.String docMail, java.lang.Double docTaux) {
        // Note that the injected javax.xml.ws.Service reference as well as port objects are not thread safe.
        // If the calling of port operations may lead to race condition some synchronization is required.
        org.tempuri.IServiceCom port = service.getBasicHttpBindingIServiceCom();
        port.getData(docName, docContent, docKey, docMail, docTaux);
    }
    
}