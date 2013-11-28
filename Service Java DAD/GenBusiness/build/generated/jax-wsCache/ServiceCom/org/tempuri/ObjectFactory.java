
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;
import com.microsoft.schemas._2003._10.serialization.arrays.ArrayOfstring;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.tempuri package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _GetDataDocKey_QNAME = new QName("http://tempuri.org/", "DocKey");
    private final static QName _GetDataDocContent_QNAME = new QName("http://tempuri.org/", "DocContent");
    private final static QName _GetDataDocMail_QNAME = new QName("http://tempuri.org/", "DocMail");
    private final static QName _GetDataDocName_QNAME = new QName("http://tempuri.org/", "DocName");
    private final static QName _IsDecryptResponseIsDecryptResult_QNAME = new QName("http://tempuri.org/", "isDecryptResult");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.tempuri
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link GetData }
     * 
     */
    public GetData createGetData() {
        return new GetData();
    }

    /**
     * Create an instance of {@link IsDecryptResponse }
     * 
     */
    public IsDecryptResponse createIsDecryptResponse() {
        return new IsDecryptResponse();
    }

    /**
     * Create an instance of {@link ResetResponse }
     * 
     */
    public ResetResponse createResetResponse() {
        return new ResetResponse();
    }

    /**
     * Create an instance of {@link GetDataResponse }
     * 
     */
    public GetDataResponse createGetDataResponse() {
        return new GetDataResponse();
    }

    /**
     * Create an instance of {@link IsDecrypt }
     * 
     */
    public IsDecrypt createIsDecrypt() {
        return new IsDecrypt();
    }

    /**
     * Create an instance of {@link Reset }
     * 
     */
    public Reset createReset() {
        return new Reset();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "DocKey", scope = GetData.class)
    public JAXBElement<String> createGetDataDocKey(String value) {
        return new JAXBElement<String>(_GetDataDocKey_QNAME, String.class, GetData.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "DocContent", scope = GetData.class)
    public JAXBElement<String> createGetDataDocContent(String value) {
        return new JAXBElement<String>(_GetDataDocContent_QNAME, String.class, GetData.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "DocMail", scope = GetData.class)
    public JAXBElement<String> createGetDataDocMail(String value) {
        return new JAXBElement<String>(_GetDataDocMail_QNAME, String.class, GetData.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "DocName", scope = GetData.class)
    public JAXBElement<String> createGetDataDocName(String value) {
        return new JAXBElement<String>(_GetDataDocName_QNAME, String.class, GetData.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfstring }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "isDecryptResult", scope = IsDecryptResponse.class)
    public JAXBElement<ArrayOfstring> createIsDecryptResponseIsDecryptResult(ArrayOfstring value) {
        return new JAXBElement<ArrayOfstring>(_IsDecryptResponseIsDecryptResult_QNAME, ArrayOfstring.class, IsDecryptResponse.class, value);
    }

}
