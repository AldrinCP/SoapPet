
package pe.com.ws;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebService(name = "WSSUMASoap", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface WSSUMASoap {


    /**
     * 
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "Saludo", action = "http://tempuri.org/Saludo")
    @WebResult(name = "SaludoResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Saludo", targetNamespace = "http://tempuri.org/", className = "pe.com.ws.Saludo")
    @ResponseWrapper(localName = "SaludoResponse", targetNamespace = "http://tempuri.org/", className = "pe.com.ws.SaludoResponse")
    public String saludo();

    /**
     * 
     * @param b
     * @param a
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "Calculo2", action = "http://tempuri.org/Calculo2")
    @WebResult(name = "Calculo2Result", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Calculo2", targetNamespace = "http://tempuri.org/", className = "pe.com.ws.Calculo2")
    @ResponseWrapper(localName = "Calculo2Response", targetNamespace = "http://tempuri.org/", className = "pe.com.ws.Calculo2Response")
    public String calculo2(
        @WebParam(name = "a", targetNamespace = "http://tempuri.org/")
        int a,
        @WebParam(name = "b", targetNamespace = "http://tempuri.org/")
        int b);

}