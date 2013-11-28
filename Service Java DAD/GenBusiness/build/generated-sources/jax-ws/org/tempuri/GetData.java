
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java pour anonymous complex type.
 * 
 * <p>Le fragment de schéma suivant indique le contenu attendu figurant dans cette classe.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="DocName" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DocContent" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DocKey" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DocMail" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DocTaux" type="{http://www.w3.org/2001/XMLSchema}double" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "docName",
    "docContent",
    "docKey",
    "docMail",
    "docTaux"
})
@XmlRootElement(name = "GetData")
public class GetData {

    @XmlElementRef(name = "DocName", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> docName;
    @XmlElementRef(name = "DocContent", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> docContent;
    @XmlElementRef(name = "DocKey", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> docKey;
    @XmlElementRef(name = "DocMail", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> docMail;
    @XmlElement(name = "DocTaux")
    protected Double docTaux;

    /**
     * Obtient la valeur de la propriété docName.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDocName() {
        return docName;
    }

    /**
     * Définit la valeur de la propriété docName.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDocName(JAXBElement<String> value) {
        this.docName = value;
    }

    /**
     * Obtient la valeur de la propriété docContent.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDocContent() {
        return docContent;
    }

    /**
     * Définit la valeur de la propriété docContent.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDocContent(JAXBElement<String> value) {
        this.docContent = value;
    }

    /**
     * Obtient la valeur de la propriété docKey.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDocKey() {
        return docKey;
    }

    /**
     * Définit la valeur de la propriété docKey.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDocKey(JAXBElement<String> value) {
        this.docKey = value;
    }

    /**
     * Obtient la valeur de la propriété docMail.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDocMail() {
        return docMail;
    }

    /**
     * Définit la valeur de la propriété docMail.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDocMail(JAXBElement<String> value) {
        this.docMail = value;
    }

    /**
     * Obtient la valeur de la propriété docTaux.
     * 
     * @return
     *     possible object is
     *     {@link Double }
     *     
     */
    public Double getDocTaux() {
        return docTaux;
    }

    /**
     * Définit la valeur de la propriété docTaux.
     * 
     * @param value
     *     allowed object is
     *     {@link Double }
     *     
     */
    public void setDocTaux(Double value) {
        this.docTaux = value;
    }

}
