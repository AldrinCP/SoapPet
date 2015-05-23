
package pe.com.soappet.service;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "DoctorWS", targetNamespace = "http://service.soappet.com.pe/", wsdlLocation = "http://localhost:8080/DoctorWS/DoctorWS?wsdl")
public class DoctorWS_Service
    extends Service
{

    private final static URL DOCTORWS_WSDL_LOCATION;
    private final static WebServiceException DOCTORWS_EXCEPTION;
    private final static QName DOCTORWS_QNAME = new QName("http://service.soappet.com.pe/", "DoctorWS");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://localhost:8080/DoctorWS/DoctorWS?wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        DOCTORWS_WSDL_LOCATION = url;
        DOCTORWS_EXCEPTION = e;
    }

    public DoctorWS_Service() {
        super(__getWsdlLocation(), DOCTORWS_QNAME);
    }

    public DoctorWS_Service(WebServiceFeature... features) {
        super(__getWsdlLocation(), DOCTORWS_QNAME, features);
    }

    public DoctorWS_Service(URL wsdlLocation) {
        super(wsdlLocation, DOCTORWS_QNAME);
    }

    public DoctorWS_Service(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, DOCTORWS_QNAME, features);
    }

    public DoctorWS_Service(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public DoctorWS_Service(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns DoctorWS
     */
    @WebEndpoint(name = "DoctorWSPort")
    public DoctorWS getDoctorWSPort() {
        return super.getPort(new QName("http://service.soappet.com.pe/", "DoctorWSPort"), DoctorWS.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns DoctorWS
     */
    @WebEndpoint(name = "DoctorWSPort")
    public DoctorWS getDoctorWSPort(WebServiceFeature... features) {
        return super.getPort(new QName("http://service.soappet.com.pe/", "DoctorWSPort"), DoctorWS.class, features);
    }

    private static URL __getWsdlLocation() {
        if (DOCTORWS_EXCEPTION!= null) {
            throw DOCTORWS_EXCEPTION;
        }
        return DOCTORWS_WSDL_LOCATION;
    }

}
